
namespace ContractDataGenerator_WindowsFormsApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pMainUload = new System.Windows.Forms.Panel();
            this.bUploadDoc = new System.Windows.Forms.Button();
            this.bUploadText = new System.Windows.Forms.Button();
            this.lUploadFileInfo = new System.Windows.Forms.Label();
            this.bUploadPdf = new System.Windows.Forms.Button();
            this.bDownloadFile = new System.Windows.Forms.Button();
            this.ttDocLimitInfo = new System.Windows.Forms.ToolTip(this.components);
            this.ttUploadText = new System.Windows.Forms.ToolTip(this.components);
            this.pMainDownload = new System.Windows.Forms.Panel();
            this.ttDownloadText = new System.Windows.Forms.ToolTip(this.components);
            this.pMainUload.SuspendLayout();
            this.pMainDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMainUload
            // 
            this.pMainUload.Controls.Add(this.bUploadDoc);
            this.pMainUload.Controls.Add(this.bUploadText);
            this.pMainUload.Controls.Add(this.lUploadFileInfo);
            this.pMainUload.Controls.Add(this.bUploadPdf);
            this.pMainUload.Location = new System.Drawing.Point(221, 47);
            this.pMainUload.Name = "pMainUload";
            this.pMainUload.Size = new System.Drawing.Size(349, 288);
            this.pMainUload.TabIndex = 0;
            // 
            // bUploadDoc
            // 
            this.bUploadDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bUploadDoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bUploadDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUploadDoc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bUploadDoc.Location = new System.Drawing.Point(42, 47);
            this.bUploadDoc.Name = "bUploadDoc";
            this.bUploadDoc.Size = new System.Drawing.Size(264, 46);
            this.bUploadDoc.TabIndex = 4;
            this.bUploadDoc.Text = "Wgraj plik .doc/.docx";
            this.bUploadDoc.UseVisualStyleBackColor = false;
            this.bUploadDoc.Click += new System.EventHandler(this.bUploadDoc_Click);
            this.bUploadDoc.Paint += new System.Windows.Forms.PaintEventHandler(this.bUploadDoc_Paint);
            // 
            // bUploadText
            // 
            this.bUploadText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bUploadText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bUploadText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUploadText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bUploadText.Location = new System.Drawing.Point(42, 99);
            this.bUploadText.Name = "bUploadText";
            this.bUploadText.Size = new System.Drawing.Size(264, 46);
            this.bUploadText.TabIndex = 3;
            this.bUploadText.Text = "Wgraj tekst";
            this.ttUploadText.SetToolTip(this.bUploadText, "Wgraj tekst (w nowym oknie wklej tekst, a następnie kliknij przycisk \"Wgraj dane\"" +
        ")");
            this.bUploadText.UseVisualStyleBackColor = false;
            this.bUploadText.Click += new System.EventHandler(this.bUploadText_Click);
            this.bUploadText.Paint += new System.Windows.Forms.PaintEventHandler(this.bUploadText_Paint);
            // 
            // lUploadFileInfo
            // 
            this.lUploadFileInfo.AutoSize = true;
            this.lUploadFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUploadFileInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lUploadFileInfo.Location = new System.Drawing.Point(0, 0);
            this.lUploadFileInfo.Name = "lUploadFileInfo";
            this.lUploadFileInfo.Size = new System.Drawing.Size(141, 25);
            this.lUploadFileInfo.TabIndex = 2;
            this.lUploadFileInfo.Text = "Wybierz plik ";
            this.lUploadFileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bUploadPdf
            // 
            this.bUploadPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bUploadPdf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bUploadPdf.Enabled = false;
            this.bUploadPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUploadPdf.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bUploadPdf.Location = new System.Drawing.Point(42, 151);
            this.bUploadPdf.Name = "bUploadPdf";
            this.bUploadPdf.Size = new System.Drawing.Size(264, 48);
            this.bUploadPdf.TabIndex = 0;
            this.bUploadPdf.Text = "Wgraj plik .pdf";
            this.ttDocLimitInfo.SetToolTip(this.bUploadPdf, "Plik maks. 1 str.");
            this.bUploadPdf.UseVisualStyleBackColor = false;
            this.bUploadPdf.Click += new System.EventHandler(this.bUploadPdf_Click);
            this.bUploadPdf.Paint += new System.Windows.Forms.PaintEventHandler(this.bUploadPdf_Paint);
            // 
            // bDownloadFile
            // 
            this.bDownloadFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bDownloadFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDownloadFile.Enabled = false;
            this.bDownloadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDownloadFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bDownloadFile.Location = new System.Drawing.Point(0, 0);
            this.bDownloadFile.Name = "bDownloadFile";
            this.bDownloadFile.Size = new System.Drawing.Size(349, 46);
            this.bDownloadFile.TabIndex = 1;
            this.bDownloadFile.Text = "Pobierz plik z danymi (.csv)";
            this.bDownloadFile.UseVisualStyleBackColor = false;
            this.bDownloadFile.Click += new System.EventHandler(this.bDownloadFile_Click);
            this.bDownloadFile.Paint += new System.Windows.Forms.PaintEventHandler(this.bDownloadFile_Paint);
            // 
            // ttDocLimitInfo
            // 
            this.ttDocLimitInfo.IsBalloon = true;
            // 
            // ttUploadText
            // 
            this.ttUploadText.IsBalloon = true;
            // 
            // pMainDownload
            // 
            this.pMainDownload.Controls.Add(this.bDownloadFile);
            this.pMainDownload.Location = new System.Drawing.Point(221, 341);
            this.pMainDownload.Name = "pMainDownload";
            this.pMainDownload.Size = new System.Drawing.Size(349, 100);
            this.pMainDownload.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pMainDownload);
            this.Controls.Add(this.pMainUload);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.pMainUload.ResumeLayout(false);
            this.pMainUload.PerformLayout();
            this.pMainDownload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMainUload;
        private System.Windows.Forms.Button bDownloadFile;
        private System.Windows.Forms.Button bUploadPdf;
        private System.Windows.Forms.Label lUploadFileInfo;
        private System.Windows.Forms.ToolTip ttDocLimitInfo;
        private System.Windows.Forms.Button bUploadText;
        private System.Windows.Forms.ToolTip ttUploadText;
        private System.Windows.Forms.Panel pMainDownload;
        private System.Windows.Forms.ToolTip ttDownloadText;
        private System.Windows.Forms.Button bUploadDoc;
    }
}

