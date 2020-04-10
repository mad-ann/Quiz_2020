namespace Quiz_2020
{
    partial class Form_Nyito
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
            this.kezdőlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategóriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mikrobiológiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immunológiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biokémiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_kilepes = new System.Windows.Forms.Button();
            this.button_belepes = new System.Windows.Forms.Button();
            this.button_regisztracio = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kezdőlapToolStripMenuItem,
            this.kategóriaToolStripMenuItem,
            this.súgóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kezdőlapToolStripMenuItem
            // 
            this.kezdőlapToolStripMenuItem.Name = "kezdőlapToolStripMenuItem";
            this.kezdőlapToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.kezdőlapToolStripMenuItem.Text = "Kezdőlap";
            this.kezdőlapToolStripMenuItem.Click += new System.EventHandler(this.kezdőlapToolStripMenuItem_Click);
            // 
            // kategóriaToolStripMenuItem
            // 
            this.kategóriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mikrobiológiaToolStripMenuItem,
            this.immunológiaToolStripMenuItem,
            this.biokémiaToolStripMenuItem});
            this.kategóriaToolStripMenuItem.Name = "kategóriaToolStripMenuItem";
            this.kategóriaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.kategóriaToolStripMenuItem.Text = "Kategória";
            // 
            // mikrobiológiaToolStripMenuItem
            // 
            this.mikrobiológiaToolStripMenuItem.Name = "mikrobiológiaToolStripMenuItem";
            this.mikrobiológiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mikrobiológiaToolStripMenuItem.Text = "Mikrobiológia";
            this.mikrobiológiaToolStripMenuItem.Click += new System.EventHandler(this.mikrobiológiaToolStripMenuItem_Click);
            // 
            // immunológiaToolStripMenuItem
            // 
            this.immunológiaToolStripMenuItem.Name = "immunológiaToolStripMenuItem";
            this.immunológiaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.immunológiaToolStripMenuItem.Text = "Immunológia";
            // 
            // biokémiaToolStripMenuItem
            // 
            this.biokémiaToolStripMenuItem.Name = "biokémiaToolStripMenuItem";
            this.biokémiaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.biokémiaToolStripMenuItem.Text = "Biokémia";
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.súgóToolStripMenuItem.Text = "Súgó";
            // 
            // button_kilepes
            // 
            this.button_kilepes.Location = new System.Drawing.Point(12, 145);
            this.button_kilepes.Name = "button_kilepes";
            this.button_kilepes.Size = new System.Drawing.Size(132, 30);
            this.button_kilepes.TabIndex = 1;
            this.button_kilepes.Text = "Kilépés";
            this.button_kilepes.UseVisualStyleBackColor = true;
            this.button_kilepes.Click += new System.EventHandler(this.button_kilepes_Click);
            // 
            // button_belepes
            // 
            this.button_belepes.Location = new System.Drawing.Point(12, 47);
            this.button_belepes.Name = "button_belepes";
            this.button_belepes.Size = new System.Drawing.Size(132, 29);
            this.button_belepes.TabIndex = 2;
            this.button_belepes.Text = "Belépés";
            this.button_belepes.UseVisualStyleBackColor = true;
            this.button_belepes.Click += new System.EventHandler(this.button_belepes_Click);
            // 
            // button_regisztracio
            // 
            this.button_regisztracio.Location = new System.Drawing.Point(12, 95);
            this.button_regisztracio.Name = "button_regisztracio";
            this.button_regisztracio.Size = new System.Drawing.Size(132, 31);
            this.button_regisztracio.TabIndex = 3;
            this.button_regisztracio.Text = "Regisztráció";
            this.button_regisztracio.UseVisualStyleBackColor = true;
            this.button_regisztracio.Click += new System.EventHandler(this.button_regisztracio_Click);
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_regisztracio);
            this.Controls.Add(this.button_belepes);
            this.Controls.Add(this.button_kilepes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Nyito";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategóriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kezdőlapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mikrobiológiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem immunológiaToolStripMenuItem;
        private System.Windows.Forms.Button button_kilepes;
        private System.Windows.Forms.ToolStripMenuItem biokémiaToolStripMenuItem;
        private System.Windows.Forms.Button button_belepes;
        private System.Windows.Forms.Button button_regisztracio;
    }
}

