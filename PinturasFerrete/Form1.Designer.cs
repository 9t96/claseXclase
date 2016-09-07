namespace PinturasFerrete
{
    partial class Form1
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
            this.btnFaC = new System.Windows.Forms.Button();
            this.btnCaF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFaC
            // 
            this.btnFaC.Location = new System.Drawing.Point(53, 127);
            this.btnFaC.Name = "btnFaC";
            this.btnFaC.Size = new System.Drawing.Size(170, 23);
            this.btnFaC.TabIndex = 0;
            this.btnFaC.Text = "A- Fahrenheit a Centigrados";
            this.btnFaC.UseVisualStyleBackColor = true;
            this.btnFaC.Click += new System.EventHandler(this.btnFaC_Click);
            // 
            // btnCaF
            // 
            this.btnCaF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCaF.Location = new System.Drawing.Point(53, 175);
            this.btnCaF.Name = "btnCaF";
            this.btnCaF.Size = new System.Drawing.Size(170, 23);
            this.btnCaF.TabIndex = 1;
            this.btnCaF.Text = "B- Centigrados a Fahrenheit";
            this.btnCaF.UseVisualStyleBackColor = true;
            this.btnCaF.Click += new System.EventHandler(this.btnCaF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese temperatura: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaF);
            this.Controls.Add(this.btnFaC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFaC;
        private System.Windows.Forms.Button btnCaF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

