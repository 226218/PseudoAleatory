namespace WindowsFormsApplication1
{
    partial class FormKolmogorov
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUniformidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNivelConfianza = new System.Windows.Forms.TextBox();
            this.gridKolmoDatos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grupostxtBox = new System.Windows.Forms.TextBox();
            this.gridVKolmo = new System.Windows.Forms.DataGridView();
            this.gridVDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.sumtxtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPoker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridKolmoDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVKolmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(16, 20);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Uniformidad";
            // 
            // txtUniformidad
            // 
            this.txtUniformidad.Location = new System.Drawing.Point(806, 329);
            this.txtUniformidad.Name = "txtUniformidad";
            this.txtUniformidad.Size = new System.Drawing.Size(175, 20);
            this.txtUniformidad.TabIndex = 48;
            this.txtUniformidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grupostxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nivel de Confianza";
            // 
            // txtNivelConfianza
            // 
            this.txtNivelConfianza.Location = new System.Drawing.Point(151, 214);
            this.txtNivelConfianza.Name = "txtNivelConfianza";
            this.txtNivelConfianza.Size = new System.Drawing.Size(62, 20);
            this.txtNivelConfianza.TabIndex = 46;
            this.txtNivelConfianza.TextChanged += new System.EventHandler(this.txtNivelConfianza_TextChanged);
            this.txtNivelConfianza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grupostxtBox_KeyPress);
            // 
            // gridKolmoDatos
            // 
            this.gridKolmoDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKolmoDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column4,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Column3});
            this.gridKolmoDatos.Location = new System.Drawing.Point(1, 292);
            this.gridKolmoDatos.Name = "gridKolmoDatos";
            this.gridKolmoDatos.Size = new System.Drawing.Size(697, 212);
            this.gridKolmoDatos.TabIndex = 45;
            this.gridKolmoDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChiDatos_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "i";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Grupos";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "n0";
            this.Column4.Name = "Column4";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "f0(xi)";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Nt,i=(n*pi)";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "F1(xi)";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ABS(Xi-(i-1)/n)";
            this.Column3.Name = "Column3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Generar Kolmogorov";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cantidad de Grupos";
            // 
            // grupostxtBox
            // 
            this.grupostxtBox.Location = new System.Drawing.Point(135, 188);
            this.grupostxtBox.Name = "grupostxtBox";
            this.grupostxtBox.Size = new System.Drawing.Size(100, 20);
            this.grupostxtBox.TabIndex = 40;
            this.grupostxtBox.TextChanged += new System.EventHandler(this.grupostxtBox_TextChanged);
            this.grupostxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grupostxtBox_KeyPress);
            // 
            // gridVKolmo
            // 
            this.gridVKolmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVKolmo.Location = new System.Drawing.Point(505, 12);
            this.gridVKolmo.Name = "gridVKolmo";
            this.gridVKolmo.Size = new System.Drawing.Size(462, 233);
            this.gridVKolmo.TabIndex = 38;
            // 
            // gridVDatos
            // 
            this.gridVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridVDatos.Location = new System.Drawing.Point(12, 12);
            this.gridVDatos.Name = "gridVDatos";
            this.gridVDatos.Size = new System.Drawing.Size(294, 166);
            this.gridVDatos.TabIndex = 37;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Sumatoria";
            // 
            // sumtxtBox
            // 
            this.sumtxtBox.Location = new System.Drawing.Point(806, 303);
            this.sumtxtBox.Name = "sumtxtBox";
            this.sumtxtBox.Size = new System.Drawing.Size(175, 20);
            this.sumtxtBox.TabIndex = 51;
            this.sumtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grupostxtBox_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(907, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 83);
            this.button2.TabIndex = 53;
            this.button2.Text = "Corridas Por Abajo y Por Arriba";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(794, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 83);
            this.button3.TabIndex = 54;
            this.button3.Text = "Corridas Ascendentes y Descendentes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPoker
            // 
            this.btnPoker.Location = new System.Drawing.Point(704, 421);
            this.btnPoker.Name = "btnPoker";
            this.btnPoker.Size = new System.Drawing.Size(84, 83);
            this.btnPoker.TabIndex = 55;
            this.btnPoker.Text = "Test de Poker";
            this.btnPoker.UseVisualStyleBackColor = true;
            this.btnPoker.Click += new System.EventHandler(this.btnPoker_Click);
            // 
            // FormKolmogorov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 533);
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
            this.Controls.Add(this.gridKolmoDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grupostxtBox);
            this.Controls.Add(this.gridVKolmo);
            this.Controls.Add(this.gridVDatos);
            this.Name = "FormKolmogorov";
            this.Text = "FormKolmogorov";
            this.Load += new System.EventHandler(this.FormKolmogorov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKolmoDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVKolmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUniformidad;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNivelConfianza;
        private System.Windows.Forms.DataGridView gridKolmoDatos;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox grupostxtBox;
        private System.Windows.Forms.DataGridView gridVKolmo;
        public System.Windows.Forms.DataGridView gridVDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sumtxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPoker;
    }
}