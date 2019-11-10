namespace WebServiceClient
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
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btn_browse = new System.Windows.Forms.Button();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_result
            // 
            this.rtb_result.Location = new System.Drawing.Point(36, 32);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.ReadOnly = true;
            this.rtb_result.Size = new System.Drawing.Size(715, 217);
            this.rtb_result.TabIndex = 0;
            this.rtb_result.Text = "";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Title = "Browse file";
            // 
            // btn_browse
            // 
            this.btn_browse.CausesValidation = false;
            this.btn_browse.Location = new System.Drawing.Point(36, 272);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse file";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(143, 275);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(539, 20);
            this.textFileName.TabIndex = 3;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(700, 275);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 4;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.rtb_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_result;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Button btn_upload;
    }
}

