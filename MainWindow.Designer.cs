
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
            this.ttDocLimitInfo = new System.Windows.Forms.ToolTip(this.components);
            this.ttUploadText = new System.Windows.Forms.ToolTip(this.components);
            this.lUploadFileInfo = new System.Windows.Forms.Label();
            this.pMainUload.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMainUload
            // 
            this.pMainUload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pMainUload.Controls.Add(this.lUploadFileInfo);
            this.pMainUload.Controls.Add(this.bUploadDoc);
            this.pMainUload.Controls.Add(this.bUploadText);
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
            this.bUploadDoc.Location = new System.Drawing.Point(42, 82);
            this.bUploadDoc.Name = "bUploadDoc";
            this.bUploadDoc.Size = new System.Drawing.Size(260, 42);
            this.bUploadDoc.TabIndex = 4;
            this.bUploadDoc.Text = "Wgraj plik .docx";
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
            this.bUploadText.Location = new System.Drawing.Point(42, 146);
            this.bUploadText.Name = "bUploadText";
            this.bUploadText.Size = new System.Drawing.Size(260, 42);
            this.bUploadText.TabIndex = 3;
            this.bUploadText.Text = "Wgraj tekst";
            this.ttUploadText.SetToolTip(this.bUploadText, "Wgraj tekst (w nowym oknie wklej tekst Ctrl + V, a następnie kliknij przycisk \"Wg" +
        "raj dane\")");
            this.bUploadText.UseVisualStyleBackColor = false;
            this.bUploadText.Click += new System.EventHandler(this.bUploadText_Click);
            this.bUploadText.Paint += new System.Windows.Forms.PaintEventHandler(this.bUploadText_Paint);
            // 
            // ttDocLimitInfo
            // 
            this.ttDocLimitInfo.IsBalloon = true;
            // 
            // ttUploadText
            // 
            this.ttUploadText.IsBalloon = true;
            // 
            // lUploadFileInfo
            // 
            this.lUploadFileInfo.AutoSize = true;
            this.lUploadFileInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lUploadFileInfo.Location = new System.Drawing.Point(2, 0);
            this.lUploadFileInfo.Name = "lUploadFileInfo";
            this.lUploadFileInfo.Size = new System.Drawing.Size(291, 25);
            this.lUploadFileInfo.TabIndex = 5;
            this.lUploadFileInfo.Text = "Wybierz plik lub wgraj tekst";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 492);
            this.Controls.Add(this.pMainUload);
            this.Name = "MainWindow";
            this.Text = "Ekstraktowanie umowy";
            this.pMainUload.ResumeLayout(false);
            this.pMainUload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMainUload;
        private System.Windows.Forms.ToolTip ttDocLimitInfo;
        private System.Windows.Forms.Button bUploadText;
        private System.Windows.Forms.ToolTip ttUploadText;
        private System.Windows.Forms.Button bUploadDoc;
        private System.Windows.Forms.Label lUploadFileInfo;
    }
}

