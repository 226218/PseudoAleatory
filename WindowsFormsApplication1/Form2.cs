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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();


            if (cantidadtxtBox.Text == "" && mtxtBox.Text == "" && atxtBox.Text == "" && ctxtBox.Text == "" && x0Box.Text == "")
            {
                MessageBox.Show("Inserte todos los valores");

            }

            else
            {

                int cantidad = Convert.ToInt32(cantidadtxtBox.Text);
                int cont = 0;
                int i = 0;
                double[] Xi = new double[cantidad + 1];
                double ui;
                double m = Convert.ToDouble(mtxtBox.Text);
                int a = Convert.ToInt32(atxtBox.Text);
                int c = 0;
                double comparacion = 0;
                int periodo = 0;
                double x0 = Convert.ToDouble(x0Box.Text);

                if (x0 < m && x0 > 0 && m > 0 && a > 0 && m > a && m > c && x0 < m)
                {
                    for (cont = 0; cont < cantidad; cont++)
                    {
                        i = cont;
                        if (cont == 0)
                        {
                            Xi[cont] = Convert.ToDouble(x0Box.Text);
                            ui = (Xi[cont] / m);
                            comparacion = Xi[cont];
                            dataGridView2.Rows.Add(i, Xi[cont], ui);
                        }

                        else
                        {
                            Xi[cont] = ((a * Xi[cont - 1]) + c) % m;
                            ui = (Xi[cont] / m);
                            dataGridView2.Rows.Add(i, Xi[cont], ui);

                        }


                        if (comparacion == Xi[cont] && cont > 0 && periodo == 0)
                        {
                            periodo = cont;

                        }

                    }

                    MessageBox.Show("El periodo se repite cada " + periodo + "numeros");
                }


                else
                {
                    MessageBox.Show("0<Xi<m,0<m,0<a,0<m,a<m,c<m,x0<m");
                }
            }
        }





        public void Llenarchi()
        {

            FormChi fm = new FormChi();
            fm.cantidad = Convert.ToInt32(cantidadtxtBox.Text);
            int cont = 0;
            string i = "", valor = "";

            for (cont = 0; cont < fm.cantidad; cont++)
            {
                i = dataGridView2[0, cont].Value.ToString();
                valor = dataGridView2[2, cont].Value.ToString();
                fm.gridVDatos.Rows.Add(i, valor);
            }

           

            fm.ShowDialog();

            
        }


        public void Llenarkol()
        {

            FormKolmogorov fm = new FormKolmogorov();
            fm.cantidad = Convert.ToInt32(cantidadtxtBox.Text);
            int cont = 0;
            string i = "", valor = "";

            for (cont = 0; cont < fm.cantidad; cont++)
            {
                i = dataGridView2[0, cont].Value.ToString();
                valor = dataGridView2[2, cont].Value.ToString();
                fm.gridVDatos.Rows.Add(i, valor);
            }



            fm.ShowDialog();


        }



        private void btngenerarchi_Click(object sender, EventArgs e)
        {
            Llenarchi();

        }

        private void btngenerarkormo_Click(object sender, EventArgs e)
        {
            Llenarkol();
        }

        private void mtxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (mtxtBox == sender)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }


            if (atxtBox == sender)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }


            if (ctxtBox == sender)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            FormMontecarlo fm = new FormMontecarlo();
            fm.cantidad = Convert.ToInt32(cantidadtxtBox.Text);
            int cont = 0;
            string i = "", numero = "", valor = "";

            double arco = (Math.PI/4)*2;
            double acertado = 0, fallo = 0;

            double[] clase = new double[2];
            double x = 0, y = 0;

            for (cont = 0; cont < fm.cantidad; cont++)
            {

                i = dataGridView2[0, cont].Value.ToString();
                if ((cont % 2) == 0)
                {
                    x = Convert.ToDouble(dataGridView2[2, cont].Value.ToString());
                    cont++;
                    y = Convert.ToDouble(dataGridView2[2, cont].Value.ToString());
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
