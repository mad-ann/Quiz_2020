namespace Quiz_2020
{
    partial class Form_Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Profil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kezdolapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mikrobiologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immunologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biokemiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novenyrendszertanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kezdolapToolStripMenuItem,
            this.kategoriakToolStripMenuItem,
            this.kilepesToolStripMenuItem,
            this.sugoToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // kezdolapToolStripMenuItem
            // 
            this.kezdolapToolStripMenuItem.Name = "kezdolapToolStripMenuItem";
            resources.ApplyResources(this.kezdolapToolStripMenuItem, "kezdolapToolStripMenuItem");
            this.kezdolapToolStripMenuItem.Click += new System.EventHandler(this.kezdolapToolStripMenuItem_Click);
            // 
            // kategoriakToolStripMenuItem
            // 
            this.kategoriakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mikrobiologiaToolStripMenuItem,
            this.immunologiaToolStripMenuItem,
            this.biokemiaToolStripMenuItem,
            this.novenyrendszertanToolStripMenuItem});
            this.kategoriakToolStripMenuItem.Name = "kategoriakToolStripMenuItem";
            resources.ApplyResources(this.kategoriakToolStripMenuItem, "kategoriakToolStripMenuItem");
            this.kategoriakToolStripMenuItem.Click += new System.EventHandler(this.kategoriakToolStripMenuItem_Click);
            // 
            // mikrobiologiaToolStripMenuItem
            // 
            this.mikrobiologiaToolStripMenuItem.Name = "mikrobiologiaToolStripMenuItem";
            resources.ApplyResources(this.mikrobiologiaToolStripMenuItem, "mikrobiologiaToolStripMenuItem");
            this.mikrobiologiaToolStripMenuItem.Click += new System.EventHandler(this.mikrobiologiaToolStripMenuItem_Click);
            // 
            // immunologiaToolStripMenuItem
            // 
            this.immunologiaToolStripMenuItem.Name = "immunologiaToolStripMenuItem";
            resources.ApplyResources(this.immunologiaToolStripMenuItem, "immunologiaToolStripMenuItem");
            this.immunologiaToolStripMenuItem.Click += new System.EventHandler(this.immunologiaToolStripMenuItem_Click);
            // 
            // biokemiaToolStripMenuItem
            // 
            this.biokemiaToolStripMenuItem.Name = "biokemiaToolStripMenuItem";
            resources.ApplyResources(this.biokemiaToolStripMenuItem, "biokemiaToolStripMenuItem");
            this.biokemiaToolStripMenuItem.Click += new System.EventHandler(this.biokemiaToolStripMenuItem_Click);
            // 
            // novenyrendszertanToolStripMenuItem
            // 
            this.novenyrendszertanToolStripMenuItem.Name = "novenyrendszertanToolStripMenuItem";
            resources.ApplyResources(this.novenyrendszertanToolStripMenuItem, "novenyrendszertanToolStripMenuItem");
            this.novenyrendszertanToolStripMenuItem.Click += new System.EventHandler(this.novenyrendszertanToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            resources.ApplyResources(this.kilepesToolStripMenuItem, "kilepesToolStripMenuItem");
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // sugoToolStripMenuItem
            // 
            this.sugoToolStripMenuItem.Name = "sugoToolStripMenuItem";
            resources.ApplyResources(this.sugoToolStripMenuItem, "sugoToolStripMenuItem");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // Form_Profil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Profil";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form_Profil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kezdolapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mikrobiologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem immunologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biokemiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novenyrendszertanToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}