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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kezdolapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mikrobiologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immunologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biokemiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novenyrendszertanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kezdolapToolStripMenuItem
            // 
            this.kezdolapToolStripMenuItem.Name = "kezdolapToolStripMenuItem";
            this.kezdolapToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.kezdolapToolStripMenuItem.Text = "Kezdőlap";
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
            this.kategoriakToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.kategoriakToolStripMenuItem.Text = "Kategóriák";
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // sugoToolStripMenuItem
            // 
            this.sugoToolStripMenuItem.Name = "sugoToolStripMenuItem";
            this.sugoToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.sugoToolStripMenuItem.Text = "Súgó";
            // 
            // mikrobiologiaToolStripMenuItem
            // 
            this.mikrobiologiaToolStripMenuItem.Name = "mikrobiologiaToolStripMenuItem";
            this.mikrobiologiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mikrobiologiaToolStripMenuItem.Text = "Mikrobiológia";
            this.mikrobiologiaToolStripMenuItem.Click += new System.EventHandler(this.mikrobiologiaToolStripMenuItem_Click);
            // 
            // immunologiaToolStripMenuItem
            // 
            this.immunologiaToolStripMenuItem.Name = "immunologiaToolStripMenuItem";
            this.immunologiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.immunologiaToolStripMenuItem.Text = "Immunológia";
            this.immunologiaToolStripMenuItem.Click += new System.EventHandler(this.immunologiaToolStripMenuItem_Click);
            // 
            // biokemiaToolStripMenuItem
            // 
            this.biokemiaToolStripMenuItem.Name = "biokemiaToolStripMenuItem";
            this.biokemiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.biokemiaToolStripMenuItem.Text = "Biokémia";
            this.biokemiaToolStripMenuItem.Click += new System.EventHandler(this.biokemiaToolStripMenuItem_Click);
            // 
            // novenyrendszertanToolStripMenuItem
            // 
            this.novenyrendszertanToolStripMenuItem.Name = "novenyrendszertanToolStripMenuItem";
            this.novenyrendszertanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novenyrendszertanToolStripMenuItem.Text = "Növényrendszertan";
            this.novenyrendszertanToolStripMenuItem.Click += new System.EventHandler(this.novenyrendszertanToolStripMenuItem_Click);
            // 
            // Form_Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Profil";
            this.Text = "Form_Profil";
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
    }
}