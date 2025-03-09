namespace ChameleonCK
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReadFromGame = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.checkSwimming = new System.Windows.Forms.CheckBox();
            this.checkHideStage = new System.Windows.Forms.CheckBox();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ChromaDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.Tooltip.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // optionsToolStripMenuItem
            // 
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolReadFromGame});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            // 
            // toolReadFromGame
            // 
            resources.ApplyResources(this.toolReadFromGame, "toolReadFromGame");
            this.toolReadFromGame.AutoToolTip = true;
            this.toolReadFromGame.Name = "toolReadFromGame";
            this.toolReadFromGame.Click += new System.EventHandler(this.toolReadFromGame_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnPickColor
            // 
            resources.ApplyResources(this.btnPickColor, "btnPickColor");
            this.btnPickColor.Name = "btnPickColor";
            this.Tooltip.SetToolTip(this.btnPickColor, resources.GetString("btnPickColor.ToolTip"));
            this.btnPickColor.UseVisualStyleBackColor = false;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // checkSwimming
            // 
            resources.ApplyResources(this.checkSwimming, "checkSwimming");
            this.checkSwimming.Name = "checkSwimming";
            this.Tooltip.SetToolTip(this.checkSwimming, resources.GetString("checkSwimming.ToolTip"));
            this.checkSwimming.UseVisualStyleBackColor = true;
            this.checkSwimming.CheckedChanged += new System.EventHandler(this.checkSwimming_CheckedChanged);
            // 
            // checkHideStage
            // 
            resources.ApplyResources(this.checkHideStage, "checkHideStage");
            this.checkHideStage.Name = "checkHideStage";
            this.Tooltip.SetToolTip(this.checkHideStage, resources.GetString("checkHideStage.ToolTip"));
            this.checkHideStage.UseVisualStyleBackColor = true;
            this.checkHideStage.CheckedChanged += new System.EventHandler(this.checkHideStage_CheckedChanged);
            // 
            // Tooltip
            // 
            this.Tooltip.AutoPopDelay = 50000;
            this.Tooltip.InitialDelay = 500;
            this.Tooltip.ReshowDelay = 100;
            // 
            // ChromaDialog
            // 
            this.ChromaDialog.AnyColor = true;
            this.ChromaDialog.FullOpen = true;
            this.ChromaDialog.SolidColorOnly = true;
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkHideStage);
            this.Controls.Add(this.checkSwimming);
            this.Controls.Add(this.btnPickColor);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Tooltip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.CheckBox checkSwimming;
        private System.Windows.Forms.CheckBox checkHideStage;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.ColorDialog ChromaDialog;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolReadFromGame;
    }
}

