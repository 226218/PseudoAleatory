namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.cantidadtxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x0Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.atxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btngenerarchi = new System.Windows.Forms.Button();
            this.btngenerarkormo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cantidad de Iteraciones";
            // 
            // cantidadtxtBox
            // 
            this.cantidadtxtBox.Location = new System.Drawing.Point(346, 72);
            this.cantidadtxtBox.Name = "cantidadtxtBox";
            this.cantidadtxtBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadtxtBox.TabIndex = 24;
            this.cantidadtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "X0";
            // 
            // x0Box
            // 
            this.x0Box.Location = new System.Drawing.Point(346, 23);
            this.x0Box.Name = "x0Box";
            this.x0Box.Size = new System.Drawing.Size(100, 20);
            this.x0Box.TabIndex = 22;
            this.x0Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "c";
            // 
            // ctxtBox
            // 
            this.ctxtBox.Location = new System.Drawing.Point(53, 128);
            this.ctxtBox.Name = "ctxtBox";
            this.ctxtBox.Size = new System.Drawing.Size(100, 20);
            this.ctxtBox.TabIndex = 20;
            this.ctxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "a";
            // 
            // atxtBox
            // 
            this.atxtBox.Location = new System.Drawing.Point(53, 76);
            this.atxtBox.Name = "atxtBox";
            this.atxtBox.Size = new System.Drawing.Size(100, 20);
            this.atxtBox.TabIndex = 18;
            this.atxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "m";
            // 
            // mtxtBox
            // 
            this.mtxtBox.Location = new System.Drawing.Point(53, 27);
            this.mtxtBox.Name = "mtxtBox";
            this.mtxtBox.Size = new System.Drawing.Size(100, 20);
            this.mtxtBox.TabIndex = 16;
            this.mtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBox_KeyPress);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(53, 169);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(346, 150);
            this.dataGridView2.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "i";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Xi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ui";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(292, 121);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(107, 23);
            this.btnMulti.TabIndex = 27;
            this.btnMulti.Text = "Multiplicativo";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btngenerarchi
            // 
            this.btngenerarchi.Location = new System.Drawing.Point(350, 333);
            this.btngenerarchi.Name = "btngenerarchi";
            this.btngenerarchi.Size = new System.Drawing.Size(92, 56);
            this.btngenerarchi.TabIndex = 28;
            this.btngenerarchi.Text = "Generar Chi Cuadrado";
            this.btngenerarchi.UseVisualStyleBackColor = true;
            this.btngenerarchi.Click += new System.EventHandler(this.btngenerarchi_Click);
            // 
            // btngenerarkormo
            // 
            this.btngenerarkormo.Location = new System.Drawing.Point(452, 333);
            this.btngenerarkormo.Name = "btngenerarkormo";
            this.btngenerarkormo.Size = new System.Drawing.Size(92, 56);
            this.btngenerarkormo.TabIndex = 31;
            this.btngenerarkormo.Text = "Generar Kolmogorov";
            this.btngenerarkormo.UseVisualStyleBackColor = true;
            this.btngenerarkormo.Click += new System.EventHandler(this.btngenerarkormo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 56);
            this.button1.TabIndex = 32;
            this.button1.Text = "Generar Montecarlo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngenerarkormo);
            this.Controls.Add(this.btngenerarchi);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.dataGridView2);
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
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cantidadtxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x0Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox atxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mtxtBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btngenerarchi;
        private System.Windows.Forms.Button btngenerarkormo;
        private System.Windows.Forms.Button button1;
    }
}