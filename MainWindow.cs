using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Code7248.word_reader;
using CsvHelper;
//using GemBox.Pdf;

namespace ContractDataGenerator_WindowsFormsApp
{
    public partial class MainWindow : Form
    {
        private string fileName;

        private string safeFileName;

        private string newFilePath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WriteToCsv(string contractWhereInfo, string contractInvestorInfo, string contractContractorInfo)
        {
            using (var writer = new StreamWriter(newFilePath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.GetCultureInfo("en-GB")))
            {
                var records = new List<Header>();
                records.Add(new Header
                {
                    DataMiejsce = contractWhereInfo,
                    Inwestor = contractInvestorInfo,
                    Wykonawca = contractContractorInfo,
                });
                csvWriter.WriteRecords(records);
            }
        }

        private void bDownloadFile_Click(object sender, EventArgs e)
        {
            try
            {
                //var form = new Form1();
                //DialogResult result = form.ShowDialog();
                //if (result == DialogResult.OK) // Test result.
                //{
                //    string pathDestination = newFilePath;
                //    //Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Files");
                //    foreach (string item in form.)
                //    {
                //        File.Copy(item, Path.Combine(pathDestination, Path.GetFileName(item)));
                //    }
                //}
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = saveFileDialog.OpenFile())
                    {
                        // Save data
                    }
                    //File.WriteAllText(newFilePath);
                }
            }
            catch
            {
                MessageBox.Show(newFilePath + " - ścieżka jest nieprawidłowa");
            }
        }

        private void bUploadText_Click(object sender, EventArgs e)
        {
            var uploadForm = new UploadText();
            uploadForm.ShowDialog();
        }

        private void bUploadDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Wybierz plik";
            openFile.Filter = "DOCX|*.docx|DOC|*.doc";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string errorMessage = string.Empty;
                MessageBox.Show("Kliknij OK żeby potwierdzić plik: " + openFile.SafeFileName + ".");
                if (openFile.FileName != null)
                {
                    lUploadFileInfo.Text = "Wybrany plik: " + openFile.SafeFileName;
                    fileName = openFile.FileName;
                    safeFileName = openFile.SafeFileName;
                }
                else
                {
                    errorMessage = "Proszę załączyć 1-stronicowy plik w formacie .PDF.";
                    MessageBox.Show(errorMessage);
                }

                //Copy file to destination
                var destinationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + @"UserFiles\" + safeFileName;
                if (File.Exists(destinationPath))
                {
                    string extens = string.Empty;
                    destinationPath = destinationPath
                        .Replace(".docx", string.Empty)
                        + "_" +
                        DateTime.Now.ToString()
                        .Replace("/", string.Empty)
                        .Replace(":", string.Empty)
                        .Replace(" ", string.Empty)
                        + extens;
                }
                // Save copy to destinationPath
                File.Copy(fileName, destinationPath, false);
                // Extract text from doc file
                TextExtractor extractor = new TextExtractor(destinationPath);
                string downloadedText = extractor.ExtractText();
                // Extract selected text from doc file
                var contractWhereInfo = string.Empty;
                var contractInvestorInfo = string.Empty;
                var contractContractorInfo = string.Empty;
                contractWhereInfo = Helpers.TextHelpers.GetContractWhere(contractWhereInfo, downloadedText);
                contractInvestorInfo = Helpers.TextHelpers.GetContractInvestor(contractInvestorInfo, downloadedText);
                contractContractorInfo = Helpers.TextHelpers.GetContractContractor(contractContractorInfo, downloadedText);
                var today = DateTime.Today.Date.ToShortDateString().ToString().Replace(@"/", string.Empty)
                            + "_" + DateTime.Now.ToString("hh:mm:ss").Replace(":", string.Empty).Trim();
                newFilePath = Directory.GetCurrentDirectory().ToString() +
                    "\\UserFiles\\" + safeFileName + today + ".csv";
                // Create csv
                WriteToCsv(contractWhereInfo, contractInvestorInfo, contractContractorInfo);
                bDownloadFile.Enabled = true;
                bDownloadFile.Text = "Pobierz plik (aktywny)";
            }
        }

        private void bDownloadFile_Paint(object sender, PaintEventArgs e)
        {
            Helpers.StyleHelpers.Get3DButtonStyle(bDownloadFile, e);
        }

        private void bUploadText_Paint(object sender, PaintEventArgs e)
        {
            Helpers.StyleHelpers.Get3DButtonStyle(bUploadText, e);
        }

        private void bUploadDoc_Paint(object sender, PaintEventArgs e)
        {
            Helpers.StyleHelpers.Get3DButtonStyle(bUploadDoc, e);
        }

        private void bUploadPdf_Paint(object sender, PaintEventArgs e)
        {
            Helpers.StyleHelpers.Get3DButtonStyle(bUploadPdf, e);
        }

        public void bUploadPdf_Click(object sender, EventArgs e)
        {
        }
    }
}
