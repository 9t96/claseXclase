namespace FerretePinturasTP3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFaC = new System.Windows.Forms.Button();
            this.btnCaF = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Temperatura:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFaC
            // 
            this.btnFaC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFaC.Location = new System.Drawing.Point(22, 151);
            this.btnFaC.Name = "btnFaC";
            this.btnFaC.Size = new System.Drawing.Size(250, 23);
            this.btnFaC.TabIndex = 1;
            this.btnFaC.Text = "A- De Fahrenheit a Centigrados.";
            this.btnFaC.UseVisualStyleBackColor = true;
            this.btnFaC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCaF
            // 
            this.btnCaF.Location = new System.Drawing.Point(22, 196);
            this.btnCaF.Name = "btnCaF";
            this.btnCaF.Size = new System.Drawing.Size(250, 25);
            this.btnCaF.TabIndex = 2;
            this.btnCaF.Text = "B-De Centigrados a Fahrenheit.";
            this.btnCaF.UseVisualStyleBackColor = true;
            this.btnCaF.Click += new System.EventHandler(this.btnCaF_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCaF);
            this.Controls.Add(this.btnFaC);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFaC;
        private System.Windows.Forms.Button btnCaF;
        private System.Windows.Forms.TextBox textBox1;
    }
}

