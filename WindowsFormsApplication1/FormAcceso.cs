using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormAcceso : Form
    {
        public FormAcceso()
        {
            InitializeComponent();
        }

        private void btnLineal_Click(object sender, EventArgs e)
        {
            Form1 lin = new Form1();
            lin.ShowDialog();
        }

        private void btnMultiplicativo_Click(object sender, EventArgs e)
        {
            Form2 mul = new Form2();
            mul.ShowDialog();
        }

        private void btnMedios_Click(object sender, EventArgs e)
        {
            Form3 cuadr = new Form3();
            cuadr.ShowDialog();
        }


    }
}
