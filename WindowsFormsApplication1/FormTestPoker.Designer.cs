namespace WindowsFormsApplication1
{
    partial class FormTestPoker
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
            this.gridManos = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDatosPoker = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprobpoker = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtprobpar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtprob2par = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtprobfull = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtprobtrio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtprobquintilla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridManos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatosPoker)).BeginInit();
            this.SuspendLayout();
            // 
            // gridManos
            // 
            this.gridManos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridManos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.gridManos.Location = new System.Drawing.Point(12, 209);
            this.gridManos.Name = "gridManos";
            this.gridManos.Size = new System.Drawing.Size(850, 150);
            this.gridManos.TabIndex = 1;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "N° Mano";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Carta 1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Carta 2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dealer 1";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dealer 2";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dealer 3";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Descripcion";
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // gridDatosPoker
            // 
            this.gridDatosPoker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatosPoker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gridDatosPoker.Location = new System.Drawing.Point(21, 12);
            this.gridDatosPoker.Name = "gridDatosPoker";
            this.gridDatosPoker.Size = new System.Drawing.Size(344, 150);
            this.gridDatosPoker.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "i";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ui";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor Carta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROBABILIDAD DE POKER EN LAS MANOS";
            // 
            // txtprobpoker
            // 
            this.txtprobpoker.Location = new System.Drawing.Point(245, 372);
            this.txtprobpoker.Name = "txtprobpoker";
            this.txtprobpoker.ReadOnly = true;
            this.txtprobpoker.Size = new System.Drawing.Size(100, 20);
            this.txtprobpoker.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(16, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "%";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 405);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(16, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "%";
            // 
            // txtprobpar
            // 
            this.txtprobpar.Location = new System.Drawing.Point(245, 405);
            this.txtprobpar.Name = "txtprobpar";
            this.txtprobpar.ReadOnly = true;
            this.txtprobpar.Size = new System.Drawing.Size(100, 20);
            this.txtprobpar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PROBABILIDAD DE PAR  EN LAS MANOS";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(737, 372);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(16, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "%";
            // 
            // txtprob2par
            // 
            this.txtprob2par.Location = new System.Drawing.Point(631, 401);
            this.txtprob2par.Name = "txtprob2par";
            this.txtprob2par.ReadOnly = true;
            this.txtprob2par.Size = new System.Drawing.Size(100, 20);
            this.txtprob2par.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "PROBABILIDAD DE FULL EN LAS MANOS";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(737, 402);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(16, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "%";
            // 
            // txtprobfull
            // 
            this.txtprobfull.Location = new System.Drawing.Point(631, 372);
            this.txtprobfull.Name = "txtprobfull";
            this.txtprobfull.ReadOnly = true;
            this.txtprobfull.Size = new System.Drawing.Size(100, 20);
            this.txtprobfull.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "PROBABILIDAD DE 2 PAR  EN LAS MANOS";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(354, 436);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(16, 20);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "%";
            // 
            // txtprobtrio
            // 
            this.txtprobtrio.Location = new System.Drawing.Point(248, 436);
            this.txtprobtrio.Name = "txtprobtrio";
            this.txtprobtrio.ReadOnly = true;
            this.txtprobtrio.Size = new System.Drawing.Size(100, 20);
            this.txtprobtrio.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "PROBABILIDAD DE TRIO  EN LAS MANOS";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(756, 436);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(16, 20);
            this.textBox8.TabIndex = 20;
            this.textBox8.Text = "%";
            // 
            // txtprobquintilla
            // 
            this.txtprobquintilla.Location = new System.Drawing.Point(650, 436);
            this.txtprobquintilla.Name = "txtprobquintilla";
            this.txtprobquintilla.ReadOnly = true;
            this.txtprobquintilla.Size = new System.Drawing.Size(100, 20);
            this.txtprobquintilla.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "PROBABILIDAD DE QUINTILLA EN LAS MANOS";
            // 
            // FormTestPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtprobquintilla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtprobtrio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtprobfull);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtprob2par);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtprobpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtprobpoker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDatosPoker);
            this.Controls.Add(this.gridManos);
            this.Name = "FormTestPoker";
            this.Text = "FormTestPoker";
            this.Load += new System.EventHandler(this.FormTestPoker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridManos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatosPoker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridView gridManos;
        public System.Windows.Forms.DataGridView gridDatosPoker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtprobpoker;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox txtprobpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox txtprob2par;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox txtprobfull;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox txtprobtrio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.TextBox txtprobquintilla;
        private System.Windows.Forms.Label label6;
    }
}