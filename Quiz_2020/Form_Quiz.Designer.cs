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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Quiz));
            this.textBox_kerdes = new System.Windows.Forms.TextBox();
            this.radioButton_valasz_A = new System.Windows.Forms.RadioButton();
            this.radioButton_valasz_B = new System.Windows.Forms.RadioButton();
            this.radioButton_valasz_C = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_tovabb = new System.Windows.Forms.Button();
            this.button_befejezes = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Valaszok = new System.Windows.Forms.GroupBox();
            this.label_kat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox_Valaszok.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_kerdes
            // 
            this.textBox_kerdes.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBox_kerdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_kerdes.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kerdes.Location = new System.Drawing.Point(97, 115);
            this.textBox_kerdes.Multiline = true;
            this.textBox_kerdes.Name = "textBox_kerdes";
            this.textBox_kerdes.ReadOnly = true;
            this.textBox_kerdes.Size = new System.Drawing.Size(467, 34);
            this.textBox_kerdes.TabIndex = 2;
            // 
            // radioButton_valasz_A
            // 
            this.radioButton_valasz_A.AutoSize = true;
            this.radioButton_valasz_A.Location = new System.Drawing.Point(27, 16);
            this.radioButton_valasz_A.Name = "radioButton_valasz_A";
            this.radioButton_valasz_A.Size = new System.Drawing.Size(68, 17);
            this.radioButton_valasz_A.TabIndex = 3;
            this.radioButton_valasz_A.TabStop = true;
            this.radioButton_valasz_A.Text = "valasz_A";
            this.radioButton_valasz_A.UseVisualStyleBackColor = true;
            this.radioButton_valasz_A.CheckedChanged += new System.EventHandler(this.radioButton_valasz_A_CheckedChanged);
            // 
            // radioButton_valasz_B
            // 
            this.radioButton_valasz_B.AutoSize = true;
            this.radioButton_valasz_B.Location = new System.Drawing.Point(27, 60);
            this.radioButton_valasz_B.Name = "radioButton_valasz_B";
            this.radioButton_valasz_B.Size = new System.Drawing.Size(68, 17);
            this.radioButton_valasz_B.TabIndex = 4;
            this.radioButton_valasz_B.TabStop = true;
            this.radioButton_valasz_B.Text = "valasz_B";
            this.radioButton_valasz_B.UseVisualStyleBackColor = true;
            // 
            // radioButton_valasz_C
            // 
            this.radioButton_valasz_C.AutoSize = true;
            this.radioButton_valasz_C.Location = new System.Drawing.Point(27, 101);
            this.radioButton_valasz_C.Name = "radioButton_valasz_C";
            this.radioButton_valasz_C.Size = new System.Drawing.Size(68, 17);
            this.radioButton_valasz_C.TabIndex = 5;
            this.radioButton_valasz_C.TabStop = true;
            this.radioButton_valasz_C.Text = "valasz_C";
            this.radioButton_valasz_C.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.kilepesToolStripMenuItem,
            this.sugoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
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
            this.button_tovabb.BackColor = System.Drawing.Color.White;
            this.button_tovabb.Font = new System.Drawing.Font("Tw Cen MT", 12.25F);
            this.button_tovabb.Location = new System.Drawing.Point(97, 361);
            this.button_tovabb.Name = "button_tovabb";
            this.button_tovabb.Size = new System.Drawing.Size(207, 58);
            this.button_tovabb.TabIndex = 10;
            this.button_tovabb.Text = "Tovább";
            this.button_tovabb.UseVisualStyleBackColor = false;
            // 
            // button_befejezes
            // 
            this.button_befejezes.BackColor = System.Drawing.Color.White;
            this.button_befejezes.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_befejezes.Location = new System.Drawing.Point(361, 361);
            this.button_befejezes.Name = "button_befejezes";
            this.button_befejezes.Size = new System.Drawing.Size(203, 58);
            this.button_befejezes.TabIndex = 11;
            this.button_befejezes.Text = "Befejezés";
            this.button_befejezes.UseVisualStyleBackColor = false;
            this.button_befejezes.Click += new System.EventHandler(this.button_befejezes_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox_Valaszok
            // 
            this.groupBox_Valaszok.BackColor = System.Drawing.Color.White;
            this.groupBox_Valaszok.Controls.Add(this.radioButton_valasz_A);
            this.groupBox_Valaszok.Controls.Add(this.radioButton_valasz_B);
            this.groupBox_Valaszok.Controls.Add(this.radioButton_valasz_C);
            this.groupBox_Valaszok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Valaszok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Valaszok.Location = new System.Drawing.Point(97, 177);
            this.groupBox_Valaszok.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox_Valaszok.Name = "groupBox_Valaszok";
            this.groupBox_Valaszok.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox_Valaszok.Size = new System.Drawing.Size(467, 133);
            this.groupBox_Valaszok.TabIndex = 13;
            this.groupBox_Valaszok.TabStop = false;
            // 
            // label_kat
            // 
            this.label_kat.AutoSize = true;
            this.label_kat.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_kat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_kat.Location = new System.Drawing.Point(304, 61);
            this.label_kat.Name = "label_kat";
            this.label_kat.Size = new System.Drawing.Size(0, 28);
            this.label_kat.TabIndex = 15;
            // 
            // Form_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.label_kat);
            this.Controls.Add(this.groupBox_Valaszok);
            this.Controls.Add(this.button_befejezes);
            this.Controls.Add(this.button_tovabb);
            this.Controls.Add(this.textBox_kerdes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Quiz";
            this.Text = "Kvíz";
            this.Load += new System.EventHandler(this.Form_Quiz_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_Valaszok.ResumeLayout(false);
            this.groupBox_Valaszok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_kerdes;
        private System.Windows.Forms.RadioButton radioButton_valasz_A;
        private System.Windows.Forms.RadioButton radioButton_valasz_B;
        private System.Windows.Forms.RadioButton radioButton_valasz_C;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugoToolStripMenuItem;
        private System.Windows.Forms.Button button_tovabb;
        private System.Windows.Forms.Button button_befejezes;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_Valaszok;
        private System.Windows.Forms.Label label_kat;
    }
}