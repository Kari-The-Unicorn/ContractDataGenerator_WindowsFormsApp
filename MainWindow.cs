using CsvHelper;
using GemBox.Pdf;
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

        private void bUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Wybierz plik";
            //openFile.Filter = "DOCX|*.docx|DOC|*.doc";
            openFile.Filter = "PDF|*.pdf";

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
                    //if (destinationPath.Contains("docx"))
                    //{
                    //    extens = ".docx";
                    //}
                    //else
                    //{
                    //    extens = ".doc";
                    //}

                    destinationPath = destinationPath
                        //.Replace(".docx", string.Empty)
                        .Replace(".pdf", string.Empty) + "_" + DateTime.Now.ToString()
                        .Replace("/", string.Empty)
                        .Replace(":", string.Empty)
                        .Replace(" ", string.Empty)
                        + extens;
                }
                // Save copy to destinationPath
                File.Copy(fileName, destinationPath, false);
                ComponentInfo.SetLicense("FREE-LIMITED-KEY");
                //var document = DocumentModel.Load(safeFileName);
                //string text = document.Content.ToString();

                using (var document = PdfDocument.Load(safeFileName))
                {
                    foreach (var page in document.Pages)
                    {
                        var contractWhereInfo = string.Empty;
                        var contractInvestorInfo = string.Empty;
                        var contractContractorInfo = string.Empty;
                        var pageContent = page.Content.ToString();
                        contractWhereInfo = GetContractWhere(contractWhereInfo, pageContent);
                        contractInvestorInfo = GetContractInvestor(contractInvestorInfo, pageContent);
                        contractContractorInfo = GetContractContractor(contractContractorInfo, pageContent);
                        var today = DateTime.Today.Date.ToShortDateString().ToString().Replace(@"/", string.Empty);
                        newFilePath = Directory.GetCurrentDirectory().ToString() +
                            "\\UserFiles\\" + safeFileName + today + ".csv";
                        WriteToCsv(contractWhereInfo, contractInvestorInfo, contractContractorInfo);
                        bDownloadFile.Enabled = true;
                    }
                }
            }
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

        private static string GetContractContractor(string contractContractorInfo, string pageContent)
        {
            var contractContractorInfoMatch = Regex.Match(pageContent,
                                        $@"(?<=,.a.)(.*)(?=zwaną.+Wykonawcą)",
                                        RegexOptions.IgnoreCase);
            if (contractContractorInfoMatch.Success)
            {
                contractContractorInfo = contractContractorInfoMatch.Value.ToString()
                    .Replace(":", string.Empty)
                    .Replace("2.", string.Empty)
                    .Replace("Firmą", string.Empty)
                    .Replace("wpisaną", "wpisana")
                    .Replace("reprezentowaną", "reprezentowana")
                    .Trim();
            }

            return contractContractorInfo;
        }

        private static string GetContractInvestor(string contractInvestorInfo, string pageContent)
        {
            var contractInvestorInfoMatch = Regex.Match(pageContent,
                                        $@"(?<=pomiędzy)(.*)(?=zwaną.+Inwestorem)",
                                        RegexOptions.IgnoreCase);
            if (contractInvestorInfoMatch.Success)
            {
                contractInvestorInfo = contractInvestorInfoMatch.Value.ToString()
                    .Replace(":", string.Empty)
                    .Replace("1.", string.Empty)
                    .Replace("Firmą", string.Empty)
                    .Replace("wpisaną", "wpisana")
                    .Replace("reprezentowaną", "reprezentowana")
                    .Trim();
            }

            return contractInvestorInfo;
        }

        private static string GetContractWhere(string contractWhereInfo, string pageContent)
        {
            var whereInfoMatch = Regex.Match(pageContent,
                                        $@"(?<=Zawarta.w)(.*)(?=pomiędzy)",
                                        RegexOptions.IgnoreCase);
            if (whereInfoMatch.Success)
            {
                contractWhereInfo = whereInfoMatch.Value.ToString()
                    .Replace("Warszawie", "Warszawa")
                    .Replace("roku", "r.")
                    .Trim();
            }

            return contractWhereInfo;
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
                    
                        // Can use dialog.FileName
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
    }
}
