namespace WindowsFormsApplication1
{
    partial class FormArribayAbajo
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
            this.label2 = new System.Windows.Forms.Label();
            this.N0txtBox = new System.Windows.Forms.TextBox();
            this.N1txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mediatxtBox = new System.Windows.Forms.TextBox();
            this.varianzatxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ZtxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N°1";
            // 
            // N0txtBox
            // 
            this.N0txtBox.Location = new System.Drawing.Point(82, 26);
            this.N0txtBox.Name = "N0txtBox";
            this.N0txtBox.Size = new System.Drawing.Size(100, 20);
            this.N0txtBox.TabIndex = 2;
            // 
            // N1txtBox
            // 
            this.N1txtBox.Location = new System.Drawing.Point(282, 26);
            this.N1txtBox.Name = "N1txtBox";
            this.N1txtBox.Size = new System.Drawing.Size(100, 20);
            this.N1txtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Media";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Varianza";
            // 
            // mediatxtBox
            // 
            this.mediatxtBox.Location = new System.Drawing.Point(82, 77);
            this.mediatxtBox.Name = "mediatxtBox";
            this.mediatxtBox.Size = new System.Drawing.Size(100, 20);
            this.mediatxtBox.TabIndex = 6;
            // 
            // varianzatxtBox
            // 
            this.varianzatxtBox.Location = new System.Drawing.Point(282, 77);
            this.varianzatxtBox.Name = "varianzatxtBox";
            this.varianzatxtBox.Size = new System.Drawing.Size(100, 20);
            this.varianzatxtBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Z";
            // 
            // ZtxtBox
            // 
            this.ZtxtBox.Location = new System.Drawing.Point(159, 141);
            this.ZtxtBox.Name = "ZtxtBox";
            this.ZtxtBox.Size = new System.Drawing.Size(100, 20);
            this.ZtxtBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // FormArribayAbajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 305);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ZtxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.varianzatxtBox);
            this.Controls.Add(this.mediatxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.N1txtBox);
            this.Controls.Add(this.N0txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormArribayAbajo";
            this.Text = "FormArribayAbajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox N0txtBox;
        public System.Windows.Forms.TextBox N1txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox mediatxtBox;
        public System.Windows.Forms.TextBox varianzatxtBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox ZtxtBox;
        public System.Windows.Forms.Label label6;
    }
}