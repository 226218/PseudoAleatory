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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            int compa = 0;


            if (x0Box.Text != "" && cantidadtxtBox.Text != "" && Convert.ToInt32(cantidadtxtBox.Text) > 0 && Convert.ToDouble(x0Box.Text) > 0)
            {


                int X0 = Convert.ToInt16(x0Box.Text);
                double Xi = Convert.ToDouble(x0Box.Text);
                int veces = Convert.ToInt32(cantidadtxtBox.Text);
                double Xi2, CM = 1, Ui;
                string CM2 = "";

                for (int i = 0; i <= veces; i++)
                {
                    Xi2 = Math.Pow(Xi, 2);
                    if (Xi2.ToString().Length <= 4)
                    {
                        CM = Convert.ToDouble(Xi2.ToString());

                        if (Xi2.ToString().Length == 1)
                        { CM2 = "(000" + Xi2.ToString() + ")"; }
                        if (Xi2.ToString().Length == 2)
                        { CM2 = "(00" + Xi2.ToString() + ")"; }
                        if (Xi2.ToString().Length == 3)
                        { CM2 = "(0" + Xi2.ToString() + ")"; }
                        if (Xi2.ToString().Length == 4)
                        { CM2 = "(" + Xi2.ToString() + ")"; }
                    }
                    if (Xi2.ToString().Length == 5)
                    {
                        CM = Convert.ToDouble(Xi2.ToString().Remove(4));
                        CM2 = "0(" + Xi2.ToString().Remove(4) + ")" + Xi2.ToString().Remove(0, 4);
                    }
                    if (Xi2.ToString().Length == 6)
                    {
                        CM = Convert.ToDouble((Xi2.ToString().Remove(5)).Remove(0, 1));
                        CM2 = Xi2.ToString().Remove(1) + "(" + (Xi2.ToString().Remove(5)).Remove(0, 1) + ")" + Xi2.ToString().Remove(0, 5);
                    }
                    if (Xi2.ToString().Length == 7)
                    {
                        CM = Convert.ToDouble((Xi2.ToString().Remove(5)).Remove(0, 1));
                        CM2 = "0" + Xi2.ToString().Remove(1) + "(" + (Xi2.ToString().Remove(5)).Remove(0, 1) + ")" + Xi2.ToString().Remove(0, 5);
                    }
                    if (Xi2.ToString().Length == 8)
                    {
                        CM = Convert.ToDouble((Xi2.ToString().Remove(6)).Remove(0, 2));
                        CM2 = Xi2.ToString().Remove(2) + "(" + (Xi2.ToString().Remove(6)).Remove(0, 2) + ")" + Xi2.ToString().Remove(0, 6);
                    }

                    Ui = CM / 10000;
                    dataGridView3.Rows.Add(i, Xi, Xi2, CM2, Ui);
                    Xi = CM;

                    if (i == 0 && compa == 0)
                    {
                        int auxiliar = 0;
                        if (auxiliar == Xi2)
                        {
                            MessageBox.Show("El periodo se repite cada " + i + " veces");
                            compa = 1;
                        }
                        else
                        {
                            MessageBox.Show("EL periodo no se repite");
                        }

                    }


                }

            }
        }
        public void Llenarchi()
        {

            FormChi fm = new FormChi();
            fm.cantidad = Convert.ToInt32(cantidadtxtBox.Text);
            int cont = 0;
            string i = "", valor = "";

            for (cont = 0; cont <= fm.cantidad; cont++)
            {

                i = dataGridView3[0, cont].Value.ToString();
                valor = dataGridView3[4, cont].Value.ToString();
                fm.gridVDatos.Rows.Add(i, valor);
            }



            fm.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Llenarchi();
        }


        public void Llenarkol()
        {

            FormKolmogorov fm = new FormKolmogorov();
            fm.cantidad = Convert.ToInt32(cantidadtxtBox.Text);
            int cont = 0;
            string i = "", valor = "";

            for (cont = 0; cont <= fm.cantidad; cont++)
            {
                i = dataGridView3[0, cont].Value.ToString();
                valor = dataGridView3[4, cont].Value.ToString();
                fm.gridVDatos.Rows.Add(i, valor);
            }



            fm.ShowDialog();


        }
        private void btngenerarkormo_Click(object sender, EventArgs e)
        {
            Llenarkol();
        }

        private void x0Box_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (cantidadtxtBox == sender)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }

            if (x0Box == sender)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMontecarlo fm = new FormMontecarlo();
            fm.cantidad = Convert.ToInt32(cantidadtxtBox.Text);
            int cont = 0;
            string i = "", numero = "", valor = "";

            double arco = 1.570796326;
            double acertado = 0, fallo = 0;

            double[] clase = new double[2];
            double x = 0, y = 0;

            for (cont = 0; cont < fm.cantidad; cont++)
            {

                i = dataGridView3[0, cont].Value.ToString();
                if ((cont % 2) == 0)
                {
                    x = Convert.ToDouble(dataGridView3[2, cont].Value.ToString());
                    cont++;
                    y = Convert.ToDouble(dataGridView3[2, cont].Value.ToString());
                    if ((x + y) <= arco)
                    {
                        valor = "Dentro";

                    }
                    if ((x + y) > arco)
                    {
                        valor = "Fuera";
                    }

                    fm.gridDatosMontecarlo.Rows.Add(i, "[" + x + "," + y + "]", valor);

                }

            }
            for (cont = 0; cont < ((fm.cantidad) / 2); cont++)
            {
                if (fm.gridDatosMontecarlo[2, cont].Value.ToString() == "Dentro")
                {
                    fm.gridDatosMontecarlo[2, cont].Style.ForeColor = Color.Green;

                }
                else
                { fm.gridDatosMontecarlo[2, cont].Style.ForeColor = Color.Red; }
            }
            for (cont = 0; cont < ((fm.cantidad) / 2); cont++)
            {
                if (fm.gridDatosMontecarlo[2, cont].Value.ToString() == "Dentro")
                {
                    acertado++;
                }
                else

                { fallo++; }

            }
            double total = (acertado / (fm.cantidad / 2)) * 4;
            fm.textBox1.Text = total.ToString();
            fm.textBox2.Text = acertado.ToString();
            fm.textBox3.Text = fallo.ToString();
            fm.ShowDialog();
        }
    }
}