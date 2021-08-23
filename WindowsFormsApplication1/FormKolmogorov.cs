using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication1
{
    public partial class FormKolmogorov : Form
    {
        public int cantidad;
        int numeroclases = 0;
        int vp = 0;
        int nivelconfianza = 0;
            
        public FormKolmogorov()
        {
            InitializeComponent();
        }

        private void gridChiDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void pruebauniformidad()
        {
            double sumas =Convert.ToDouble(gridKolmoDatos[6,0].Value.ToString());
            double valor = 0;
            int cont = 0;
            int cont1 = 0, cont2 = 0;
            for (cont = 0; cont < numeroclases; cont++)
            {
                valor = Convert.ToDouble(gridKolmoDatos[6, cont].Value.ToString());

                if (valor >= sumas)
                {
                    sumas = valor;
                }
            }

            for (cont1 = 1; cont1 < gridVKolmo.Rows.Count; cont1++)
            {
                if (numeroclases == Convert.ToInt32(gridVKolmo[0, cont1].Value.ToString()))
                {
                    vp = cont1;
                }
                if (cont1 == gridVKolmo.Rows.Count && (1 - (Convert.ToDouble(txtNivelConfianza.Text) / 100)) != Convert.ToInt32(gridVKolmo[cont1, 0].Value.ToString()))
                {
                    MessageBox.Show("No existe esa cantidad de numeros para la tabla");
                }
            }

            for (cont2 = 1; cont2 < gridVKolmo.Columns.Count; cont2++)
            {
                decimal confianza = (1 - (Convert.ToDecimal(txtNivelConfianza.Text) / 100));
                if (confianza == Convert.ToDecimal(gridVKolmo[cont2, 0].Value.ToString()))
                {
                    nivelconfianza = cont2;
                }
                if (cont2 == gridVKolmo.Columns.Count && confianza != Convert.ToDecimal(gridVKolmo[cont2, 0].Value.ToString()) && nivelconfianza == 0)
                {

                    MessageBox.Show("No existe ese nivel de confianza para la tabla");

                }
            }
            sumtxtBox.Text = sumas.ToString();
            gridVKolmo.CurrentCell = gridVKolmo[nivelconfianza, vp];
            gridVKolmo[nivelconfianza, vp].Style.BackColor = Color.Yellow;
            if (sumas <= Convert.ToDouble(gridVKolmo[nivelconfianza,vp].Value.ToString()))
            {
                txtUniformidad.Text = "Existe Uniformidad";
                txtUniformidad.BackColor = Color.Green;
            }
            else
            {
                txtUniformidad.Text = "No Existe Uniformidad";
                txtUniformidad.BackColor = Color.Red;
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string i = "";
            string valor = "";

            double p = 0;
            double division;


            if (grupostxtBox.Text == "")
            {
                MessageBox.Show("Inserte todos los valores");

            }

            else
            {
                numeroclases = Convert.ToInt32(grupostxtBox.Text);
                division = numeroclases;
                p = 1 / division;

                double[] clase = new double[numeroclases];
                double acumular = 0;
                double f0xi = 0;
                double f1xi = 0;
                for (cont = 0; cont < numeroclases; cont++)
                {
                    double nuevovalor;
                    
                    double sumarf1,sumarf0;
                    double nt = 0;
                    acumular = acumular + p;
                    clase[cont] = acumular;

                    string columna0, columna1 = "", columna2, columna3, columna4,columna5, columna6;
                    i = gridVDatos[0, cont].Value.ToString();

                    columna0 = gridVDatos[0, cont].Value.ToString();

                    gridVDatos[0, cont].Value = cont;
                    if (cont == 0)
                    {

                        columna1 = "[0," + acumular + ">";
                    }
                    if (cont > 0)
                    {
                        columna1 = "[" + clase[cont - 1] + "," + clase[cont] + ">";

                    }
                    int sumar = 0;
                    for (int cuenta = 0; cuenta < cantidad; cuenta++)
                    {


                        nuevovalor = Convert.ToDouble(gridVDatos[1, cuenta].Value.ToString());
                        if (nuevovalor < clase[cont] && cont == 0 && nuevovalor > 0)
                        {
                            sumar = sumar + 1;
                        }

                        if (cont > 0)
                        {
                            if (nuevovalor < clase[cont] && nuevovalor > clase[cont - 1])
                            {
                                sumar = sumar + 1;
                            }
                        }
                    }
                    columna2 = sumar.ToString();

                    sumarf0 = Convert.ToDouble(columna2) / cantidad;
                    f0xi = f0xi+sumarf0;
                    columna3 = f0xi.ToString();
                    nt = cantidad / Convert.ToDouble(grupostxtBox.Text);
                    columna4 = nt.ToString();
                    sumarf1 = Convert.ToDouble(columna4) / cantidad;
                    f1xi = f1xi + sumarf1;
                    columna5 = f1xi.ToString();
                    columna6 = (Math.Abs(Convert.ToDouble(columna3) - Convert.ToDouble(columna5))).ToString();


                    gridKolmoDatos.Rows.Add(Convert.ToInt32(columna0) + 1, columna1, columna2, columna3, columna4, columna5.ToString(), columna6);
                }
            }
            pruebauniformidad();
        }

        private void FormKolmogorov_Load(object sender, EventArgs e)
        {
            LLenarGrid();
        }
        private void LLenarGrid()
        {
            string archivo = "D:\\05_Tabla_Kolmogorov.xlsx";
            string hoja = "Sheet1";
            //declaramos las variables         
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            { 
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    gridVKolmo.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    gridVKolmo.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarArribaAbajo();
        }


        public void LlenarArribaAbajo()
        {
            FormArribayAbajo fm = new FormArribayAbajo();
            double n0 = 0, n1 = 0;
            int cont = 0;
            double ub = 0, ub2 = 0;
            double Z;
            int[] h = new int[cantidad + 1];
            double cantidadh = 0;
            int valor = 0;
            for (cont = 1; cont < gridVDatos.RowCount - 1; cont++)
            {
                if (Convert.ToDouble(gridVDatos[1, cont].Value.ToString()) < 0.5)
                {
                    n0++;
                    h[cont] = 0;
                }
                else
                {
                    n1++;
                    h[cont] = 1;
                }

                if (valor > h[cont] || valor < h[cont])
                {
                    cantidadh++;
                }
            }
            fm.N0txtBox.Text = n0.ToString();
            fm.N1txtBox.Text = n1.ToString();
            ub = ((2 * n0 * n1) / (cantidad)) + (1 / 2);
            ub2 = (((2 * n0 * n1) * ((2 * n0 * n1) - cantidad))) / (Math.Pow(Convert.ToDouble(cantidad), 2) * (cantidad - 1));
            Z = (cantidadh - ub) / (Math.Sqrt(ub2));
            fm.mediatxtBox.Text = ub.ToString();
            fm.varianzatxtBox.Text = ub2.ToString();
            fm.ZtxtBox.Text = Z.ToString();
           

            if (Z < Convert.ToDouble(gridVKolmo[(nivelconfianza +1),vp ].Value.ToString()))
            {
                fm.label6.ForeColor = Color.Green;
                fm.label6.Text = "Es Independiente";

            }
            else
            {
                fm.label6.ForeColor = Color.Red;
                fm.label6.Text = "No es Independiente";
            }

            fm.ShowDialog();
        }



        public void LlenarAscendenteyDescendente()
        {
            FormAscendenteyDescendente fm = new FormAscendenteyDescendente();
            double bi0 = 0, bi1 = 0;
            int cont = 0;
            double Eh = 0, Vh = 0;
            double Z;
            int[] h = new int[cantidad + 1];
            double cantidadh = 0;
            int valor = 0;
            for (cont = 0; cont < gridVDatos.RowCount - 2; cont++)
            {
                if (Convert.ToDouble(gridVDatos[1, cont].Value.ToString()) <= Convert.ToDouble(gridVDatos[1, cont + 1].Value.ToString()))
                {
                    bi0++;
                    h[cont] = 1;
                }
                else
                {
                    bi1++;
                    h[cont] = 0;
                }

                if (valor > h[cont] || valor < h[cont])
                {
                    cantidadh++;
                }
            }
            Eh = ((2 * (cantidad - 1)) / 3);
            Vh = ((16 * (cantidad - 29)) / 90);
            Z = (cantidadh - Eh) / (Math.Sqrt(Vh));
            fm.EhtxtBox.Text = Eh.ToString();
            fm.VhtxtBox.Text = Vh.ToString();
            fm.ZtxtBox.Text = Z.ToString();

            if (Z < Convert.ToDouble(gridKolmoDatos[vp, (nivelconfianza / 2)].Value.ToString()))
            {
                fm.label6.ForeColor = Color.Green;
                fm.label6.Text = "Es Independiente";

            }
            else
            {
                fm.label6.ForeColor = Color.Red;
                fm.label6.Text = "No es Independiente";
            }

            fm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LlenarAscendenteyDescendente();
        }

        private void grupostxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (grupostxtBox == sender)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }


            if (sumtxtBox == sender)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }



            if (txtNivelConfianza == sender)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }

        }

        private void grupostxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNivelConfianza_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void btnPoker_Click(object sender, EventArgs e)
        {
            if (numeroclases == 13)
            {
                FormTestPoker fm = new FormTestPoker();
                fm.cantidad = Convert.ToInt32(cantidad);
                int cont = 0;
                string i = "", numero = "", valor = "";

                double campo = 0.076923;


                double[] clase = new double[numeroclases];


                for (cont = 0; cont < cantidad; cont++)
                {
#region Darvalor
                    i = gridVDatos[0, cont].Value.ToString();
                    numero = gridVDatos[1, cont].Value.ToString();
                    if (Convert.ToDouble(numero) < campo)
                    {
                        valor = "A";
                    }
                    if (campo <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 2)
                    {
                        valor = "2";
                    }
                    if (campo * 2 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 3)
                    {
                        valor = "3";
                    }
                    if (campo * 3 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 4)
                    {
                        valor = "4";
                    }
                    if (campo * 4 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 5)
                    {
                        valor = "5";
                    }
                    if (campo * 5 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 6)
                    {
                        valor = "6";
                    }
                    if (campo * 6 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 7)
                    {
                        valor = "7";
                    }
                    if (campo * 7 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 8)
                    {
                        valor = "8";
                    }
                    if (campo * 8 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 9)
                    {
                        valor = "9";
                    }
                    if (campo * 9 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 10)
                    {
                        valor = "10";
                    }
                    if (campo * 10 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 11)
                    {
                        valor = "J";
                    }
                    if (campo * 11 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 12)
                    {
                        valor = "Q";
                    }
                    if (campo * 12 <= Convert.ToDouble(numero) && Convert.ToDouble(numero) < campo * 13)
                    {
                        valor = "K";
                    }
#endregion
                    fm.gridDatosPoker.Rows.Add(i, numero, valor);
                }

                int contcantidad = 0;
                string descripcion = "";
                for (cont = 0; cont < cantidad; cont = cont + 5)
                {
                    string columna1, columna2, columna3, columna4, columna5;
                    if (cont <= cantidad - 5)
                    {
                        columna1 = fm.gridDatosPoker[2, cont].Value.ToString();
                        columna2 = fm.gridDatosPoker[2, cont + 1].Value.ToString();
                        columna3 = fm.gridDatosPoker[2, cont + 2].Value.ToString();
                        columna4 = fm.gridDatosPoker[2, cont + 3].Value.ToString();
                        columna5 = fm.gridDatosPoker[2, cont + 4].Value.ToString();
                        if (columna1 != columna2 && columna2 != columna3 && columna3 != columna4 && columna4 != columna5 && columna1 != columna5)
                        {
                            descripcion = "TODOS DIFERENTES";

                        }


                        if (columna1 == columna2 || columna1 == columna3 || columna1 == columna4 || columna1 == columna5
                            || columna2 == columna3 || columna2 == columna4 || columna2 == columna5
                            || columna3 == columna4 || columna3 == columna5 || columna4 == columna5)
                        {
                            descripcion = "1 PAR";

                        }

                        if ((columna1 == columna2 && columna3 == columna4) || (columna1 == columna2 && columna3 == columna5)
                            || (columna1 == columna2 && columna4 == columna5) || (columna1 == columna3 && columna4 == columna5)
                            || (columna1 == columna3 && columna2 == columna5) || (columna1 == columna3 && columna2 == columna4)
                            || (columna1 == columna4 && columna2 == columna3) || (columna1 == columna4 && columna2 == columna5)
                            || (columna1 == columna4 && columna3 == columna5) || (columna1 == columna5 && columna2 == columna3)
                            || (columna1 == columna5 && columna2 == columna4) || (columna1 == columna5 && columna3 == columna4))
                        {
                            descripcion = "2 PARES";

                        }


                        if ((columna1 == columna2 && columna1 == columna3) || (columna1 == columna3 && columna1 == columna4)
                            || (columna1 == columna4 && columna1 == columna5) || (columna2 == columna3 && columna2 == columna4)
                            || (columna2 == columna4 && columna2 == columna5) || (columna3 == columna4 && columna4 == columna5)
                            || (columna1 == columna3 && columna1 == columna5))
                        {
                            descripcion = "TRIO";

                        }


                        if ((columna1 == columna2 && columna1 == columna3 && columna4 == columna5) || (columna1 == columna3 && columna1 == columna4 && columna2 == columna5)
                            || (columna1 == columna4 && columna1 == columna5 && columna2 == columna3) || (columna2 == columna3 && columna2 == columna4 && columna1 == columna5)
                            || (columna2 == columna4 && columna2 == columna5 && columna1 == columna3) || (columna3 == columna4 && columna4 == columna5 && columna1 == columna2)
                            || (columna1 == columna3 && columna1 == columna5 && columna2 == columna4))
                        {
                            descripcion = "FULL";

                        }


                        if ((columna1 == columna2 && columna2 == columna3 && columna3 == columna4)
                            || (columna2 == columna3 && columna2 == columna4 && columna2 == columna5)
                            || (columna1 == columna2 && columna1 == columna4 && columna1 == columna5)
                            || (columna1 == columna2 && columna1 == columna3 && columna1 == columna5))
                        {

                            descripcion = "POKER";
                        }


                        if (columna1 == columna2 && columna2 == columna3 && columna3 == columna4 && columna4 == columna5)
                        {

                            descripcion = "QUINTILLA";
                        }

                        contcantidad++;
                        fm.gridManos.Rows.Add(contcantidad, columna1, columna2, columna3, columna4, columna5, descripcion);
                    }

                    else
                    {
                        break;
                    }


                }


                #region COLOR

                for (cont = 0; cont < (cantidad / 5); cont++)
                {
                    fm.gridManos[0, cont].Style.BackColor = Color.Red;
                    fm.gridManos[1, cont].Style.ForeColor = Color.Blue;
                    fm.gridManos[2, cont].Style.ForeColor = Color.Blue;
                    fm.gridManos[3, cont].Style.ForeColor = Color.Red;
                    fm.gridManos[4, cont].Style.ForeColor = Color.Red;
                    fm.gridManos[5, cont].Style.ForeColor = Color.Red;

                }

                for (cont = 0; cont < cantidad; cont = cont + 5)
                {
                    if ((cont % 10) == 0)
                    {
                        fm.gridDatosPoker[0, cont].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[1, cont].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[2, cont].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[0, cont + 1].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[1, cont + 1].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[2, cont + 1].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[0, cont + 2].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[1, cont + 2].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[2, cont + 2].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[0, cont + 3].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[1, cont + 3].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[2, cont + 3].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[0, cont + 4].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[1, cont + 4].Style.ForeColor = Color.DarkGreen;
                        fm.gridDatosPoker[2, cont + 4].Style.ForeColor = Color.DarkGreen;



                    }
                    else
                    {
                        fm.gridDatosPoker[0, cont].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[1, cont].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[2, cont].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[0, cont + 1].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[1, cont + 1].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[2, cont + 1].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[0, cont + 2].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[1, cont + 2].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[2, cont + 2].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[0, cont + 3].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[1, cont + 3].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[2, cont + 3].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[0, cont + 4].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[1, cont + 4].Style.ForeColor = Color.DarkOrange;
                        fm.gridDatosPoker[2, cont + 4].Style.ForeColor = Color.DarkOrange;
                    }

                }
                #endregion

                //DESCRIPCION CARTA
                double cantidadtrio = 0, cantidadquintilla = 0, cantidadpoker = 0, cantidadfull = 0, cantidadpar = 0, cantidad2par = 0, cantidadtdf = 0;
                for (cont = 0; cont < (cantidad / 5); cont++)
                {
                    if (fm.gridManos[6, cont].Value.ToString() == "TODOS DIFERENTES")
                    { cantidadtdf++; }
                    if (fm.gridManos[6, cont].Value.ToString() == "1 PAR")
                    { cantidadpar++; }
                    if (fm.gridManos[6, cont].Value.ToString() == "2 PARES")
                    { cantidad2par++; }
                    if (fm.gridManos[6, cont].Value.ToString() == "TRIO")
                    { cantidadtrio++; }
                    if (fm.gridManos[6, cont].Value.ToString() == "FULL")
                    { cantidadfull++; }
                    if (fm.gridManos[6, cont].Value.ToString() == "POKER")
                    { cantidadpoker++; }
                    if (fm.gridManos[6, cont].Value.ToString() == "QUINTILLA")
                    { cantidadquintilla++; }
                }
                fm.txtprobpoker.Text = ((cantidadpoker / (cantidad / 5)) * 100).ToString();
                fm.txtprob2par.Text = ((cantidad2par / (cantidad / 5)) * 100).ToString();
                fm.txtprobpar.Text = ((cantidadpar / (cantidad / 5)) * 100).ToString();
                fm.txtprobtrio.Text = ((cantidadtrio / (cantidad / 5)) * 100).ToString();
                fm.txtprobfull.Text = ((cantidadfull / (cantidad / 5)) * 100).ToString();
                fm.txtprobquintilla.Text = ((cantidadquintilla / (cantidad / 5)) * 100).ToString();
                

                fm.ShowDialog();
            }
              else
            { MessageBox.Show("No se pudo generar el test de poker debido a que el numero de clases es diferente a 13", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
    }
}
