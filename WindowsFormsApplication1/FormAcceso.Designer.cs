namespace WindowsFormsApplication1
{
    partial class FormAcceso
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
            this.btnLineal = new System.Windows.Forms.Button();
            this.btnMultiplicativo = new System.Windows.Forms.Button();
            this.btnMedios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLineal
            // 
            this.btnLineal.Location = new System.Drawing.Point(36, 46);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(135, 23);
            this.btnLineal.TabIndex = 0;
            this.btnLineal.Text = "Congruencias &Lineales";
            this.btnLineal.UseVisualStyleBackColor = true;
            this.btnLineal.Click += new System.EventHandler(this.btnLineal_Click);
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.Location = new System.Drawing.Point(194, 46);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(150, 23);
            this.btnMultiplicativo.TabIndex = 1;
            this.btnMultiplicativo.Text = "Congruencia M&ultiplicativa";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMultiplicativo.Click += new System.EventHandler(this.btnMultiplicativo_Click);
            // 
            // btnMedios
            // 
            this.btnMedios.Location = new System.Drawing.Point(97, 90);
            this.btnMedios.Name = "btnMedios";
            this.btnMedios.Size = new System.Drawing.Size(176, 23);
            this.btnMedios.TabIndex = 2;
            this.btnMedios.Text = "Cuadrados &Medios";
            this.btnMedios.UseVisualStyleBackColor = true;
            this.btnMedios.Click += new System.EventHandler(this.btnMedios_Click);
            // 
            // FormAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 122);
            this.Controls.Add(this.btnMedios);
            this.Controls.Add(this.btnMultiplicativo);
            this.Controls.Add(this.btnLineal);
            this.Name = "FormAcceso";
            this.Text = "FormAcceso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.Button btnMultiplicativo;
        private System.Windows.Forms.Button btnMedios;
    }
}