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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nyito));
            this.button_kilepes = new System.Windows.Forms.Button();
            this.button_belepes = new System.Windows.Forms.Button();
            this.button_regisztracio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_kilepes
            // 
            this.button_kilepes.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_kilepes.Location = new System.Drawing.Point(438, 172);
            this.button_kilepes.Name = "button_kilepes";
            this.button_kilepes.Size = new System.Drawing.Size(132, 63);
            this.button_kilepes.TabIndex = 1;
            this.button_kilepes.Text = "Kilépés";
            this.button_kilepes.UseVisualStyleBackColor = true;
            this.button_kilepes.Click += new System.EventHandler(this.button_kilepes_Click);
            // 
            // button_belepes
            // 
            this.button_belepes.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_belepes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_belepes.Location = new System.Drawing.Point(98, 172);
            this.button_belepes.Name = "button_belepes";
            this.button_belepes.Size = new System.Drawing.Size(132, 63);
            this.button_belepes.TabIndex = 2;
            this.button_belepes.Text = "Belépés";
            this.button_belepes.UseVisualStyleBackColor = true;
            this.button_belepes.Click += new System.EventHandler(this.button_belepes_Click);
            // 
            // button_regisztracio
            // 
            this.button_regisztracio.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_regisztracio.Location = new System.Drawing.Point(265, 172);
            this.button_regisztracio.Name = "button_regisztracio";
            this.button_regisztracio.Size = new System.Drawing.Size(132, 63);
            this.button_regisztracio.TabIndex = 3;
            this.button_regisztracio.Text = "Regisztráció";
            this.button_regisztracio.UseVisualStyleBackColor = true;
            this.button_regisztracio.Click += new System.EventHandler(this.button_regisztracio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(190, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Üdvözöllek a BioQuiz-ben! ";
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(677, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_regisztracio);
            this.Controls.Add(this.button_belepes);
            this.Controls.Add(this.button_kilepes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Nyito";
            this.Text = "BioQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_kilepes;
        private System.Windows.Forms.Button button_belepes;
        private System.Windows.Forms.Button button_regisztracio;
        private System.Windows.Forms.Label label1;
    }
}

