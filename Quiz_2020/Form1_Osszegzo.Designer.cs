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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Osszegzo));
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
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(222, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gratulálok!";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(292, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 59);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(88, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "A kvíz során összegyűjtött pontod:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_kezdolap
            // 
            this.button_kezdolap.BackColor = System.Drawing.Color.AliceBlue;
            this.button_kezdolap.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_kezdolap.Location = new System.Drawing.Point(96, 262);
            this.button_kezdolap.Name = "button_kezdolap";
            this.button_kezdolap.Size = new System.Drawing.Size(142, 58);
            this.button_kezdolap.TabIndex = 3;
            this.button_kezdolap.Text = "Kezdőlap";
            this.button_kezdolap.UseVisualStyleBackColor = false;
            this.button_kezdolap.Click += new System.EventHandler(this.button_kezdolap_Click);
            // 
            // button_jatek
            // 
            this.button_jatek.BackColor = System.Drawing.Color.AliceBlue;
            this.button_jatek.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_jatek.Location = new System.Drawing.Point(265, 262);
            this.button_jatek.Name = "button_jatek";
            this.button_jatek.Size = new System.Drawing.Size(142, 58);
            this.button_jatek.TabIndex = 4;
            this.button_jatek.Text = "Újra játszok!";
            this.button_jatek.UseVisualStyleBackColor = false;
            // 
            // button_kilepes
            // 
            this.button_kilepes.BackColor = System.Drawing.Color.AliceBlue;
            this.button_kilepes.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_kilepes.Location = new System.Drawing.Point(427, 262);
            this.button_kilepes.Name = "button_kilepes";
            this.button_kilepes.Size = new System.Drawing.Size(144, 58);
            this.button_kilepes.TabIndex = 5;
            this.button_kilepes.Text = "Kilépés";
            this.button_kilepes.UseVisualStyleBackColor = false;
            this.button_kilepes.Click += new System.EventHandler(this.button_kilepes_Click);
            // 
            // Form1_Osszegzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(692, 394);
            this.Controls.Add(this.button_kilepes);
            this.Controls.Add(this.button_jatek);
            this.Controls.Add(this.button_kezdolap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1_Osszegzo";
            this.Text = "Pontok";
            this.Load += new System.EventHandler(this.Form1_Osszegzo_Load);
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