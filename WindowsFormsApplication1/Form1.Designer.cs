namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLineal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.atxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctxtBox = new System.Windows.Forms.TextBox();
            this.x0Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cantidadtxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btngenerarchi = new System.Windows.Forms.Button();
            this.btngenerarkormo = new System.Windows.Forms.Button();
            this.btnMotecarlo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLineal
            // 
            this.btnLineal.Location = new System.Drawing.Point(218, 224);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(75, 23);
            this.btnLineal.TabIndex = 0;
            this.btnLineal.Text = "Lineal";
            this.btnLineal.UseVisualStyleBackColor = true;
            this.btnLineal.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(35, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "i";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Xi";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ui";
            this.Column3.Name = "Column3";
            // 
            // mtxtBox
            // 
            this.mtxtBox.Location = new System.Drawing.Point(106, 81);
            this.mtxtBox.Name = "mtxtBox";
            this.mtxtBox.Size = new System.Drawing.Size(100, 20);
            this.mtxtBox.TabIndex = 4;
            this.mtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "a";
            // 
            // atxtBox
            // 
            this.atxtBox.Location = new System.Drawing.Point(106, 130);
            this.atxtBox.Name = "atxtBox";
            this.atxtBox.Size = new System.Drawing.Size(100, 20);
            this.atxtBox.TabIndex = 6;
            this.atxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "c";
            // 
            // ctxtBox
            // 
            this.ctxtBox.Location = new System.Drawing.Point(106, 182);
            this.ctxtBox.Name = "ctxtBox";
            this.ctxtBox.Size = new System.Drawing.Size(100, 20);
            this.ctxtBox.TabIndex = 8;
            this.ctxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBox_KeyPress);
            // 
            // x0Box
            // 
            this.x0Box.Location = new System.Drawing.Point(399, 77);
            this.x0Box.Name = "x0Box";
            this.x0Box.Size = new System.Drawing.Size(100, 20);
            this.x0Box.TabIndex = 10;
            this.x0Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X0";
            // 
            // cantidadtxtBox
            // 
            this.cantidadtxtBox.Location = new System.Drawing.Point(399, 126);
            this.cantidadtxtBox.Name = "cantidadtxtBox";
            this.cantidadtxtBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadtxtBox.TabIndex = 14;
            this.cantidadtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad de Iteraciones";
            // 
            // btngenerarchi
            // 
            this.btngenerarchi.Location = new System.Drawing.Point(328, 438);
            this.btngenerarchi.Name = "btngenerarchi";
            this.btngenerarchi.Size = new System.Drawing.Size(92, 56);
            this.btngenerarchi.TabIndex = 29;
            this.btngenerarchi.Text = "Generar Chi Cuadrado";
            this.btngenerarchi.UseVisualStyleBackColor = true;
            this.btngenerarchi.Click += new System.EventHandler(this.btngenerarchi_Click);
            // 
            // btngenerarkormo
            // 
            this.btngenerarkormo.Location = new System.Drawing.Point(435, 438);
            this.btngenerarkormo.Name = "btngenerarkormo";
            this.btngenerarkormo.Size = new System.Drawing.Size(92, 56);
            this.btngenerarkormo.TabIndex = 30;
            this.btngenerarkormo.Text = "Generar Kolmogorov";
            this.btngenerarkormo.UseVisualStyleBackColor = true;
            this.btngenerarkormo.Click += new System.EventHandler(this.btngenerarkormo_Click);
            // 
            // btnMotecarlo
            // 
            this.btnMotecarlo.Location = new System.Drawing.Point(206, 438);
            this.btnMotecarlo.Name = "btnMotecarlo";
            this.btnMotecarlo.Size = new System.Drawing.Size(102, 56);
            this.btnMotecarlo.TabIndex = 31;
            this.btnMotecarlo.Text = "Generar Metodo Montecarlo";
            this.btnMotecarlo.UseVisualStyleBackColor = true;
            this.btnMotecarlo.Click += new System.EventHandler(this.btnMotecarlo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 537);
            this.Controls.Add(this.btnMotecarlo);
            this.Controls.Add(this.btngenerarkormo);
            this.Controls.Add(this.btngenerarchi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cantidadtxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x0Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.atxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLineal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox mtxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox atxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctxtBox;
        private System.Windows.Forms.TextBox x0Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cantidadtxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btngenerarchi;
        private System.Windows.Forms.Button btngenerarkormo;
        private System.Windows.Forms.Button btnMotecarlo;
    }
}

