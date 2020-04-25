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
            this.textBox_fnev = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_szulido = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_pontszám = new System.Windows.Forms.Label();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
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
            this.kategoriakToolStripMenuItem.Click += new System.EventHandler(this.kategoriakToolStripMenuItem_Click);
            // 
            // mikrobiologiaToolStripMenuItem
            // 
            this.mikrobiologiaToolStripMenuItem.Name = "mikrobiologiaToolStripMenuItem";
            this.mikrobiologiaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mikrobiologiaToolStripMenuItem.Text = "Mikrobiológia";
            this.mikrobiologiaToolStripMenuItem.Click += new System.EventHandler(this.mikrobiologiaToolStripMenuItem_Click);
            // 
            // immunologiaToolStripMenuItem
            // 
            this.immunologiaToolStripMenuItem.Name = "immunologiaToolStripMenuItem";
            this.immunologiaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.immunologiaToolStripMenuItem.Text = "Immunológia";
            this.immunologiaToolStripMenuItem.Click += new System.EventHandler(this.immunologiaToolStripMenuItem_Click);
            // 
            // biokemiaToolStripMenuItem
            // 
            this.biokemiaToolStripMenuItem.Name = "biokemiaToolStripMenuItem";
            this.biokemiaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.biokemiaToolStripMenuItem.Text = "Biokémia";
            this.biokemiaToolStripMenuItem.Click += new System.EventHandler(this.biokemiaToolStripMenuItem_Click);
            // 
            // novenyrendszertanToolStripMenuItem
            // 
            this.novenyrendszertanToolStripMenuItem.Name = "novenyrendszertanToolStripMenuItem";
            this.novenyrendszertanToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.novenyrendszertanToolStripMenuItem.Text = "Növényrendszertan";
            this.novenyrendszertanToolStripMenuItem.Click += new System.EventHandler(this.novenyrendszertanToolStripMenuItem_Click);
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
            // textBox_fnev
            // 
            this.textBox_fnev.Location = new System.Drawing.Point(52, 57);
            this.textBox_fnev.Name = "textBox_fnev";
            this.textBox_fnev.Size = new System.Drawing.Size(181, 22);
            this.textBox_fnev.TabIndex = 1;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(52, 120);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(138, 22);
            this.textBox_nev.TabIndex = 2;
            // 
            // textBox_szulido
            // 
            this.textBox_szulido.Location = new System.Drawing.Point(52, 148);
            this.textBox_szulido.Name = "textBox_szulido";
            this.textBox_szulido.Size = new System.Drawing.Size(138, 22);
            this.textBox_szulido.TabIndex = 3;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(53, 176);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(137, 22);
            this.textBox_email.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 61);
            this.textBox1.TabIndex = 5;
            // 
            // label_pontszám
            // 
            this.label_pontszám.AutoSize = true;
            this.label_pontszám.Location = new System.Drawing.Point(337, 119);
            this.label_pontszám.Name = "label_pontszám";
            this.label_pontszám.Size = new System.Drawing.Size(126, 15);
            this.label_pontszám.TabIndex = 6;
            this.label_pontszám.Text = "Összegyűjtott pontok:";
            // 
            // Form_Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(574, 431);
            this.Controls.Add(this.label_pontszám);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_szulido);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.textBox_fnev);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Profil";
            this.Text = "Profil";
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
        private System.Windows.Forms.TextBox textBox_fnev;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_szulido;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_pontszám;
    }
}