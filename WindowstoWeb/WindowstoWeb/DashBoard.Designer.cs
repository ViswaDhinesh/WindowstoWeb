namespace WindowstoWeb
{
    partial class DashBoard
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
            this.btnSiginIn = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnDynamicBrowser = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrowser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiginIn
            // 
            this.btnSiginIn.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiginIn.Location = new System.Drawing.Point(121, 118);
            this.btnSiginIn.Name = "btnSiginIn";
            this.btnSiginIn.Size = new System.Drawing.Size(163, 38);
            this.btnSiginIn.TabIndex = 0;
            this.btnSiginIn.Text = "Sign In";
            this.btnSiginIn.UseVisualStyleBackColor = true;
            this.btnSiginIn.Click += new System.EventHandler(this.btnSiginIn_Click);
            // 
            // btnGmail
            // 
            this.btnGmail.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGmail.Location = new System.Drawing.Point(507, 118);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(163, 38);
            this.btnGmail.TabIndex = 1;
            this.btnGmail.Text = "Gmail";
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Location = new System.Drawing.Point(121, 291);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(163, 38);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "Browse";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnDynamicBrowser
            // 
            this.btnDynamicBrowser.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDynamicBrowser.Location = new System.Drawing.Point(507, 280);
            this.btnDynamicBrowser.Name = "btnDynamicBrowser";
            this.btnDynamicBrowser.Size = new System.Drawing.Size(163, 60);
            this.btnDynamicBrowser.TabIndex = 3;
            this.btnDynamicBrowser.Text = "Dynamic Browser";
            this.btnDynamicBrowser.UseVisualStyleBackColor = true;
            this.btnDynamicBrowser.Click += new System.EventHandler(this.btnDynamicBrowser_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(121, 235);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(213, 22);
            this.txtPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL:";
            // 
            // cmbBrowser
            // 
            this.cmbBrowser.FormattingEnabled = true;
            this.cmbBrowser.Items.AddRange(new object[] {
            "Chrome",
            "Mozilla",
            "IE",
            "MicrosoftEdge"});
            this.cmbBrowser.Location = new System.Drawing.Point(507, 233);
            this.cmbBrowser.Name = "cmbBrowser";
            this.cmbBrowser.Size = new System.Drawing.Size(121, 24);
            this.cmbBrowser.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Browser:";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnDynamicBrowser);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnGmail);
            this.Controls.Add(this.btnSiginIn);
            this.KeyPreview = true;
            this.Name = "DashBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DashBoard_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiginIn;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnDynamicBrowser;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrowser;
        private System.Windows.Forms.Label label2;
    }
}

