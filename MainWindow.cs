using Code7248.word_reader;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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

        private void WriteToCsv(string contractWhereInfo, string contractEmployerInfo, string contractEmployeeInfo,
            string contractInvestorInfo, string contractValue)
        {
            using (var writer = new StreamWriter(newFilePath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.GetCultureInfo("en-GB")))
            {
                var records = new List<Header>();
                records.Add(new Header
                {
                    DataMiejsce = contractWhereInfo,
                    Zamawiajacy = contractEmployerInfo,
                    Wykonawca = contractEmployeeInfo,
                    Inwestor = contractInvestorInfo,
                    WartoscUmowy = contractValue
                });
                csvWriter.WriteRecords(records);
            }
        }

        private void bDownloadFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = saveFileDialog.OpenFile())
                    {
                        // Save data
                    }
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
                    errorMessage = "Błąd wgrywania pliku.";
                    MessageBox.Show(errorMessage);
                }
                // Extract text from doc file
                TextExtractor extractor = new TextExtractor(fileName);
                string rawDownloadedText = extractor.ExtractText().Replace("\n", " ").Replace("\t", " "); ;
                string downloadedText = Regex.Replace(rawDownloadedText, $@"\s\s+", " ");

                // Extract selected text from doc file
                var contractWhereInfo = Helpers.TextHelpers.GetContractWhere(downloadedText);
                var contractEmployerInfo = Helpers.TextHelpers.GetContractEmployer(downloadedText);
                var contractEmployeeInfo = Helpers.TextHelpers.GetContractEmployee(downloadedText);
                var contractInvestorInfo = Helpers.TextHelpers.GetContractInvestor(downloadedText);
                var contractValue = Helpers.TextHelpers.GetContractValue(downloadedText);
                var today = DateTime.Now.ToString("ddMMyyyy_HHmmss");
                newFilePath = Directory.GetCurrentDirectory().ToString() +
                    "\\UserFiles\\" + safeFileName.Replace(".doc", "").Replace(".docx", "") + "_" + today + ".csv";
                // Create csv
                WriteToCsv(contractWhereInfo, contractEmployerInfo, contractEmployeeInfo, contractInvestorInfo, contractValue);
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

        public void bUploadPdf_Click(object sender, EventArgs e)
        {
        }
    }
}
