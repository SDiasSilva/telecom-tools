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
    internal class FileController
    {
        private string? pathFile;
        List<string>? iccids;
        List<string>? lpas;
        private string? directoyGenerated;

        public FileController()
        {
            pathFile = "";
        }

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
        private void OpenFileExplorer(string directoyGenerated)
        {
            DialogResult result = MessageBox.Show("Do you wanna to open on the file explorer?", "Open File Explorer", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("explorer.exe", directoyGenerated);
            }
        }
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
