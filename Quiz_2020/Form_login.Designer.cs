﻿namespace Quiz_2020
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.textBox_fnev = new System.Windows.Forms.TextBox();
            this.label_belepes_fnev = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_belepes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kezdőlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategóriákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mikrobiológiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immunológiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biokémiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.növényrendszertanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_fnev
            // 
            this.textBox_fnev.Location = new System.Drawing.Point(120, 52);
            this.textBox_fnev.Name = "textBox_fnev";
            this.textBox_fnev.Size = new System.Drawing.Size(188, 25);
            this.textBox_fnev.TabIndex = 1;
            this.textBox_fnev.TextChanged += new System.EventHandler(this.textBox_fnev_TextChanged);
            // 
            // label_belepes_fnev
            // 
            this.label_belepes_fnev.AutoSize = true;
            this.label_belepes_fnev.Location = new System.Drawing.Point(6, 52);
            this.label_belepes_fnev.Name = "label_belepes_fnev";
            this.label_belepes_fnev.Size = new System.Drawing.Size(108, 19);
            this.label_belepes_fnev.TabIndex = 2;
            this.label_belepes_fnev.Text = "Felhasználónév:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(64, 96);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(50, 19);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Jelszó:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(120, 96);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(188, 25);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.button_belepes);
            this.groupBox1.Controls.Add(this.textBox_fnev);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.label_belepes_fnev);
            this.groupBox1.Controls.Add(this.label_password);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(91, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bejelentkezés";
            // 
            // button_belepes
            // 
            this.button_belepes.BackColor = System.Drawing.Color.LightGray;
            this.button_belepes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_belepes.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.button_belepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_belepes.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_belepes.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_belepes.Location = new System.Drawing.Point(120, 143);
            this.button_belepes.Name = "button_belepes";
            this.button_belepes.Size = new System.Drawing.Size(107, 48);
            this.button_belepes.TabIndex = 6;
            this.button_belepes.Text = "Belépés";
            this.button_belepes.UseVisualStyleBackColor = false;
            this.button_belepes.Click += new System.EventHandler(this.button_belepes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kezdőlapToolStripMenuItem,
            this.kategóriákToolStripMenuItem,
            this.súgóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kezdőlapToolStripMenuItem
            // 
            this.kezdőlapToolStripMenuItem.Name = "kezdőlapToolStripMenuItem";
            this.kezdőlapToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.kezdőlapToolStripMenuItem.Text = "Kezdőlap";
            this.kezdőlapToolStripMenuItem.Click += new System.EventHandler(this.kezdolapToolStripMenuItem_Click);
            // 
            // kategóriákToolStripMenuItem
            // 
            this.kategóriákToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mikrobiológiaToolStripMenuItem,
            this.immunológiaToolStripMenuItem,
            this.biokémiaToolStripMenuItem,
            this.növényrendszertanToolStripMenuItem});
            this.kategóriákToolStripMenuItem.Name = "kategóriákToolStripMenuItem";
            this.kategóriákToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.kategóriákToolStripMenuItem.Text = "Kategóriák";
            // 
            // mikrobiológiaToolStripMenuItem
            // 
            this.mikrobiológiaToolStripMenuItem.Name = "mikrobiológiaToolStripMenuItem";
            this.mikrobiológiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mikrobiológiaToolStripMenuItem.Text = "Mikrobiológia";
            // 
            // immunológiaToolStripMenuItem
            // 
            this.immunológiaToolStripMenuItem.Name = "immunológiaToolStripMenuItem";
            this.immunológiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.immunológiaToolStripMenuItem.Text = "Immunológia";
            // 
            // biokémiaToolStripMenuItem
            // 
            this.biokémiaToolStripMenuItem.Name = "biokémiaToolStripMenuItem";
            this.biokémiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.biokémiaToolStripMenuItem.Text = "Biokémia";
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.súgóToolStripMenuItem.Text = "Súgó";
            // 
            // növényrendszertanToolStripMenuItem
            // 
            this.növényrendszertanToolStripMenuItem.Name = "növényrendszertanToolStripMenuItem";
            this.növényrendszertanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.növényrendszertanToolStripMenuItem.Text = "Növényrendszertan";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(521, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Login";
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_fnev;
        private System.Windows.Forms.Label label_belepes_fnev;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_belepes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kezdőlapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategóriákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mikrobiológiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem immunológiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biokémiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem növényrendszertanToolStripMenuItem;
    }
}