namespace trestres.ui
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
            this.btnCorrerCarrera = new System.Windows.Forms.Button();
            this.gbCarrera = new System.Windows.Forms.GroupBox();
            this.textBoxLugarCarrera = new System.Windows.Forms.TextBox();
            this.textBoxFechaCarrera = new System.Windows.Forms.TextBox();
            this.label3GBCarrera = new System.Windows.Forms.Label();
            this.label2GBCarrera = new System.Windows.Forms.Label();
            this.textBoxNombreCarrera = new System.Windows.Forms.TextBox();
            this.lblGBCarrera = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.labelFabricante = new System.Windows.Forms.Label();
            this.labelNombrePiloto = new System.Windows.Forms.Label();
            this.textBoxNombrePiloto = new System.Windows.Forms.TextBox();
            this.gbListaAutos = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.lblTiempoOKm = new System.Windows.Forms.Label();
            this.textBoxToK = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnXkilometro = new System.Windows.Forms.Button();
            this.btnXtiempo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rdBtnAsc = new System.Windows.Forms.RadioButton();
            this.rdbtnDesc = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnORDEnar = new System.Windows.Forms.Button();
            this.gbCarrera.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbListaAutos.SuspendLayout();
            this.gbResultado.SuspendLayout();
            this.gbOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCorrerCarrera
            // 
            this.btnCorrerCarrera.Location = new System.Drawing.Point(20, 78);
            this.btnCorrerCarrera.Name = "btnCorrerCarrera";
            this.btnCorrerCarrera.Size = new System.Drawing.Size(93, 23);
            this.btnCorrerCarrera.TabIndex = 0;
            this.btnCorrerCarrera.Text = "Carrera";
            this.btnCorrerCarrera.UseVisualStyleBackColor = true;
            this.btnCorrerCarrera.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbCarrera
            // 
            this.gbCarrera.Controls.Add(this.textBoxLugarCarrera);
            this.gbCarrera.Controls.Add(this.textBoxFechaCarrera);
            this.gbCarrera.Controls.Add(this.label3GBCarrera);
            this.gbCarrera.Controls.Add(this.label2GBCarrera);
            this.gbCarrera.Controls.Add(this.textBoxNombreCarrera);
            this.gbCarrera.Controls.Add(this.lblGBCarrera);
            this.gbCarrera.Controls.Add(this.btnCorrerCarrera);
            this.gbCarrera.Location = new System.Drawing.Point(22, 30);
            this.gbCarrera.Name = "gbCarrera";
            this.gbCarrera.Size = new System.Drawing.Size(571, 119);
            this.gbCarrera.TabIndex = 1;
            this.gbCarrera.TabStop = false;
            this.gbCarrera.Text = "Carrera";
            this.gbCarrera.Enter += new System.EventHandler(this.Carrera_Enter);
            // 
            // textBoxLugarCarrera
            // 
            this.textBoxLugarCarrera.Location = new System.Drawing.Point(303, 45);
            this.textBoxLugarCarrera.Name = "textBoxLugarCarrera";
            this.textBoxLugarCarrera.Size = new System.Drawing.Size(124, 20);
            this.textBoxLugarCarrera.TabIndex = 6;
            this.textBoxLugarCarrera.TextChanged += new System.EventHandler(this.textBoxLugarCarrera_TextChanged);
            // 
            // textBoxFechaCarrera
            // 
            this.textBoxFechaCarrera.Location = new System.Drawing.Point(163, 45);
            this.textBoxFechaCarrera.Name = "textBoxFechaCarrera";
            this.textBoxFechaCarrera.Size = new System.Drawing.Size(124, 20);
            this.textBoxFechaCarrera.TabIndex = 5;
            this.textBoxFechaCarrera.TextChanged += new System.EventHandler(this.textBoxFechaCarrera_TextChanged);
            // 
            // label3GBCarrera
            // 
            this.label3GBCarrera.AutoSize = true;
            this.label3GBCarrera.Location = new System.Drawing.Point(300, 16);
            this.label3GBCarrera.Name = "label3GBCarrera";
            this.label3GBCarrera.Size = new System.Drawing.Size(34, 13);
            this.label3GBCarrera.TabIndex = 4;
            this.label3GBCarrera.Text = "Lugar";
            // 
            // label2GBCarrera
            // 
            this.label2GBCarrera.AutoSize = true;
            this.label2GBCarrera.Location = new System.Drawing.Point(160, 16);
            this.label2GBCarrera.Name = "label2GBCarrera";
            this.label2GBCarrera.Size = new System.Drawing.Size(37, 13);
            this.label2GBCarrera.TabIndex = 3;
            this.label2GBCarrera.Text = "Fecha";
            // 
            // textBoxNombreCarrera
            // 
            this.textBoxNombreCarrera.Location = new System.Drawing.Point(20, 45);
            this.textBoxNombreCarrera.Name = "textBoxNombreCarrera";
            this.textBoxNombreCarrera.Size = new System.Drawing.Size(124, 20);
            this.textBoxNombreCarrera.TabIndex = 2;
            this.textBoxNombreCarrera.TextChanged += new System.EventHandler(this.textBoxGBCarrera_TextChanged);
            // 
            // lblGBCarrera
            // 
            this.lblGBCarrera.AutoSize = true;
            this.lblGBCarrera.Location = new System.Drawing.Point(17, 16);
            this.lblGBCarrera.Name = "lblGBCarrera";
            this.lblGBCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblGBCarrera.TabIndex = 1;
            this.lblGBCarrera.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btnAgregarAuto);
            this.groupBox2.Controls.Add(this.labelFabricante);
            this.groupBox2.Controls.Add(this.labelNombrePiloto);
            this.groupBox2.Controls.Add(this.textBoxNombrePiloto);
            this.groupBox2.Location = new System.Drawing.Point(22, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(61, 74);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(160, 34);
            this.btnAgregarAuto.TabIndex = 4;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // labelFabricante
            // 
            this.labelFabricante.AutoSize = true;
            this.labelFabricante.Location = new System.Drawing.Point(146, 29);
            this.labelFabricante.Name = "labelFabricante";
            this.labelFabricante.Size = new System.Drawing.Size(57, 13);
            this.labelFabricante.TabIndex = 3;
            this.labelFabricante.Text = "Fabricante";
            // 
            // labelNombrePiloto
            // 
            this.labelNombrePiloto.AutoSize = true;
            this.labelNombrePiloto.Location = new System.Drawing.Point(9, 29);
            this.labelNombrePiloto.Name = "labelNombrePiloto";
            this.labelNombrePiloto.Size = new System.Drawing.Size(44, 13);
            this.labelNombrePiloto.TabIndex = 2;
            this.labelNombrePiloto.Text = "Nombre";
            // 
            // textBoxNombrePiloto
            // 
            this.textBoxNombrePiloto.Location = new System.Drawing.Point(12, 47);
            this.textBoxNombrePiloto.Name = "textBoxNombrePiloto";
            this.textBoxNombrePiloto.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombrePiloto.TabIndex = 0;
            // 
            // gbListaAutos
            // 
            this.gbListaAutos.Controls.Add(this.listBox1);
            this.gbListaAutos.Location = new System.Drawing.Point(304, 155);
            this.gbListaAutos.Name = "gbListaAutos";
            this.gbListaAutos.Size = new System.Drawing.Size(538, 271);
            this.gbListaAutos.TabIndex = 3;
            this.gbListaAutos.TabStop = false;
            this.gbListaAutos.Text = "Lista de Autos";
            this.gbListaAutos.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(502, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.lblTiempoOKm);
            this.gbResultado.Controls.Add(this.textBoxToK);
            this.gbResultado.Controls.Add(this.textBox1);
            this.gbResultado.Controls.Add(this.btnXkilometro);
            this.gbResultado.Controls.Add(this.btnXtiempo);
            this.gbResultado.Location = new System.Drawing.Point(22, 432);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(820, 290);
            this.gbResultado.TabIndex = 4;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // lblTiempoOKm
            // 
            this.lblTiempoOKm.AutoSize = true;
            this.lblTiempoOKm.Location = new System.Drawing.Point(22, 22);
            this.lblTiempoOKm.Name = "lblTiempoOKm";
            this.lblTiempoOKm.Size = new System.Drawing.Size(143, 13);
            this.lblTiempoOKm.TabIndex = 4;
            this.lblTiempoOKm.Text = "Ingrese Tiempo o Kilometros:";
            // 
            // textBoxToK
            // 
            this.textBoxToK.Location = new System.Drawing.Point(16, 60);
            this.textBoxToK.Name = "textBoxToK";
            this.textBoxToK.Size = new System.Drawing.Size(254, 20);
            this.textBoxToK.TabIndex = 3;
            this.textBoxToK.TextChanged += new System.EventHandler(this.textBoxToK_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 265);
            this.textBox1.TabIndex = 2;
            // 
            // btnXkilometro
            // 
            this.btnXkilometro.Location = new System.Drawing.Point(157, 113);
            this.btnXkilometro.Name = "btnXkilometro";
            this.btnXkilometro.Size = new System.Drawing.Size(113, 25);
            this.btnXkilometro.TabIndex = 1;
            this.btnXkilometro.Text = "Correr por Kilometros";
            this.btnXkilometro.UseVisualStyleBackColor = true;
            this.btnXkilometro.Click += new System.EventHandler(this.btnXkilometro_Click);
            // 
            // btnXtiempo
            // 
            this.btnXtiempo.Location = new System.Drawing.Point(20, 113);
            this.btnXtiempo.Name = "btnXtiempo";
            this.btnXtiempo.Size = new System.Drawing.Size(113, 25);
            this.btnXtiempo.TabIndex = 0;
            this.btnXtiempo.Text = "Correr por Tiempo";
            this.btnXtiempo.UseVisualStyleBackColor = true;
            this.btnXtiempo.Click += new System.EventHandler(this.btnXtiempo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.btnORDEnar);
            this.gbOrdenar.Controls.Add(this.comboBox2);
            this.gbOrdenar.Controls.Add(this.rdbtnDesc);
            this.gbOrdenar.Controls.Add(this.rdBtnAsc);
            this.gbOrdenar.Location = new System.Drawing.Point(22, 297);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(270, 129);
            this.gbOrdenar.TabIndex = 6;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar por:";
            // 
            // rdBtnAsc
            // 
            this.rdBtnAsc.AutoSize = true;
            this.rdBtnAsc.Location = new System.Drawing.Point(63, 56);
            this.rdBtnAsc.Name = "rdBtnAsc";
            this.rdBtnAsc.Size = new System.Drawing.Size(49, 17);
            this.rdBtnAsc.TabIndex = 8;
            this.rdBtnAsc.TabStop = true;
            this.rdBtnAsc.Text = "Asce";
            this.rdBtnAsc.UseVisualStyleBackColor = true;
            // 
            // rdbtnDesc
            // 
            this.rdbtnDesc.AutoSize = true;
            this.rdbtnDesc.Location = new System.Drawing.Point(135, 56);
            this.rdbtnDesc.Name = "rdbtnDesc";
            this.rdbtnDesc.Size = new System.Drawing.Size(50, 17);
            this.rdbtnDesc.TabIndex = 9;
            this.rdbtnDesc.TabStop = true;
            this.rdbtnDesc.Text = "Desc";
            this.rdbtnDesc.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Fabricante",
            "Piloto"});
            this.comboBox2.Location = new System.Drawing.Point(63, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // btnORDEnar
            // 
            this.btnORDEnar.Location = new System.Drawing.Point(44, 90);
            this.btnORDEnar.Name = "btnORDEnar";
            this.btnORDEnar.Size = new System.Drawing.Size(177, 33);
            this.btnORDEnar.TabIndex = 11;
            this.btnORDEnar.Text = "Ordenar";
            this.btnORDEnar.UseVisualStyleBackColor = true;
            this.btnORDEnar.Click += new System.EventHandler(this.btnORDEnar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 734);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbListaAutos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCarrera.ResumeLayout(false);
            this.gbCarrera.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbListaAutos.ResumeLayout(false);
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCorrerCarrera;
        private System.Windows.Forms.GroupBox gbCarrera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbListaAutos;
        private System.Windows.Forms.TextBox textBoxLugarCarrera;
        private System.Windows.Forms.TextBox textBoxFechaCarrera;
        private System.Windows.Forms.Label label3GBCarrera;
        private System.Windows.Forms.Label label2GBCarrera;
        private System.Windows.Forms.TextBox textBoxNombreCarrera;
        private System.Windows.Forms.Label lblGBCarrera;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Label labelFabricante;
        private System.Windows.Forms.Label labelNombrePiloto;
        private System.Windows.Forms.TextBox textBoxNombrePiloto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnXtiempo;
        private System.Windows.Forms.Button btnXkilometro;
        private System.Windows.Forms.Label lblTiempoOKm;
        private System.Windows.Forms.TextBox textBoxToK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton rdbtnDesc;
        private System.Windows.Forms.RadioButton rdBtnAsc;
        private System.Windows.Forms.Button btnORDEnar;
    }
}

