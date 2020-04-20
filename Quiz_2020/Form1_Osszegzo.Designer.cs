namespace Quiz_2020
{
    partial class Form1_Osszegzo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_kezdolap = new System.Windows.Forms.Button();
            this.button_jatek = new System.Windows.Forms.Button();
            this.button_kilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gratulálok!";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(292, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 59);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(647, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "A kategóriában összegyűjtött pontod:";
            // 
            // button_kezdolap
            // 
            this.button_kezdolap.Location = new System.Drawing.Point(96, 262);
            this.button_kezdolap.Name = "button_kezdolap";
            this.button_kezdolap.Size = new System.Drawing.Size(154, 30);
            this.button_kezdolap.TabIndex = 3;
            this.button_kezdolap.Text = "Kezdőlap";
            this.button_kezdolap.UseVisualStyleBackColor = true;
            this.button_kezdolap.Click += new System.EventHandler(this.button_kezdolap_Click);
            // 
            // button_jatek
            // 
            this.button_jatek.Location = new System.Drawing.Point(265, 262);
            this.button_jatek.Name = "button_jatek";
            this.button_jatek.Size = new System.Drawing.Size(142, 30);
            this.button_jatek.TabIndex = 4;
            this.button_jatek.Text = "Újra játszok!";
            this.button_jatek.UseVisualStyleBackColor = true;
            // 
            // button_kilepes
            // 
            this.button_kilepes.Location = new System.Drawing.Point(426, 262);
            this.button_kilepes.Name = "button_kilepes";
            this.button_kilepes.Size = new System.Drawing.Size(167, 29);
            this.button_kilepes.TabIndex = 5;
            this.button_kilepes.Text = "Kilépés";
            this.button_kilepes.UseVisualStyleBackColor = true;
            this.button_kilepes.Click += new System.EventHandler(this.button_kilepes_Click);
            // 
            // Form1_Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_kilepes);
            this.Controls.Add(this.button_jatek);
            this.Controls.Add(this.button_kezdolap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1_Profil";
            this.Text = "Form1_Osszegzo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_kezdolap;
        private System.Windows.Forms.Button button_jatek;
        private System.Windows.Forms.Button button_kilepes;
    }
}