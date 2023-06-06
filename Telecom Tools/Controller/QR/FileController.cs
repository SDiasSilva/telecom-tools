using iTextSharp.text;
using iTextSharp.text.pdf;
using QRCoder;
using System.Drawing.Imaging;
using System.IO.Compression;
using Telecom_Tools.Model;
using Telecom_Tools.Exceptions;
using static QRCoder.QRCodeGenerator;
using Image = iTextSharp.text.Image;

namespace Telecom_Tools.Controller
{
    /// <summary>
    /// This class handles file operations such as opening a file, generating QR codes and PDF files, 
    /// compressing images, deleting files, and opening the file explorer.
    /// </summary>
    internal class FileController
    {
        private string? pathFile;
        List<string>? iccids;
        List<string>? lpas;
        private string? directoyGenerated;

        /// <summary>
        /// Initializes a new instance of the FileController class.
        /// </summary>
        public FileController()
        {
            pathFile = "";
        }

        /// <summary>
        /// Opens a file dialog and assigns the selected file path to the pathFile variable.
        /// Sets the file name in the provided TextBox control.
        /// </summary>
        /// <param name="openFileTextBox">The TextBox control to display the selected file name.</param>
        /// <returns>The path of the opened file.</returns>
        public string OpenFile(TextBox openFileTextBox)
        {
            string opennedFileName;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathFile = openFileDialog.FileName;

                Model.File.SetFileName(Path.GetFileName(openFileDialog.FileName));
                opennedFileName = Model.File.GetFileName();
                openFileTextBox.Text = opennedFileName;

            }
            else if (result == DialogResult.Cancel)
            {
                return null!;
            }
            return pathFile!;
        }

        /// <summary>
        /// Generates QR codes, PDF files, and compresses images based on the selected options.
        /// </summary>
        /// <param name="pdfCheckBox">The CheckBox control indicating whether to generate a PDF file.</param>
        /// <param name="zipCheckBox">The CheckBox control indicating whether to compress images into a ZIP file.</param>
        /// <param name="pngCheckBox">The CheckBox control indicating whether to delete the generated PNG files.</param>
        /// <param name="logoCheckBox">The CheckBox control indicating whether to add a logo to the QR codes.</param>
        public void Generate(CheckBox pdfCheckBox, CheckBox zipCheckBox, CheckBox pngCheckBox, CheckBox logoCheckBox)
        {
            string valueTextBox = Model.File.GetFileName();
            string fileName = valueTextBox;

            try
            {
                GenerateQR(logoCheckBox);
                GeneratePdf(directoyGenerated!, fileName, pdfCheckBox);
                CompressImages(fileName, directoyGenerated!, zipCheckBox);
                DeleteAllPng(directoyGenerated!, pdfCheckBox, zipCheckBox, pngCheckBox);
                OpenFileExplorer(directoyGenerated!);

            }
            catch (Exception e)
            {
                Type type = e.GetType();
                if (type == typeof(ArgumentNullException))
                {
                    if (valueTextBox == null || valueTextBox == "")
                    {
                        ExceptionMessage.ExceptionMessageFileNotselected();
                        Console.WriteLine(e.Message);
                    }

                }
                else if (type == typeof(IndexOutOfRangeException))
                {
                    ExceptionMessage.ExceptionMessageFileOutOfformat();
                    Console.WriteLine(e.Message);
                }
                else
                {
                    ExceptionMessage.ExceptionMessageUnKnown();
                    Console.Write(e.Message);
                }
            }
            finally { }
        }

        /// <summary>
        /// Generates QR codes based on the contents of the opened file.
        /// </summary>
        /// <param name="logoCheckBox">The CheckBox control indicating whether to add a logo to the QR codes.</param>
        private void GenerateQR(CheckBox logoCheckBox)
        {
            string fileName = Path.GetFileNameWithoutExtension(pathFile)!;
            string directoryPath = Path.GetDirectoryName(pathFile)!;

            int moduleWidth = ModuleWidth.GetModuleWidth();
            int versionNumber = Model.Version.GetVersionNumber();
            string errorCorrectionLevel = ErrorCorrectionLevel.GetErrorCorrectionLevel();

            string iccid;
            string lpa;

            iccids = new List<string>();
            lpas = new List<string>();

            using (StreamReader sr = new StreamReader(pathFile!))
            {
                string line;
                int lineCount = 0;
                int iccidCount = 0;
                int lpaCount = 0;
                while ((line = sr.ReadLine()!) != null)
                {
                    lineCount++;
                    string[] parts = line.Split(' ');
                    iccid = parts[0];
                    iccids.Add(parts[0]);

                    lpa = parts[1];
                    lpas.Add(parts[1]);

                    iccidCount++;
                    lpaCount++;

                    if (iccidCount == lpaCount && lineCount == iccidCount && lpaCount == lineCount && line.Contains(" LPA:"))
                    {
                        directoyGenerated = @directoryPath + "\\" + fileName;
                        DirectoryInfo di = Directory.CreateDirectory(directoyGenerated);
                        GenerateQRCodeImages(moduleWidth, versionNumber, errorCorrectionLevel, logoCheckBox);
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
            }
        }

        /// <summary>
        /// Generates QR code images based on the specified module width, version number, error correction level, and logo option.
        /// </summary>
        /// <param name="moduleWidth">The module width of the QR codes.</param>
        /// <param name="versionNumber">The version number of the QR codes.</param>
        /// <param name="errorCorrectionLevel">The error correction level of the QR codes.</param>
        /// <param name="logoCheckBox">The CheckBox control indicating whether to add a logo to the QR codes.</param>
        private void GenerateQRCodeImages(int moduleWidth, int versionNumber, string errorCorrectionLevel, CheckBox logoCheckBox)
        {
            string imagePath;
            string imageName;
            HashSet<string> imageNames = new HashSet<string>();
            QRCodeGenerator qrGenerator;
            QRCodeData qrCodeData;
            QRCode qrCode;
            Bitmap qrCodeImage;

            for (int i = 0; i < iccids!.Count; i++)
            {
                qrGenerator = new QRCodeGenerator();
                qrCodeData = qrGenerator.CreateQrCode(lpas![i], (QRCodeGenerator.ECCLevel)Enum.Parse(typeof(QRCodeGenerator.ECCLevel), errorCorrectionLevel), false, false, EciMode.Default, versionNumber);

                qrCode = new QRCode(qrCodeData);
                qrCodeImage = qrCode.GetGraphic(moduleWidth);

                PutLogo(logoCheckBox, qrCodeImage);

                imageName = iccids[i] + ".png";
                imagePath = Path.Combine(directoyGenerated!, imageName);

                if (imageNames.Contains(imageName))
                {
                    int sequencial = 1;
                    string nomeBase = Path.GetFileNameWithoutExtension(imageName);
                    string extensao = Path.GetExtension(imageName);
                    string novoNome;

                    do
                    {
                        novoNome = $"{nomeBase}({sequencial}){extensao}";
                        sequencial++;
                    }
                    while (imageNames.Contains(novoNome));

                    imageName = novoNome;
                    imagePath = Path.Combine(directoyGenerated!, imageName);
                }

                imageNames.Add(imageName);

                qrCodeImage.Save(imagePath, ImageFormat.Png);
            }
        }

        /// <summary>
        /// Generates a PDF file containing the generated QR codes and associated information.
        /// </summary>
        /// <param name="directoyGenerated">The directory where the files are generated.</param>
        /// <param name="fileName">The file name for the generated PDF file.</param>
        /// <param name="pdfCheckBox">The CheckBox control indicating whether to generate a PDF file.</param>
        private void GeneratePdf(string directoyGenerated, string fileName, CheckBox pdfCheckBox)
        {
            string[] pngFiles = Directory.GetFiles(directoyGenerated, "*.png");
            string pdfFile = Path.Combine(directoyGenerated, fileName + ".pdf");

            int posicao = 0;

            if (pdfCheckBox.Checked)
            {
                using (FileStream fs = new FileStream(pdfFile, FileMode.Create))
                {
                    using (iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4))
                    {
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);
                        document.Open();

                        string title = fileName;
                        Paragraph titleParagraph = new Paragraph(title, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 32, iTextSharp.text.Font.NORMAL));
                        titleParagraph.Alignment = Element.ALIGN_CENTER;
                        document.Add(titleParagraph);
                        document.Add(new Paragraph(" "));
                        document.Add(new Paragraph(" "));

                        int qrCodesPerRow = 2;

                        float cellWidthPercentage = 100;

                        int pngAmount = pngFiles.Length;
                        var allImagesExceptLast = pngFiles.Take(pngFiles.Length - 1);
                        var lastImage = pngFiles.Last();

                        PdfPTable table = new PdfPTable(qrCodesPerRow);
                        PdfPTable lastTable = new PdfPTable(1);
                        table.WidthPercentage = cellWidthPercentage;

                        for (int i = 0; i < pngAmount; i++)
                        {
                            Image imageExcept = Image.GetInstance(pngFiles[i]);

                            PdfPCell cell = new PdfPCell();

                            Paragraph iccidParagraph = new Paragraph("ICCID: " + iccids![posicao], new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL));
                            Paragraph lpaParagraph = new Paragraph(lpas![posicao], new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL));
                            iccidParagraph.Alignment = Element.ALIGN_CENTER;
                            lpaParagraph.Alignment = Element.ALIGN_CENTER;

                            cell.AddElement(iccidParagraph);
                            cell.AddElement(imageExcept);
                            cell.AddElement(lpaParagraph);

                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            cell.PaddingBottom = 10;
                            table.AddCell(cell);

                            document.Add(table);


                            table.DeleteBodyRows();

                            posicao++;
                        }
                        if (pngAmount % 2 == 1)
                        {
                            Image theLastImage = Image.GetInstance(lastImage);

                            PdfPCell lastCell = new PdfPCell();

                            Paragraph lastIccidParagraph = new Paragraph("ICCID: " + iccids![iccids.Count - 1], new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL));
                            Paragraph lastLpaParagraph = new Paragraph(lpas![lpas.Count - 1], new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL));
                            lastIccidParagraph.Alignment = Element.ALIGN_CENTER;
                            lastLpaParagraph.Alignment = Element.ALIGN_CENTER;

                            lastTable.WidthPercentage = 50;

                            lastCell.AddElement(lastIccidParagraph);
                            lastCell.AddElement(theLastImage);
                            lastCell.AddElement(lastLpaParagraph);

                            lastCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            lastCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            lastCell.PaddingBottom = 10;
                            lastTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            lastTable.AddCell(lastCell);

                            document.Add(lastTable);
                            lastTable.DeleteBodyRows();
                        }

                        document.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Compresses the generated PNG files into a ZIP file.
        /// </summary>
        /// <param name="nameZip">The name of the ZIP file.</param>
        /// <param name="directoyGenerated">The directory where the files are generated.</param>
        /// <param name="zipCheckBox">The CheckBox control indicating whether to compress images into a ZIP file.</param>
        private void CompressImages(string nameZip, string directoyGenerated, CheckBox zipCheckBox)
        {
            var files = Directory.GetFiles(directoyGenerated);

            var imageFiles = files.Where(f => Path.GetExtension(f) == ".png");

            if (zipCheckBox.Checked)
            {
                using (var archive = ZipFile.Open(directoyGenerated + "\\" + nameZip + ".zip", ZipArchiveMode.Create))
                {
                    foreach (var imageFile in imageFiles)
                    {
                        archive.CreateEntryFromFile(imageFile, Path.GetFileName(imageFile), CompressionLevel.Optimal);
                    }
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Deletes the generated PNG files based on the selected options.
        /// </summary>
        /// <param name="directoyGenerated">The directory where the files are generated.</param>
        /// <param name="pdfCheckBox">The CheckBox control indicating whether to generate a PDF file.</param>
        /// <param name="zipCheckBox">The CheckBox control indicating whether to compress images into a ZIP file.</param>
        /// <param name="pngCheckBox">The CheckBox control indicating whether to delete the generated PNG files.</param>
        private void DeleteAllPng(string directoyGenerated, CheckBox pdfCheckBox, CheckBox zipCheckBox, CheckBox pngCheckBox)
        {
            string[] pngFiles = Directory.GetFiles(directoyGenerated, "*.png");

            if (pdfCheckBox.Checked || zipCheckBox.Checked)
            {
                if (!pngCheckBox.Checked)
                {
                    foreach (string pngFile in pngFiles)
                    {
                        System.IO.File.Delete(pngFile);
                    }
                }
            }
        }

        /// <summary>
        /// Opens the file explorer at the specified directory.
        /// </summary>
        /// <param name="directoyGenerated">The directory to open in the file explorer.</param>
        private void OpenFileExplorer(string directoyGenerated)
        {
            DialogResult result = MessageBox.Show("Do you wanna to open on the file explorer?", "Open File Explorer", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("explorer.exe", directoyGenerated);
            }
        }

        /// <summary>
        /// Adds a logo to the QR code image if the logo option is selected.
        /// </summary>
        /// <param name="logoCheckBox">The CheckBox control indicating whether to add a logo to the QR codes.</param>
        /// <param name="qrCodeImage">The QR code image to add the logo to.</param>
        private void PutLogo(CheckBox logoCheckBox, Bitmap qrCodeImage)
        {
            if (logoCheckBox.Checked)
            {
                Bitmap logo = new Bitmap(global::Telecom_Tools.Properties.Resources.gieseckedevrient);
                int logoWidth = qrCodeImage.Width / 5;
                int logoHeight = logo.Height * logoWidth / logo.Width;
                logo = new Bitmap(logo, logoWidth, logoHeight);

                int logoX = (qrCodeImage.Width - logoWidth) / 2;
                int logoY = (qrCodeImage.Height - logoHeight) / 2;
                using (Graphics g = Graphics.FromImage(qrCodeImage))

                {
                    g.DrawImage(logo, logoX, logoY, logoWidth, logoHeight);
                }
            }
        }
    }
}
