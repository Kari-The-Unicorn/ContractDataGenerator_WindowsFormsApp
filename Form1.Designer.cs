
namespace ContractDataGenerator_WindowsFormsApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lUploadFileInfo = new System.Windows.Forms.Label();
            this.bDownloadFile = new System.Windows.Forms.Button();
            this.bUploadFile = new System.Windows.Forms.Button();
            this.ttDocLimitInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lUploadFileInfo);
            this.panel1.Controls.Add(this.bDownloadFile);
            this.panel1.Controls.Add(this.bUploadFile);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 288);
            this.panel1.TabIndex = 0;
            // 
            // lUploadFileInfo
            // 
            this.lUploadFileInfo.AutoSize = true;
            this.lUploadFileInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lUploadFileInfo.Location = new System.Drawing.Point(28, 16);
            this.lUploadFileInfo.Name = "lUploadFileInfo";
            this.lUploadFileInfo.Size = new System.Drawing.Size(197, 25);
            this.lUploadFileInfo.TabIndex = 2;
            this.lUploadFileInfo.Text = "Wybierz plik (.pdf)";
            this.lUploadFileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bDownloadFile
            // 
            this.bDownloadFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bDownloadFile.Enabled = false;
            this.bDownloadFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bDownloadFile.Location = new System.Drawing.Point(23, 189);
            this.bDownloadFile.Name = "bDownloadFile";
            this.bDownloadFile.Size = new System.Drawing.Size(260, 38);
            this.bDownloadFile.TabIndex = 1;
            this.bDownloadFile.Text = "Pobierz plik z danymi";
            this.bDownloadFile.UseVisualStyleBackColor = false;
            this.bDownloadFile.Click += new System.EventHandler(this.bDownloadFile_Click);
            // 
            // bUploadFile
            // 
            this.bUploadFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bUploadFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bUploadFile.Location = new System.Drawing.Point(23, 60);
            this.bUploadFile.Name = "bUploadFile";
            this.bUploadFile.Size = new System.Drawing.Size(175, 38);
            this.bUploadFile.TabIndex = 0;
            this.bUploadFile.Text = "Wgraj plik";
            this.ttDocLimitInfo.SetToolTip(this.bUploadFile, "Plik maks. 1 str.");
            this.bUploadFile.UseVisualStyleBackColor = false;
            this.bUploadFile.Click += new System.EventHandler(this.bUploadFile_Click);
            // 
            // ttDocLimitInfo
            // 
            this.ttDocLimitInfo.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bDownloadFile;
        private System.Windows.Forms.Button bUploadFile;
        private System.Windows.Forms.Label lUploadFileInfo;
        private System.Windows.Forms.ToolTip ttDocLimitInfo;
    }
}

