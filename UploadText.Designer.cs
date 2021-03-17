
namespace ContractDataGenerator_WindowsFormsApp
{
    partial class UploadText
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
            this.rtbUploadText = new System.Windows.Forms.RichTextBox();
            this.bUploadFile = new System.Windows.Forms.Button();
            this.ttUploadDataClick = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // rtbUploadText
            // 
            this.rtbUploadText.Location = new System.Drawing.Point(12, 12);
            this.rtbUploadText.Name = "rtbUploadText";
            this.rtbUploadText.Size = new System.Drawing.Size(808, 448);
            this.rtbUploadText.TabIndex = 0;
            this.rtbUploadText.Text = "";
            this.ttUploadDataClick.SetToolTip(this.rtbUploadText, "Wklej tekst (Ctrl +V), a następnie kliknij przycisk\"Wgraj dane\"");
            // 
            // bUploadFile
            // 
            this.bUploadFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bUploadFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bUploadFile.Location = new System.Drawing.Point(302, 482);
            this.bUploadFile.Name = "bUploadFile";
            this.bUploadFile.Size = new System.Drawing.Size(175, 38);
            this.bUploadFile.TabIndex = 1;
            this.bUploadFile.Text = "Wgraj dane";
            this.bUploadFile.UseVisualStyleBackColor = false;
            this.bUploadFile.Click += new System.EventHandler(this.bUploadFile_Click);
            // 
            // ttUploadDataClick
            // 
            this.ttUploadDataClick.IsBalloon = true;
            // 
            // UploadText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 541);
            this.Controls.Add(this.bUploadFile);
            this.Controls.Add(this.rtbUploadText);
            this.Name = "UploadText";
            this.Text = "UploadText";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttUploadDataClick;
        private System.Windows.Forms.Button bUploadFile;
        public System.Windows.Forms.RichTextBox rtbUploadText;
    }
}