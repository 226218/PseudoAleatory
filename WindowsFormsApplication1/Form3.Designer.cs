namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cantidadtxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x0Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btngenerarkormo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column4,
            this.Column5});
            this.dataGridView3.Location = new System.Drawing.Point(2, 135);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(543, 150);
            this.dataGridView3.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "i";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Xi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Xi^2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cuadrado Medio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ui";
            this.Column5.Name = "Column5";
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(165, 106);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(218, 23);
            this.btnCuadrado.TabIndex = 14;
            this.btnCuadrado.Text = "Cuadrados Medios";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cantidad de Iteraciones";
            // 
            // cantidadtxtBox
            // 
            this.cantidadtxtBox.Location = new System.Drawing.Point(149, 65);
            this.cantidadtxtBox.Name = "cantidadtxtBox";
            this.cantidadtxtBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadtxtBox.TabIndex = 18;
            this.cantidadtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x0Box_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "X0";
            // 
            // x0Box
            // 
            this.x0Box.Location = new System.Drawing.Point(149, 16);
            this.x0Box.Name = "x0Box";
            this.x0Box.Size = new System.Drawing.Size(100, 20);
            this.x0Box.TabIndex = 16;
            this.x0Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x0Box_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 55);
            this.button1.TabIndex = 20;
            this.button1.Text = "Generar Chi-Cuadrado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngenerarkormo
            // 
            this.btngenerarkormo.Location = new System.Drawing.Point(595, 306);
            this.btngenerarkormo.Name = "btngenerarkormo";
            this.btngenerarkormo.Size = new System.Drawing.Size(72, 56);
            this.btngenerarkormo.TabIndex = 32;
            this.btngenerarkormo.Text = "Generar Kolmogorov";
            this.btngenerarkormo.UseVisualStyleBackColor = true;
            this.btngenerarkormo.Click += new System.EventHandler(this.btngenerarkormo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 56);
            this.button2.TabIndex = 33;
            this.button2.Text = "Generar Montecarlo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 374);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btngenerarkormo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cantidadtxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x0Box);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnCuadrado);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cantidadtxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x0Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btngenerarkormo;
        private System.Windows.Forms.Button button2;
    }
}