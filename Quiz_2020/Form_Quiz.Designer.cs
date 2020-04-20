namespace Quiz_2020
{
    partial class Form_Quiz
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
            this.components = new System.ComponentModel.Container();
            this.label_kategoria = new System.Windows.Forms.Label();
            this.textBox_kerdes = new System.Windows.Forms.TextBox();
            this.radioButton_valasz_A = new System.Windows.Forms.RadioButton();
            this.radioButton_valasz_B = new System.Windows.Forms.RadioButton();
            this.radioButton_valasz_C = new System.Windows.Forms.RadioButton();
            this.textBox_valasz_B = new System.Windows.Forms.TextBox();
            this.textBox_valasz_C = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_tovabb = new System.Windows.Forms.Button();
            this.button_befejezes = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_valasz_A = new System.Windows.Forms.TextBox();
            this.label_kat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_kategoria
            // 
            this.label_kategoria.AutoSize = true;
            this.label_kategoria.Location = new System.Drawing.Point(25, 50);
            this.label_kategoria.Name = "label_kategoria";
            this.label_kategoria.Size = new System.Drawing.Size(55, 13);
            this.label_kategoria.TabIndex = 0;
            this.label_kategoria.Text = "Kategória:";
            // 
            // textBox_kerdes
            // 
            this.textBox_kerdes.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_kerdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_kerdes.Location = new System.Drawing.Point(97, 91);
            this.textBox_kerdes.Name = "textBox_kerdes";
            this.textBox_kerdes.ReadOnly = true;
            this.textBox_kerdes.Size = new System.Drawing.Size(467, 20);
            this.textBox_kerdes.TabIndex = 2;
            // 
            // radioButton_valasz_A
            // 
            this.radioButton_valasz_A.AutoSize = true;
            this.radioButton_valasz_A.Location = new System.Drawing.Point(156, 143);
            this.radioButton_valasz_A.Name = "radioButton_valasz_A";
            this.radioButton_valasz_A.Size = new System.Drawing.Size(14, 13);
            this.radioButton_valasz_A.TabIndex = 3;
            this.radioButton_valasz_A.TabStop = true;
            this.radioButton_valasz_A.UseVisualStyleBackColor = true;
            this.radioButton_valasz_A.CheckedChanged += new System.EventHandler(this.radioButton_valasz_A_CheckedChanged);
            // 
            // radioButton_valasz_B
            // 
            this.radioButton_valasz_B.AutoSize = true;
            this.radioButton_valasz_B.Location = new System.Drawing.Point(156, 188);
            this.radioButton_valasz_B.Name = "radioButton_valasz_B";
            this.radioButton_valasz_B.Size = new System.Drawing.Size(14, 13);
            this.radioButton_valasz_B.TabIndex = 4;
            this.radioButton_valasz_B.TabStop = true;
            this.radioButton_valasz_B.UseVisualStyleBackColor = true;
            // 
            // radioButton_valasz_C
            // 
            this.radioButton_valasz_C.AutoSize = true;
            this.radioButton_valasz_C.Location = new System.Drawing.Point(156, 235);
            this.radioButton_valasz_C.Name = "radioButton_valasz_C";
            this.radioButton_valasz_C.Size = new System.Drawing.Size(14, 13);
            this.radioButton_valasz_C.TabIndex = 5;
            this.radioButton_valasz_C.TabStop = true;
            this.radioButton_valasz_C.UseVisualStyleBackColor = true;
            // 
            // textBox_valasz_B
            // 
            this.textBox_valasz_B.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_valasz_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_valasz_B.Location = new System.Drawing.Point(190, 185);
            this.textBox_valasz_B.Name = "textBox_valasz_B";
            this.textBox_valasz_B.Size = new System.Drawing.Size(374, 20);
            this.textBox_valasz_B.TabIndex = 7;
            // 
            // textBox_valasz_C
            // 
            this.textBox_valasz_C.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_valasz_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_valasz_C.Location = new System.Drawing.Point(190, 232);
            this.textBox_valasz_C.Name = "textBox_valasz_C";
            this.textBox_valasz_C.Size = new System.Drawing.Size(374, 20);
            this.textBox_valasz_C.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.kilepesToolStripMenuItem,
            this.sugoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
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
            // button_tovabb
            // 
            this.button_tovabb.Location = new System.Drawing.Point(97, 297);
            this.button_tovabb.Name = "button_tovabb";
            this.button_tovabb.Size = new System.Drawing.Size(185, 39);
            this.button_tovabb.TabIndex = 10;
            this.button_tovabb.Text = "Tovább";
            this.button_tovabb.UseVisualStyleBackColor = true;
            // 
            // button_befejezes
            // 
            this.button_befejezes.Location = new System.Drawing.Point(380, 297);
            this.button_befejezes.Name = "button_befejezes";
            this.button_befejezes.Size = new System.Drawing.Size(184, 39);
            this.button_befejezes.TabIndex = 11;
            this.button_befejezes.Text = "Befejezés";
            this.button_befejezes.UseVisualStyleBackColor = true;
            this.button_befejezes.Click += new System.EventHandler(this.button_befejezes_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_valasz_A
            // 
            this.textBox_valasz_A.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_valasz_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_valasz_A.Location = new System.Drawing.Point(190, 140);
            this.textBox_valasz_A.Name = "textBox_valasz_A";
            this.textBox_valasz_A.Size = new System.Drawing.Size(374, 20);
            this.textBox_valasz_A.TabIndex = 6;
            // 
            // label_kat
            // 
            this.label_kat.AutoSize = true;
            this.label_kat.Location = new System.Drawing.Point(114, 50);
            this.label_kat.Name = "label_kat";
            this.label_kat.Size = new System.Drawing.Size(79, 13);
            this.label_kat.TabIndex = 12;
            this.label_kat.Text = "label_kategoria";
            // 
            // Form_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_kat);
            this.Controls.Add(this.button_befejezes);
            this.Controls.Add(this.button_tovabb);
            this.Controls.Add(this.textBox_valasz_C);
            this.Controls.Add(this.textBox_valasz_B);
            this.Controls.Add(this.textBox_valasz_A);
            this.Controls.Add(this.radioButton_valasz_C);
            this.Controls.Add(this.radioButton_valasz_B);
            this.Controls.Add(this.radioButton_valasz_A);
            this.Controls.Add(this.textBox_kerdes);
            this.Controls.Add(this.label_kategoria);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Quiz";
            this.Text = "Form_Quiz";
            this.Load += new System.EventHandler(this.Form_Quiz_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_kategoria;
        private System.Windows.Forms.TextBox textBox_kerdes;
        private System.Windows.Forms.RadioButton radioButton_valasz_A;
        private System.Windows.Forms.RadioButton radioButton_valasz_B;
        private System.Windows.Forms.RadioButton radioButton_valasz_C;
        private System.Windows.Forms.TextBox textBox_valasz_B;
        private System.Windows.Forms.TextBox textBox_valasz_C;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugoToolStripMenuItem;
        private System.Windows.Forms.Button button_tovabb;
        private System.Windows.Forms.Button button_befejezes;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_valasz_A;
        private System.Windows.Forms.Label label_kat;
    }
}