namespace DaishinPlusSampleForCSharp.Common
{
    partial class FormWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeb));
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(671, 470);
            this.WebBrowser1.TabIndex = 2;
            // 
            // FormWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 470);
            this.Controls.Add(this.WebBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWeb";
            this.Text = "FormWeb";
            this.Load += new System.EventHandler(this.FormWeb_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormWeb_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.WebBrowser WebBrowser1;
    }
}