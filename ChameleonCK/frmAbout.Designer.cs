namespace ChameleonCK
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lbAddonName = new System.Windows.Forms.Label();
            this.lbVer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbLicense = new System.Windows.Forms.Label();
            this.lbVerNum = new System.Windows.Forms.Label();
            this.cckLogo = new System.Windows.Forms.PictureBox();
            this.htmlLabel1 = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cckLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddonName
            // 
            resources.ApplyResources(this.lbAddonName, "lbAddonName");
            this.lbAddonName.Name = "lbAddonName";
            // 
            // lbVer
            // 
            resources.ApplyResources(this.lbVer, "lbVer");
            this.lbVer.Name = "lbVer";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            // 
            // lbLicense
            // 
            resources.ApplyResources(this.lbLicense, "lbLicense");
            this.lbLicense.Name = "lbLicense";
            // 
            // lbVerNum
            // 
            resources.ApplyResources(this.lbVerNum, "lbVerNum");
            this.lbVerNum.Name = "lbVerNum";
            // 
            // cckLogo
            // 
            resources.ApplyResources(this.cckLogo, "cckLogo");
            this.cckLogo.Image = global::ChameleonCK.Properties.Resources.cck_logo;
            this.cckLogo.Name = "cckLogo";
            this.cckLogo.TabStop = false;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.htmlLabel1.BaseStylesheet = null;
            resources.ApplyResources(this.htmlLabel1, "htmlLabel1");
            this.htmlLabel1.Name = "htmlLabel1";
            // 
            // frmAbout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.lbVerNum);
            this.Controls.Add(this.lbLicense);
            this.Controls.Add(this.cckLogo);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.lbAddonName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            ((System.ComponentModel.ISupportInitialize)(this.cckLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbAddonName;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox cckLogo;
        private System.Windows.Forms.Label lbLicense;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel htmlCredits;
        private System.Windows.Forms.Label lbVerNum;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel htmlLabel1;
    }
}