namespace YoutubeDownloader.Controls
{
    partial class LinkDownloadControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.gbxLinkBox = new System.Windows.Forms.GroupBox();
            this.gbxLinkBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLink
            // 
            this.txtLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLink.Location = new System.Drawing.Point(6, 20);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(411, 21);
            this.txtLink.TabIndex = 3;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Location = new System.Drawing.Point(423, 18);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(141, 23);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "다운로드(&D)";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // gbxLinkBox
            // 
            this.gbxLinkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLinkBox.Controls.Add(this.btnDownload);
            this.gbxLinkBox.Controls.Add(this.txtLink);
            this.gbxLinkBox.Location = new System.Drawing.Point(3, 3);
            this.gbxLinkBox.Name = "gbxLinkBox";
            this.gbxLinkBox.Size = new System.Drawing.Size(570, 43);
            this.gbxLinkBox.TabIndex = 4;
            this.gbxLinkBox.TabStop = false;
            this.gbxLinkBox.Text = "다운로드할 링크 입력";
            // 
            // LinkDownloadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxLinkBox);
            this.Name = "LinkDownloadControl";
            this.Size = new System.Drawing.Size(576, 49);
            this.gbxLinkBox.ResumeLayout(false);
            this.gbxLinkBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.GroupBox gbxLinkBox;
    }
}
