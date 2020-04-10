namespace Quiz_2020
{
    partial class Form_Reg
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
            this.groupBox_reg = new System.Windows.Forms.GroupBox();
            this.textBox_jelszo = new System.Windows.Forms.TextBox();
            this.label_jelszo = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.dateTimePicker_szulido = new System.Windows.Forms.DateTimePicker();
            this.label_szulido = new System.Windows.Forms.Label();
            this.textBox_fnev = new System.Windows.Forms.TextBox();
            this.label_fnev = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.button_reg = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kezdőlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategóriákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_reg.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_reg
            // 
            this.groupBox_reg.Controls.Add(this.textBox_jelszo);
            this.groupBox_reg.Controls.Add(this.label_jelszo);
            this.groupBox_reg.Controls.Add(this.textBox_email);
            this.groupBox_reg.Controls.Add(this.label_email);
            this.groupBox_reg.Controls.Add(this.dateTimePicker_szulido);
            this.groupBox_reg.Controls.Add(this.label_szulido);
            this.groupBox_reg.Controls.Add(this.textBox_fnev);
            this.groupBox_reg.Controls.Add(this.label_fnev);
            this.groupBox_reg.Controls.Add(this.textBox_nev);
            this.groupBox_reg.Controls.Add(this.label_nev);
            this.groupBox_reg.Location = new System.Drawing.Point(67, 31);
            this.groupBox_reg.Name = "groupBox_reg";
            this.groupBox_reg.Size = new System.Drawing.Size(384, 209);
            this.groupBox_reg.TabIndex = 0;
            this.groupBox_reg.TabStop = false;
            this.groupBox_reg.Text = "Regisztráció";
            // 
            // textBox_jelszo
            // 
            this.textBox_jelszo.Location = new System.Drawing.Point(106, 171);
            this.textBox_jelszo.Name = "textBox_jelszo";
            this.textBox_jelszo.Size = new System.Drawing.Size(207, 20);
            this.textBox_jelszo.TabIndex = 9;
            // 
            // label_jelszo
            // 
            this.label_jelszo.AutoSize = true;
            this.label_jelszo.Location = new System.Drawing.Point(61, 174);
            this.label_jelszo.Name = "label_jelszo";
            this.label_jelszo.Size = new System.Drawing.Size(39, 13);
            this.label_jelszo.TabIndex = 8;
            this.label_jelszo.Text = "Jelszó:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(106, 134);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(207, 20);
            this.textBox_email.TabIndex = 7;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(41, 137);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(59, 13);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "E-mail cím:";
            // 
            // dateTimePicker_szulido
            // 
            this.dateTimePicker_szulido.Location = new System.Drawing.Point(106, 98);
            this.dateTimePicker_szulido.Name = "dateTimePicker_szulido";
            this.dateTimePicker_szulido.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker_szulido.TabIndex = 5;
            // 
            // label_szulido
            // 
            this.label_szulido.AutoSize = true;
            this.label_szulido.Location = new System.Drawing.Point(31, 104);
            this.label_szulido.Name = "label_szulido";
            this.label_szulido.Size = new System.Drawing.Size(69, 13);
            this.label_szulido.TabIndex = 4;
            this.label_szulido.Text = "Születési idő:";
            // 
            // textBox_fnev
            // 
            this.textBox_fnev.Location = new System.Drawing.Point(106, 67);
            this.textBox_fnev.Name = "textBox_fnev";
            this.textBox_fnev.Size = new System.Drawing.Size(207, 20);
            this.textBox_fnev.TabIndex = 3;
            // 
            // label_fnev
            // 
            this.label_fnev.AutoSize = true;
            this.label_fnev.Location = new System.Drawing.Point(16, 67);
            this.label_fnev.Name = "label_fnev";
            this.label_fnev.Size = new System.Drawing.Size(84, 13);
            this.label_fnev.TabIndex = 2;
            this.label_fnev.Text = "Felhasználónév:";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(106, 31);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(207, 20);
            this.textBox_nev.TabIndex = 1;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(70, 34);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(30, 13);
            this.label_nev.TabIndex = 0;
            this.label_nev.Text = "Név:";
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(188, 246);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(142, 27);
            this.button_reg.TabIndex = 1;
            this.button_reg.Text = "Regisztrálok";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kezdőlapToolStripMenuItem,
            this.kategóriákToolStripMenuItem,
            this.súgóToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kezdőlapToolStripMenuItem
            // 
            this.kezdőlapToolStripMenuItem.Name = "kezdőlapToolStripMenuItem";
            this.kezdőlapToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.kezdőlapToolStripMenuItem.Text = "Kezdőlap";
            this.kezdőlapToolStripMenuItem.Click += new System.EventHandler(this.kezdőlapToolStripMenuItem_Click);
            // 
            // kategóriákToolStripMenuItem
            // 
            this.kategóriákToolStripMenuItem.Name = "kategóriákToolStripMenuItem";
            this.kategóriákToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.kategóriákToolStripMenuItem.Text = "Kategóriák";
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.súgóToolStripMenuItem.Text = "Súgó";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // Form_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.groupBox_reg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Reg";
            this.Text = "Form_Reg";
            this.groupBox_reg.ResumeLayout(false);
            this.groupBox_reg.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_reg;
        private System.Windows.Forms.Label label_fnev;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.TextBox textBox_jelszo;
        private System.Windows.Forms.Label label_jelszo;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.DateTimePicker dateTimePicker_szulido;
        private System.Windows.Forms.Label label_szulido;
        private System.Windows.Forms.TextBox textBox_fnev;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kezdőlapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategóriákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}