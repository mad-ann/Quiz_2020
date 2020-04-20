namespace Quiz_2020
{
    partial class Form1_indito
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
            this.button_ok = new System.Windows.Forms.Button();
            this.button_megsem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(190, 178);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(102, 41);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_megsem
            // 
            this.button_megsem.Location = new System.Drawing.Point(366, 178);
            this.button_megsem.Name = "button_megsem";
            this.button_megsem.Size = new System.Drawing.Size(99, 41);
            this.button_megsem.TabIndex = 1;
            this.button_megsem.Text = "Mégsem";
            this.button_megsem.UseVisualStyleBackColor = true;
            this.button_megsem.Click += new System.EventHandler(this.button_megsem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(71, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 107);
            this.label1.TabIndex = 2;
            this.label1.Text = "A kvíz kitöltésére 20 másodperc áll rendelkezésére.  \r\n\r\nAmennyiben mégsem akarná" +
    " kitölteni, kattinson a \'Mégse\' gombra. \r\n\r\nAmikor készen áll, nyomja meg az \'OK" +
    "\' gombot!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1_indito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_megsem);
            this.Controls.Add(this.button_ok);
            this.Name = "Form1_indito";
            this.Text = "Form1_indito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_megsem;
        private System.Windows.Forms.Label label1;
    }
}