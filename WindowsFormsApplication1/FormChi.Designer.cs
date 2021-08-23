namespace WindowsFormsApplication1
{
    partial class FormChi
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
            this.gridVDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridVChi2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.clasetxtBox = new System.Windows.Forms.TextBox();
            this.GralibtxtBox = new System.Windows.Forms.TextBox();
            this.btnLineal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gridChiDatos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNivelConfianza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUniformidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sumtxtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPoker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridVDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVChi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVDatos
            // 
            this.gridVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridVDatos.Location = new System.Drawing.Point(12, 27);
            this.gridVDatos.Name = "gridVDatos";
            this.gridVDatos.Size = new System.Drawing.Size(294, 166);
            this.gridVDatos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "i";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "valor";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // gridVChi2
            // 
            this.gridVChi2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVChi2.Location = new System.Drawing.Point(500, 12);
            this.gridVChi2.Name = "gridVChi2";
            this.gridVChi2.Size = new System.Drawing.Size(462, 233);
            this.gridVChi2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cantidad Divisiones";
            this.label6.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(132, 205);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Clases";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 205);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Grado de Libertad";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // clasetxtBox
            // 
            this.clasetxtBox.Location = new System.Drawing.Point(322, 204);
            this.clasetxtBox.Name = "clasetxtBox";
            this.clasetxtBox.Size = new System.Drawing.Size(100, 20);
            this.clasetxtBox.TabIndex = 26;
            this.clasetxtBox.Visible = false;
            this.clasetxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GralibtxtBox_KeyPress);
            // 
            // GralibtxtBox
            // 
            this.GralibtxtBox.Location = new System.Drawing.Point(322, 204);
            this.GralibtxtBox.Name = "GralibtxtBox";
            this.GralibtxtBox.Size = new System.Drawing.Size(100, 20);
            this.GralibtxtBox.TabIndex = 25;
            this.GralibtxtBox.Visible = false;
            this.GralibtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GralibtxtBox_KeyPress);
            // 
            // btnLineal
            // 
            this.btnLineal.Location = new System.Drawing.Point(-380, 402);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(75, 23);
            this.btnLineal.TabIndex = 24;
            this.btnLineal.Text = "Lineal";
            this.btnLineal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Generar Chi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gridChiDatos
            // 
            this.gridChiDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChiDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.gridChiDatos.Location = new System.Drawing.Point(12, 294);
            this.gridChiDatos.Name = "gridChiDatos";
            this.gridChiDatos.Size = new System.Drawing.Size(493, 212);
            this.gridChiDatos.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "i";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Clases";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Oi";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Ei=(n*pi)";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "(Oi-Ei)^2/Ei";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // txtNivelConfianza
            // 
            this.txtNivelConfianza.Location = new System.Drawing.Point(156, 229);
            this.txtNivelConfianza.Name = "txtNivelConfianza";
            this.txtNivelConfianza.Size = new System.Drawing.Size(57, 20);
            this.txtNivelConfianza.TabIndex = 32;
            this.txtNivelConfianza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GralibtxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nivel de Confianza";
            // 
            // txtUniformidad
            // 
            this.txtUniformidad.Location = new System.Drawing.Point(648, 327);
            this.txtUniformidad.Name = "txtUniformidad";
            this.txtUniformidad.Size = new System.Drawing.Size(175, 20);
            this.txtUniformidad.TabIndex = 34;
            this.txtUniformidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GralibtxtBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Uniformidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(16, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sumatoria";
            // 
            // sumtxtBox
            // 
            this.sumtxtBox.Location = new System.Drawing.Point(648, 294);
            this.sumtxtBox.Name = "sumtxtBox";
            this.sumtxtBox.Size = new System.Drawing.Size(175, 20);
            this.sumtxtBox.TabIndex = 37;
            this.sumtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GralibtxtBox_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(855, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 83);
            this.button2.TabIndex = 39;
            this.button2.Text = "Corridas Por Abajo y Por Arriba";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(728, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 83);
            this.button3.TabIndex = 40;
            this.button3.Text = "Corridas Ascendentes y Descendentes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPoker
            // 
            this.btnPoker.Location = new System.Drawing.Point(600, 436);
            this.btnPoker.Name = "btnPoker";
            this.btnPoker.Size = new System.Drawing.Size(104, 83);
            this.btnPoker.TabIndex = 41;
            this.btnPoker.Text = "Test de Poker";
            this.btnPoker.UseVisualStyleBackColor = true;
            this.btnPoker.Click += new System.EventHandler(this.btnPoker_Click);
            // 
            // FormChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 531);
            this.Controls.Add(this.btnPoker);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sumtxtBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUniformidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNivelConfianza);
            this.Controls.Add(this.gridChiDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.clasetxtBox);
            this.Controls.Add(this.GralibtxtBox);
            this.Controls.Add(this.btnLineal);
            this.Controls.Add(this.gridVChi2);
            this.Controls.Add(this.gridVDatos);
            this.Name = "FormChi";
            this.Text = "FormChi";
            this.Load += new System.EventHandler(this.FormChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVChi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVChi2;
        public System.Windows.Forms.DataGridView gridVDatos;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.TextBox clasetxtBox;
        public System.Windows.Forms.TextBox GralibtxtBox;
        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView gridChiDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox txtNivelConfianza;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUniformidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sumtxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPoker;
    }
}