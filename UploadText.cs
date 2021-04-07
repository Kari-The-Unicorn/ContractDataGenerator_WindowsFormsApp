using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CsvHelper;

namespace ContractDataGenerator_WindowsFormsApp
{
    public partial class UploadText : Form
    {

        private string newFilePath;
        private string safeFileName;
        public UploadText()
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

        private void bUploadFile_Click(object sender, EventArgs e)
        {
            try
            {
                string rawTextToLoad = rtbUploadText.Text.Replace("\n", " ").Replace("\t", " ");
                string textToLoad = Regex.Replace(rawTextToLoad, $@"\s\s+", " ");
                if (!string.IsNullOrEmpty(textToLoad))
                {
                    var contractWhereInfo = Helpers.TextHelpers.GetContractWhere(textToLoad);
                    var contractEmployerInfo = Helpers.TextHelpers.GetContractEmployer(textToLoad);
                    var contractEmployeeInfo = Helpers.TextHelpers.GetContractEmployee(textToLoad);
                    var contractInvestorInfo = Helpers.TextHelpers.GetContractInvestor(textToLoad);
                    var contractValue = Helpers.TextHelpers.GetContractValue(textToLoad);
                    var today = DateTime.Now.ToString("ddMMyyyy_HHmmss");
                    newFilePath = Directory.GetCurrentDirectory().ToString() +
                        "\\UserFiles\\" + safeFileName + today + ".csv";
                    // Create csv
                    WriteToCsv(contractWhereInfo, contractEmployerInfo, contractEmployeeInfo, contractInvestorInfo, contractValue);
                    //bDownloadFile.Enabled = true;
                    //bDownloadFile.Text = "Pobierz plik (aktywny)";
                }
            }
            catch
            {
                MessageBox.Show("Coś poszło nie tak.");
            }
        }

        private void bUploadFile_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bUploadFile.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}
