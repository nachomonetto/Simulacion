using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Banco
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            dgv.Visible = false;

            //DataGridViewColumn columnaRndMontecarlo = new DataGridViewColumn();
            //columnaRndMontecarlo.HeaderText = ("RND Montecarlo");
            //columnaRndMontecarlo.Name = ("columnaRndMontecarlo");
            //columnaRndMontecarlo.CellTemplate = new DataGridViewRowHeaderCell();
            //DataGridViewColumn columnaADonde = new DataGridViewColumn();
            //columnaADonde.HeaderText = ("A donde va?");
            //columnaRndMontecarlo.Name = ("columnaADonde");
            //columnaRndMontecarlo.CellTemplate = new DataGridViewRowHeaderCell();

            //dgv.Columns.Insert(5, columnaRndMontecarlo);
            //dgv.Columns.Insert(6, columnaADonde);
        }

        private void txtBoxFrecuencia_KeyPress(object sender, KeyPressEventArgs e) 
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }

        }
       

        private void txtBoxMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtBoxMedia.Text.Length; i++)
            {
                if (txtBoxMedia.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void txtBoxMedia_TextChanged(object sender, EventArgs e)
        {
           
        }
       

        private void txtBoxA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxA_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtBoxA.Text.Length; i++)
            {
                if (txtBoxA.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }


        private void txtBoxB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtBoxB.Text.Length; i++)
            {
                if (txtBoxB.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }
        

        private void txtBoxSimular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtBoxSimular.Text.Length; i++)
            {
                if (txtBoxSimular.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
        public int idCliente = 1;
        public float valor1;
        public float valor2;
        public float valor3;
        public float pintar;
        public int cola1;
        public int cola2;
        public decimal variable1;
        public decimal variable2;
        public decimal variable3;
        public decimal comparar;
        public decimal montecarlo;
        public float anchoColumnas=0;

        public int eliminarClientes=0;
        public int tirada = 0;
        //private void dgv_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        //{
        //    e.Column.FillWeight = 10;    // <<this line will help you
        //}

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (txtBoxA.Text=="" || txtBoxB.Text=="" || txtBoxFrecuencia.Text=="" || txtBoxMedia.Text=="" || txtBoxSimular.Text=="")
            {
                
                if (txtBoxFrecuencia.Text == "")
                {
                    txtBoxFrecuencia.Focus();
                    
                }
                else
                {
                    if (txtBoxMedia.Text=="")
                    {
                        txtBoxMedia.Focus();
                    }
                    else
                    {
                        if (txtBoxA.Text=="")
                        {
                            txtBoxA.Focus();
                        }
                        else
                        {
                            if (txtBoxB.Text=="")
                            {
                                txtBoxB.Focus();
                            }
                            else
                            {
                                txtBoxSimular.Focus();
                            }
                        }
                    }
                }
                MessageBox.Show("Debe completar todos los campos");

                
            }
            else
            {
                if (Convert.ToDecimal(txtBoxA.Text)<Convert.ToDecimal(txtBoxB.Text))
                {
                    double tiempoAIterar = float.Parse(txtBoxSimular.Text, CultureInfo.CreateSpecificCulture("en-US"));
                    dgv.Visible = true;
                    dgv.Rows.Clear();

                    this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dgv.AutoResizeColumns();
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgv.AllowUserToAddRows = false;
                    dgv.MultiSelect = false;
                    dgv.ReadOnly = true;
                    dgv.AutoGenerateColumns = false;
                   
                    //dataGridView1.Columns[IndiceColumna].DividerWidth = 3;
                    dgv.Columns[0].DividerWidth = 3;
                    dgv.Columns[1].DividerWidth = 3;
                    dgv.Columns[4].DividerWidth = 3;
                    dgv.Columns[6].DividerWidth = 3;
                    dgv.Columns[9].DividerWidth = 3;
                    dgv.Columns[12].DividerWidth = 3;
                    dgv.Columns[16].DividerWidth = 3;
                    dgv.Columns[20].DividerWidth = 3;
                    dgv.Columns[22].DividerWidth = 3;

                    if (tirada != 0)
                    {
                        //elimino las columnas que se repiten
                        if (eliminarClientes != 0)
                        {
                            for (int i2 = 23; i2 < (23 + (eliminarClientes * 2)); i2++)
                            {
                                dgv.Columns.RemoveAt(23);
                            }
                        }
                    }
                    eliminarClientes = 0;
                    tirada++;



                    foreach (DataGridViewColumn columna in dgv.Columns)
                    {
                        anchoColumnas = anchoColumnas + columna.FillWeight;
                    }

                    //List<Cliente> losClientes = new List<Cliente>();
                    do
                    {

                        
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgv);

                        if (dgv.Rows.Count == 0) //Evento de Inicio !!!
                        {
                            //Reloj
                            fila.Cells[0].Value = 0.ToString();

                            //Evento
                            fila.Cells[1].Value = "Inicio";

                            //RND llegadas
                            //randomLlegadas = guardarRandom();
                            fila.Cells[2].Value = guardarRandom1().ToString();


                            //Tiempo entre llegadas
                            fila.Cells[3].Value = tiempoEntreLlegadas(int.Parse(txtBoxFrecuencia.Text), Convert.ToDouble(fila.Cells[2].Value)).ToString();

                            //Próxima Llegada
                            fila.Cells[4].Value = (Convert.ToDecimal(fila.Cells[0].Value) + Convert.ToDecimal(fila.Cells[3].Value)).ToString();

                            //Random Montecarlo
                            fila.Cells[5].Value = "";
                            //A donde va?
                            fila.Cells[6].Value = "";
                            //RND Atención Cajero 1
                            fila.Cells[7].Value = "";

                            //Tiempo Atención Cajero 1
                            fila.Cells[8].Value = "";

                            //Fin Atención Cajero 1
                            fila.Cells[9].Value = "";

                            //RND Atención Cajero 2
                            fila.Cells[10].Value = "";

                            //Tiempo Atención Cajero 2
                            fila.Cells[11].Value = "";

                            //Fin Atención Cajero 2
                            fila.Cells[12].Value = "";

                            //Estado Cajero 1
                            fila.Cells[13].Value = "Libre";

                            //Cola Cajero 1
                            fila.Cells[14].Value = 0.ToString();

                            //Contador Clientes con espera finalizada Cajero 1
                            fila.Cells[15].Value = 0.ToString();

                            //Acumulador tiempo ocioso Cajero 1
                            fila.Cells[16].Value = 0.ToString();

                            //Estado Cajero 2
                            fila.Cells[17].Value = "Libre";

                            //Cola Cajero 2
                            fila.Cells[18].Value = 0.ToString();

                            //Contador Clientes con espera finalizada Cajero 2
                            fila.Cells[19].Value = 0.ToString();

                            //Acumulador tiempo ocioso Cajero 2
                            fila.Cells[20].Value = 0.ToString();

                            //Acumulador Tiempo clientes en el banco (tiempo en el sistema)
                            fila.Cells[21].Value = 0.ToString();

                            //Contador clientes con atención finalizada
                            fila.Cells[22].Value = 0.ToString();


                        }
                        else
                        {
                            //Creo row para ir viendo los valores de la última fila en cada iteración
                            DataGridViewRow filaAnterior = new DataGridViewRow();
                            filaAnterior = dgv.Rows[dgv.Rows.Count - 1];

                            //Reloj y verifico que evento sucede

                            if (float.TryParse(Convert.ToString(filaAnterior.Cells[4].Value), out valor1))
                            {

                            }
                            else
                            {
                                valor1 = 9999999999999999999;
                            }
                            if (float.TryParse(Convert.ToString(filaAnterior.Cells[9].Value), out valor2))
                            {

                            }
                            else
                            {
                                valor2 = 9999999999999999999;
                            }
                            if (float.TryParse(Convert.ToString(filaAnterior.Cells[12].Value), out valor3))
                            {

                            }
                            else
                            {
                                valor3 = 9999999999999999999;
                            }
                            pintar = calculoReloj(valor1, valor2, valor3);

                            fila.Cells[0].Value = pintar.ToString();

                            if (pintar == valor1)
                            {
                                filaAnterior.Cells[4].Style.BackColor = Color.LightSkyBlue;
                                fila.Cells[1].Value = "Llegada de Cliente"; //Columna evento
                                                                            //RandomMontecarlo               
                                                                            // if (muestroRandom(Convert.ToString(filaAnterior.Cells[13].Value), Convert.ToString(filaAnterior.Cells[17].Value), Convert.ToInt16(filaAnterior.Cells[14].Value), Convert.ToInt16(filaAnterior.Cells[18].Value)))
                                                                            //{
                                fila.Cells[5].Value = Convert.ToString(rndMontecarlo());
                                //}                             

                                //A donde va?
                                //fila.Cells[6].Value = aDonde(Convert.ToDecimal(fila.Cells[5].Value));
                            }
                            else
                            {
                                if (pintar == valor2)
                                {
                                    filaAnterior.Cells[9].Style.BackColor = Color.LightSkyBlue;
                                    fila.Cells[1].Value = "Fin de Atención Cajero 1"; //Columna evento
                                    fila.Cells[5].Value = "";
                                    fila.Cells[6].Value = "";
                                }
                                else
                                {
                                    filaAnterior.Cells[12].Style.BackColor = Color.LightSkyBlue;
                                    fila.Cells[1].Value = "Fin de Atención Cajero 2"; //Columna evento
                                    fila.Cells[5].Value = "";
                                    fila.Cells[6].Value = "";
                                }
                            }

                            //RND llegadas
                            if (pintar == valor1)
                            {
                                //randomLlegadas = guardarRandom();
                                fila.Cells[2].Value = guardarRandom1().ToString();

                            }
                            else
                            {
                                if (pintar == valor2)
                                {
                                    fila.Cells[2].Value = "";
                                }
                                else
                                {
                                    fila.Cells[2].Value = "";
                                }
                            }

                            //Tiempo entre llegadas
                            if (pintar == valor1)
                            {
                                fila.Cells[3].Value = (tiempoEntreLlegadas(int.Parse(txtBoxFrecuencia.Text), Convert.ToDouble(fila.Cells[2].Value))).ToString();
                            }
                            else
                            {
                                if (pintar == valor2)
                                {
                                    fila.Cells[3].Value = "";
                                }
                                else
                                {
                                    fila.Cells[3].Value = "";
                                }
                            }


                            //Próxima Llegada
                            if (pintar == valor1)
                            {
                                fila.Cells[4].Value = (Convert.ToDecimal(fila.Cells[0].Value) + Convert.ToDecimal(fila.Cells[3].Value)).ToString();
                            }
                            else
                            {
                                if (pintar == valor2)
                                {
                                    fila.Cells[4].Value = filaAnterior.Cells[4].Value.ToString();
                                }
                                else
                                {
                                    fila.Cells[4].Value = filaAnterior.Cells[4].Value.ToString();
                                }
                            }


                            //RND Atención Cajero 1 y 2
                            //Estados Cajeros
                            //Colas
                            if (pintar == valor1)
                            {
                                if (Convert.ToString(filaAnterior.Cells[13].Value) == "Libre" && Convert.ToString(filaAnterior.Cells[17].Value) == "Libre")
                                {

                                    if (Convert.ToDecimal(fila.Cells[5].Value) < (decimal)0.5)
                                    {
                                        fila.Cells[7].Value = guardarRandom2().ToString(); //Va al Cajero 1 porque el rndMontecarlo es menor a 0.5
                                        fila.Cells[6].Value = "Cajero1";
                                        fila.Cells[10].Value = ""; //No pasa nada con el Cajero 2

                                        fila.Cells[13].Value = "Ocupado"; //Cajero 1
                                        fila.Cells[14].Value = 0.ToString();

                                        fila.Cells[17].Value = "Libre"; //Cajero 2
                                        fila.Cells[18].Value = 0.ToString();
                                    }
                                    else
                                    {

                                        fila.Cells[10].Value = guardarRandom3().ToString(); //Va al Cajero 2 porque el rndMontecarlo es mayor o igual a 0.5
                                        fila.Cells[6].Value = "Cajero2";
                                        fila.Cells[7].Value = ""; //No pasa nada con el Cajero 1

                                        fila.Cells[17].Value = "Ocupado";
                                        fila.Cells[18].Value = 0.ToString();

                                        fila.Cells[13].Value = "Libre"; //Cajero 1 como estaba
                                        fila.Cells[14].Value = 0.ToString();
                                    }

                                }
                                if (Convert.ToString(filaAnterior.Cells[13].Value) == "Libre" && Convert.ToString(filaAnterior.Cells[17].Value) == "Ocupado")
                                {

                                    fila.Cells[7].Value = guardarRandom2().ToString(); //Lo mando al Cajero 1 porque está libre
                                    fila.Cells[6].Value = "Cajero1";
                                    fila.Cells[10].Value = ""; //No pasa nada con el Cajero 2

                                    fila.Cells[13].Value = "Ocupado";
                                    fila.Cells[14].Value = 0.ToString();

                                    fila.Cells[17].Value = filaAnterior.Cells[17].Value.ToString(); //Cajero 2 como estaba
                                    fila.Cells[18].Value = filaAnterior.Cells[18].Value.ToString();
                                }
                                if (Convert.ToString(filaAnterior.Cells[13].Value) == "Ocupado" && Convert.ToString(filaAnterior.Cells[17].Value) == "Libre")
                                {

                                    fila.Cells[10].Value = guardarRandom3().ToString(); //Va al Cajero 2 ya que está ocupado el 1
                                    fila.Cells[6].Value = "Cajero2";
                                    fila.Cells[7].Value = ""; //No pasa nada con el Cajero 1

                                    fila.Cells[17].Value = "Ocupado";
                                    fila.Cells[18].Value = 0.ToString();

                                    fila.Cells[13].Value = filaAnterior.Cells[13].Value.ToString(); //Cajero 1 como estaba
                                    fila.Cells[14].Value = filaAnterior.Cells[14].Value.ToString();
                                }
                                if (Convert.ToString(filaAnterior.Cells[13].Value) == "Ocupado" && Convert.ToString(filaAnterior.Cells[17].Value) == "Ocupado")
                                {
                                    fila.Cells[7].Value = ""; //No pasa nada con los Random fin de atencion porque no se genera fin de atención
                                    fila.Cells[10].Value = "";

                                    fila.Cells[13].Value = "Ocupado"; //Se mantienen ocupados los Cajeros
                                    fila.Cells[17].Value = "Ocupado";

                                    cola1 = Convert.ToInt16(filaAnterior.Cells[14].Value.ToString());
                                    cola2 = Convert.ToInt16(filaAnterior.Cells[18].Value.ToString());
                                    if (aQueColaVa(cola1, cola2, Convert.ToDecimal(fila.Cells[5].Value)) == 1)
                                    {
                                        fila.Cells[14].Value = incrementarCola(cola1).ToString();//va al Cajero 1, incrementa cola
                                        fila.Cells[6].Value = "Cajero1";
                                        fila.Cells[18].Value = filaAnterior.Cells[18].Value.ToString(); //Cola del Cajero 2 como estaba

                                    }
                                    else
                                    {
                                        fila.Cells[18].Value = incrementarCola(cola2).ToString(); //va al Cajero 2, incrementa cola
                                        fila.Cells[6].Value = "Cajero2";
                                        fila.Cells[14].Value = filaAnterior.Cells[14].Value.ToString(); //Cola del Cajero 1 como estaba
                                    }
                                }
                            }
                            else
                            {
                                if (pintar == valor2)
                                {
                                    cola1 = Convert.ToInt16(filaAnterior.Cells[14].Value.ToString()); //mira las colas de la fila anterior
                                    cola2 = Convert.ToInt16(filaAnterior.Cells[18].Value.ToString());
                                    if (hayClientesEnCola(cola1))
                                    {
                                        //randomFinAtencionCajero1 = guardarRandom(); 
                                        fila.Cells[7].Value = guardarRandom2().ToString(); //Genero Rnd para Cajero 1 porque hay gente en la cola
                                        fila.Cells[10].Value = ""; //No pasa nada con el Rnd del Cajero 2

                                        fila.Cells[13].Value = "Ocupado"; //Sigue ocupado el Cajero 1 pero con nuevo cliente que seguia en la cola
                                        fila.Cells[14].Value = decrementarCola(cola1).ToString(); //decremento cola

                                        fila.Cells[17].Value = filaAnterior.Cells[17].Value.ToString(); //Estado y Cola del cajero 2 como estaban
                                        fila.Cells[18].Value = cola2.ToString();
                                    }
                                    else
                                    {
                                        fila.Cells[7].Value = ""; //No pasa nada con los Randoms fin atencion
                                        fila.Cells[10].Value = "";

                                        fila.Cells[13].Value = "Libre"; //Se libera el Cajero 1
                                        fila.Cells[14].Value = 0.ToString();

                                        fila.Cells[17].Value = filaAnterior.Cells[17].Value.ToString(); //Estado y Cola del cajero 2 como estaban
                                        fila.Cells[18].Value = cola2.ToString();
                                    }
                                }
                                else //Fin atención Cajero 2
                                {
                                    cola1 = Convert.ToInt16(filaAnterior.Cells[14].Value.ToString()); //miro las colas de la fila anterior
                                    cola2 = Convert.ToInt16(filaAnterior.Cells[18].Value.ToString());
                                    if (hayClientesEnCola(cola2))
                                    {

                                        fila.Cells[7].Value = "";//No pasa nada con el Rnd del Cajero 1
                                        fila.Cells[10].Value = guardarRandom3().ToString();//Genero Rnd para Cajero 2 porque hay gente en la cola

                                        fila.Cells[13].Value = filaAnterior.Cells[13].Value.ToString(); //Cajero 1 como estaba
                                        fila.Cells[14].Value = cola1.ToString();

                                        fila.Cells[17].Value = "Ocupado"; //Sigue ocupado, pero con otro cliente
                                        fila.Cells[18].Value = decrementarCola(cola2).ToString();
                                    }
                                    else //No quedan clientes en la cola del Cajero 2
                                    {
                                        fila.Cells[7].Value = ""; //No pasa nada con los Randoms fin atencion
                                        fila.Cells[10].Value = "";

                                        fila.Cells[13].Value = filaAnterior.Cells[13].Value.ToString(); //Estado y Cola del Cajero 1 como estaban
                                        fila.Cells[14].Value = cola1.ToString();

                                        fila.Cells[17].Value = "Libre"; //Se libera el cajero 2
                                        fila.Cells[18].Value = 0.ToString();
                                    }
                                }
                            }



                            //Tiempo Atención Cajero 1

                            if (fila.Cells[7].Value.ToString() == "")
                            {
                                fila.Cells[8].Value = "";
                            }
                            else
                            {
                                fila.Cells[8].Value = (tiempoCajero1(double.Parse(txtBoxMedia.Text, CultureInfo.CreateSpecificCulture("en-US")), Convert.ToDouble(fila.Cells[7].Value))).ToString();
                            }

                            //Fin Atención Cajero 1
                            if ((fila.Cells[7].Value).ToString() == "")
                            {
                                if (pintar == valor1 || pintar == valor3)
                                {
                                    fila.Cells[9].Value = filaAnterior.Cells[9].Value.ToString();
                                }
                                else
                                {
                                    fila.Cells[9].Value = "";
                                }
                            }
                            else
                            {
                                fila.Cells[9].Value = (Convert.ToDouble(fila.Cells[0].Value) + Convert.ToDouble(fila.Cells[8].Value)).ToString();
                            }

                            //RND Atención Cajero 2
                            //Controlado más arriba

                            //Tiempo Atención Cajero 2
                            if (fila.Cells[10].Value.ToString() == "")
                            {
                                fila.Cells[11].Value = "";

                            }
                            else
                            {
                                fila.Cells[11].Value = (tiempoCajero2(double.Parse(txtBoxA.Text, CultureInfo.CreateSpecificCulture("en-US")), double.Parse(txtBoxB.Text, CultureInfo.CreateSpecificCulture("en-US")), Convert.ToDouble(fila.Cells[10].Value))).ToString();
                            }

                            //Fin Atención Cajero 2
                            if (fila.Cells[10].Value.ToString() == "")
                            {
                                if (pintar == valor1 || pintar == valor2)
                                {
                                    fila.Cells[12].Value = filaAnterior.Cells[12].Value.ToString();
                                }
                                else
                                {
                                    fila.Cells[12].Value = "";
                                }
                            }
                            else
                            {
                                fila.Cells[12].Value = (Convert.ToDouble(fila.Cells[0].Value) + Convert.ToDouble(fila.Cells[11].Value)).ToString();
                            }

                            //Estado Cajero 1
                            //Ya controlado más arriba


                            //Cola Cajero 1
                            //Ya controlado más arriba

                            //Contador Clientes con espera finalizada Cajero 1
                            if (pintar == valor2)
                            {
                                fila.Cells[15].Value = (contadorClientes(Convert.ToInt16(filaAnterior.Cells[15].Value))).ToString();
                            }
                            else
                            {
                                fila.Cells[15].Value = filaAnterior.Cells[15].Value.ToString();
                            }

                            //Acumulador tiempo ocioso Cajero 1
                            fila.Cells[16].Value = (acumuladorOcio(Convert.ToString(filaAnterior.Cells[13].Value), Convert.ToDouble(fila.Cells[0].Value), Convert.ToDouble(filaAnterior.Cells[0].Value), Convert.ToDouble(filaAnterior.Cells[16].Value))).ToString();

                            //Estado Cajero 2
                            //ya controlado más arriba

                            //Cola Cajero 2
                            //ya controlado más arriba

                            //Contador Clientes con espera finalizada Cajero 2
                            if (pintar == valor3)
                            {
                                fila.Cells[19].Value = (contadorClientes(Convert.ToInt16(filaAnterior.Cells[19].Value))).ToString();
                            }
                            else
                            {
                                fila.Cells[19].Value = filaAnterior.Cells[19].Value.ToString();
                            }

                            //Acumulador tiempo ocioso Cajero 2
                            fila.Cells[20].Value = (acumuladorOcio(Convert.ToString(filaAnterior.Cells[17].Value), Convert.ToDouble(fila.Cells[0].Value), Convert.ToDouble(filaAnterior.Cells[0].Value), Convert.ToDouble(filaAnterior.Cells[20].Value))).ToString();

                            //Acumulador Tiempo clientes en el banco (tiempo en el sistema)


                            //Contador clientes con atención finalizada
                            fila.Cells[22].Value = (Convert.ToInt16(fila.Cells[15].Value) + Convert.ToInt16(fila.Cells[19].Value)).ToString();

                            //Que pasa con los clientes ante los distintos eventos
                            if (pintar == valor1)
                            {
                                if ((anchoColumnas + (dgv.Columns[dgv.Columns.Count - 1].FillWeight + dgv.Columns[dgv.Columns.Count - 2].FillWeight)) > 65534)
                                {
                                    //txtAncho.Text=anchoColumnas.ToString() + " , " + (anchoColumnas + (dgv.Columns[dgv.Columns.Count - 1].FillWeight + dgv.Columns[dgv.Columns.Count - 2].FillWeight)).ToString();
                                    MessageBox.Show("Se ha llegado al ancho máximo de la tabla. No se puede seguir iterando");
                                    break;
                                }

                                fila.Cells[21].Value = Convert.ToString(filaAnterior.Cells[21].Value);

                                foreach (DataGridViewCell celda in filaAnterior.Cells) //Los que estaban en estado AF ya mueren ahí.
                                {
                                    if (Convert.ToString(celda.Value) == "AF")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = "";
                                        break;
                                    }
                                }
                                foreach (DataGridViewCell celda in filaAnterior.Cells) //Los que estaban en estado SA1 quedan igual, break porque solo uno va a haber en SA1
                                {
                                    if (Convert.ToString(celda.Value) == "SA1")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = "SA1";
                                        fila.Cells[celda.ColumnIndex + 1].Value = Convert.ToString(filaAnterior.Cells[celda.ColumnIndex + 1].Value);
                                        break;
                                    }
                                }
                                foreach (DataGridViewCell celda in filaAnterior.Cells) //Los que estaban en estado SA2 quedan igual, break porque solo uno va a haber en SA2
                                {
                                    if (Convert.ToString(celda.Value) == "SA2")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = "SA2";
                                        fila.Cells[celda.ColumnIndex + 1].Value = Convert.ToString(filaAnterior.Cells[celda.ColumnIndex + 1].Value);
                                        break;
                                    }
                                }
                                foreach (DataGridViewCell celda in filaAnterior.Cells) //Los que estaban en estado EA1 quedan igual, no break porque puede haber más de 1 esperando
                                {
                                    if (Convert.ToString(celda.Value) == "EA1")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = "EA1";
                                        fila.Cells[celda.ColumnIndex + 1].Value = Convert.ToString(filaAnterior.Cells[celda.ColumnIndex + 1].Value);
                                    }
                                }
                                foreach (DataGridViewCell celda in filaAnterior.Cells) //Los que estaban en estado EA2 quedan igual, no break porque puede haber más de 1 esperando
                                {
                                    if (Convert.ToString(celda.Value) == "EA2")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = "EA2";
                                        fila.Cells[celda.ColumnIndex + 1].Value = Convert.ToString(filaAnterior.Cells[celda.ColumnIndex + 1].Value);
                                    }
                                }

                                //Creo lista de objetos cliente                        



                                Cliente cliente = new Cliente();

                                eliminarClientes++;

                                cliente.Id = idCliente;
                                idCliente = idCliente + 1;
                                //Creo columna de estado del nuevo cliente
                                DataGridViewColumn columna1 = new DataGridViewColumn();
                                columna1.HeaderText = ("Estado cliente " + cliente.Id.ToString()).ToString();
                                columna1.Name = ("Estadocliente" + cliente.Id.ToString()).ToString();
                                columna1.CellTemplate = new DataGridViewTextBoxCell();
                                anchoColumnas = anchoColumnas + columna1.FillWeight;
                                //Creo columna hora de llegada del nuevo cliente
                                DataGridViewColumn columna2 = new DataGridViewColumn();
                                columna2.HeaderText = ("Hora de llegada cliente " + cliente.Id.ToString()).ToString();
                                columna2.Name = ("Horadellegadacliente" + cliente.Id.ToString()).ToString();
                                columna2.CellTemplate = new DataGridViewTextBoxCell();
                                columna2.DividerWidth = 3;
                                anchoColumnas = anchoColumnas + columna2.FillWeight;
                                //Agergo cliente a la lista de Clientes


                                DataGridViewRow filaAuxiliar = new DataGridViewRow();
                                filaAuxiliar.CreateCells(dgv);

                                //double aVer = Convert.ToDouble(fila.Cells[0].Value);
                                int i = 0;
                                foreach (DataGridViewCell celda in fila.Cells)
                                {
                                    filaAuxiliar.Cells[i].Value = Convert.ToString(celda.Value);
                                    i++;
                                }

                                dgv.Columns.Add(columna1);
                                dgv.Columns.Add(columna2);

                                fila.CreateCells(dgv);
                                int j = 0;
                                foreach (DataGridViewCell celda in filaAuxiliar.Cells)
                                {
                                    fila.Cells[j].Value = Convert.ToString(celda.Value);
                                    j++;
                                }

                                //double aVerAhora = Convert.ToDouble(fila.Cells[0].Value);

                                //Seteo estado del nuevo cliente
                                cliente.Estado = Convert.ToString(estadoClienteQueLlega(Convert.ToString(filaAnterior.Cells[13].Value), Convert.ToString(filaAnterior.Cells[17].Value), Convert.ToInt16(filaAnterior.Cells[14].Value), Convert.ToInt16(filaAnterior.Cells[18].Value), Convert.ToDecimal(fila.Cells[5].Value)));
                                //Seteo la celda

                                fila.Cells[(dgv.Columns.Count - 2)].Value = cliente.Estado.ToString();

                                //Seteo hora de llegada del nuevo cliente

                                cliente.HoraLlegada = Convert.ToDouble(fila.Cells[0].Value);
                                //Seteo la celda
                                fila.Cells[dgv.Columns.Count - 1].Value = (cliente.HoraLlegada).ToString();
                                cliente = null;
                            }

                            if (pintar == valor2)
                            {
                                //Actualizo el estado de los clientes con estado SA1
                                foreach (DataGridViewCell celda in filaAnterior.Cells)
                                {
                                    if (Convert.ToString(celda.Value) == "SA1")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = "AF";
                                        fila.Cells[21].Value = Convert.ToString(acumuladorTiempoEnSistema(Convert.ToDecimal(filaAnterior.Cells[21].Value), Convert.ToDecimal(fila.Cells[0].Value), Convert.ToDecimal(filaAnterior.Cells[celda.ColumnIndex + 1].Value)));
                                        break;
                                    }
                                }
                                foreach (DataGridViewCell celda in filaAnterior.Cells)
                                {
                                    if (Convert.ToString(celda.Value) == "SA2")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = Convert.ToString(celda.Value);
                                        fila.Cells[celda.ColumnIndex + 1].Value = Convert.ToString(Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex + 1].Value));
                                        break;
                                    }
                                }
                                double i = 9999999999999999999; //Para controlar quién pasa a ser atendido de los que estan esperando
                                int indice = -1;
                                foreach (DataGridViewCell celda in filaAnterior.Cells)
                                {
                                    if (Convert.ToString(celda.Value) == "EA1")
                                    {
                                        if (Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex + 1].Value) < i)
                                        {
                                            i = Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex + 1].Value);
                                            indice = (celda.ColumnIndex + 1); //
                                                                              //El cambio de estado lo tengo que hacer afuera del foreach, una verga
                                        }
                                        else
                                        {
                                            fila.Cells[celda.ColumnIndex].Value = "EA1";
                                            fila.Cells[celda.ColumnIndex + 1].Value = Convert.ToString(Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex + 1].Value));
                                        }
                                    }
                                }
                                if (indice != -1)
                                {
                                    fila.Cells[indice - 1].Value = "SA1";
                                    fila.Cells[indice].Value = i.ToString();
                                }

                                foreach (DataGridViewCell celda in filaAnterior.Cells)
                                {
                                    if (Convert.ToString(celda.Value) == "EA2")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = "EA2";
                                        fila.Cells[celda.ColumnIndex + 1].Value = Convert.ToString(Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex + 1].Value));
                                    }
                                }
                            }
                            if (pintar == valor3) //que pasa con los clientes ante un fin atencion del cajero 2
                            {
                                //Actualizo el estado de los clientes con estado SA2
                                foreach (DataGridViewCell celda in filaAnterior.Cells)
                                {
                                    if (Convert.ToString(celda.Value) == "SA2")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = "AF";
                                        fila.Cells[21].Value = Convert.ToString(acumuladorTiempoEnSistema(Convert.ToDecimal(filaAnterior.Cells[21].Value), Convert.ToDecimal(fila.Cells[0].Value), Convert.ToDecimal(filaAnterior.Cells[celda.ColumnIndex + 1].Value)));
                                        break;
                                    }
                                }
                                foreach (DataGridViewCell celda in filaAnterior.Cells)
                                {
                                    if (Convert.ToString(celda.Value) == "SA1")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = Convert.ToString(celda.Value);
                                        fila.Cells[celda.ColumnIndex + 1].Value = Convert.ToString(Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex + 1].Value));
                                        break;
                                    }
                                }
                                double i2 = 9999999999999999999; //Para controlar quién pasa a ser atendido de los que estan esperando
                                int indice2 = -1;
                                foreach (DataGridViewCell celda in filaAnterior.Cells)
                                {
                                    if (Convert.ToString(celda.Value) == "EA2")
                                    {
                                        if (Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex + 1].Value) < i2)
                                        {
                                            i2 = Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex + 1].Value);
                                            indice2 = (celda.ColumnIndex + 1); //
                                                                               //El cambio de estado lo tengo que hacer afuera del foreach, una verga
                                        }
                                        else
                                        {
                                            fila.Cells[celda.ColumnIndex].Value = "EA2";
                                            fila.Cells[celda.ColumnIndex + 1].Value = Convert.ToString(Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex + 1].Value));
                                        }
                                    }
                                }
                                if (indice2 != -1)
                                {
                                    fila.Cells[indice2 - 1].Value = "SA2";
                                    fila.Cells[indice2].Value = i2.ToString();
                                }

                                foreach (DataGridViewCell celda in filaAnterior.Cells)
                                {
                                    if (Convert.ToString(celda.Value) == "EA1")
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = "EA1";
                                        fila.Cells[celda.ColumnIndex + 1].Value = Convert.ToString(Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex + 1].Value));
                                    }
                                }
                            }

                            if (muestroRandom(Convert.ToString(filaAnterior.Cells[13].Value), Convert.ToString(filaAnterior.Cells[17].Value), Convert.ToInt16(filaAnterior.Cells[14].Value), Convert.ToInt16(filaAnterior.Cells[18].Value)))
                            {

                            }
                            else
                            {
                                fila.Cells[5].Value = "";
                            }

                        }

                        //saco el botón de la cabecera de cada columna que permitía ordenar
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }


                        //Insertamos nueva fila efectivamente
                        dgv.Rows.Add(fila);

                        //Controlamos si seguimos iterando o no
                        if (decimal.TryParse(Convert.ToString(dgv.Rows[dgv.Rows.Count - 1].Cells[4].Value), out variable1))
                        {

                        }
                        else
                        {
                            variable1 = 9999999999999999999;
                        }
                        if (decimal.TryParse(Convert.ToString(dgv.Rows[dgv.Rows.Count - 1].Cells[9].Value), out variable2))
                        {

                        }
                        else
                        {
                            variable2 = 9999999999999999999;
                        }
                        if (decimal.TryParse(Convert.ToString(dgv.Rows[dgv.Rows.Count - 1].Cells[12].Value), out variable3))
                        {

                        }
                        else
                        {
                            variable3 = 9999999999999999999;
                        }

                        comparar = controlReloj(variable1, variable2, variable3);
                        dgv.Refresh(); //vamo a ver q onda estoooooooooooooooooooooooooooooo

                        //foreach (DataGridViewColumn columna in dgv.Columns)
                        //{
                        //    anchoColumnas = anchoColumnas + columna.FillWeight;
                        //}

                    } while ((double)comparar < tiempoAIterar);



                    idCliente = 1;



                    //seteo a null a todos los clientes
                    //foreach (Cliente unCliente in losClientes)
                    //{
                    //    unCliente.Id = null;
                    //}




                    //int numeroCliente = 1;
                    //int contadorColumnas =0;
                    //foreach (DataGridViewColumn columna in dgv.Columns)
                    //{              
                    //    if (columna.Name==Convert.ToString("Estadocliente" + numeroCliente))
                    //    {
                    //        contadorColumnas++;

                    //    }
                    //    if (contadorColumnas==2)
                    //    {
                    //        foreach (DataGridViewColumn columna2 in dgv.Columns)
                    //        {
                    //            if (columna2.Name == Convert.ToString("Estadocliente" + numeroCliente))
                    //            {
                    //                dgv.Columns.Remove(columna2);
                    //                break;
                    //            }                     
                    //        }
                    //        foreach (DataGridViewColumn columna2 in dgv.Columns)
                    //        {
                    //            if (columna2.Name == Convert.ToString("Horadellegadacliente" + numeroCliente))
                    //            {
                    //                dgv.Columns.Remove(columna2);
                    //                break;
                    //            }
                    //        }
                    //    }
                    //    numeroCliente++;
                    //}

                    //dgv.Refresh();

                    //Estadisticas
                    if (Convert.ToDecimal(dgv.Rows[dgv.Rows.Count - 1].Cells[0].Value) == 0) //Controlo division por 0
                    {
                        lblEstadisticaACajero1.Text = (0.ToString() + " " + "clientes / hora").ToString();
                        lblEstadisticaACajero2.Text = (0.ToString() + " " + "clientes / hora").ToString();
                    }
                    else
                    {


                        lblEstadisticaACajero1.Text = (Math.Round((((Convert.ToDecimal(dgv.Rows[dgv.Rows.Count - 1].Cells[15].Value)) / (Convert.ToDecimal(dgv.Rows[dgv.Rows.Count - 1].Cells[0].Value))) * 60), 3).ToString() + " " + "clientes/hora").ToString();
                        lblEstadisticaACajero2.Text = (Math.Round((((Convert.ToDecimal(dgv.Rows[dgv.Rows.Count - 1].Cells[19].Value)) / (Convert.ToDecimal(dgv.Rows[dgv.Rows.Count - 1].Cells[0].Value))) * 60), 3).ToString() + " " + "clientes/hora").ToString();
                    }

                    if (Convert.ToDecimal(dgv.Rows[dgv.Rows.Count - 1].Cells[22].Value) == 0)
                    {
                        lblEstadisticaB.Text = (0.ToString() + " " + "minutos").ToString();
                    }
                    else
                    {
                        //decimal redondeado = (decimal)Math.Round(rnd, 3);
                        lblEstadisticaB.Text = (Math.Round(((Convert.ToDecimal(dgv.Rows[dgv.Rows.Count - 1].Cells[21].Value)) / (Convert.ToInt16(dgv.Rows[dgv.Rows.Count - 1].Cells[22].Value))), 3).ToString() + " " + "minutos").ToString();
                    }

                    lblEstadisticaCCajero1.Text = ((Math.Round(Convert.ToDouble(dgv.Rows[dgv.Rows.Count - 1].Cells[16].Value), 3).ToString()) + " " + "minutos").ToString();
                    lblEstadisticaCCajero2.Text = ((Math.Round(Convert.ToDouble(dgv.Rows[dgv.Rows.Count - 1].Cells[20].Value), 3).ToString()) + " " + "minutos").ToString();

                    //idCliente = 1;
                }
                else
                {
                    MessageBox.Show("El parámetro A debe ser menor al parámetro B");
                }




            }



        }

       


static Random _Random = new Random();
        decimal guardarRandom1()
        {
            decimal redondeado;
            do
            {
                double rnd = _Random.NextDouble();
                redondeado = (decimal)Math.Round(rnd, 3);
            } while (redondeado==(decimal)1);
            
            return redondeado;
        }
        
        decimal guardarRandom2()
        {
            decimal redondeado;
            do
            {
                double rnd = _Random.NextDouble();
                redondeado = (decimal)Math.Round(rnd, 3);
            } while (redondeado==(decimal)1);
            
            return redondeado;
        }
        
        decimal guardarRandom3()
        {
            //Random _Random3 = new Random();
            double rnd = _Random.NextDouble();
            decimal redondeado = (decimal)Math.Round(rnd, 3);
            return redondeado;
        }

        
        decimal rndMontecarlo()
        {
            //Random _Random4 = new Random();
            double rnd = _Random.NextDouble();
            decimal redondeado = (decimal)Math.Round(rnd, 3);
            
            return redondeado;
        }

        decimal tiempoEntreLlegadas(int frecuencia, double rndLlegadas)
        {


            double frecuenciaClientesPorMinuto = frecuencia * 0.016666666666;
            double x;
            double cociente;
            cociente = -1 / frecuenciaClientesPorMinuto;

            x = cociente * Math.Log(1 - (double)rndLlegadas);
            decimal redondeado = (decimal)Math.Round(x, 3);
            return redondeado;
        }

        decimal tiempoCajero1(double media, double rndFinAtencionCajero1)
        {
            double x = (double)(-media) * Math.Log(1 - rndFinAtencionCajero1);
            decimal redondeado = (decimal)Math.Round(x, 3);
            return redondeado;
        }
        decimal tiempoCajero2(double a, double b, double rndFinAtencionCajero2)
        {
            double x = (rndFinAtencionCajero2 * (b - a)) + a;
            decimal redondeado = (decimal)Math.Round(x, 3);
            return redondeado;
        }

        float calculoReloj(float proxLlegada, float finAt1, float finAt2)
        {
            //Me fijo cual de los 3 eventos sucede para ver que pongo en el reloj

            if ((proxLlegada<finAt1)&&(proxLlegada<finAt2))
            {
                return proxLlegada;
            }
            else
            {
                if ((finAt1<proxLlegada)&&(finAt1<finAt2))
                {
                    return finAt1;
                }
                else
                {
                    return finAt2;
                }
            }
        }

        int aQueColaVa(int colaCajero1, int colaCajero2, decimal rndMontecarlo)
        {
            if (colaCajero1==colaCajero2)
            {
                if (rndMontecarlo<(decimal)0.5)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
                
            }
            else
            {
                if (colaCajero1<colaCajero2)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
        int incrementarCola(int cola)
        {
            int incremento = cola + 1;
            return incremento;
        }
        int decrementarCola(int cola)
        {
            int decremento = cola - 1;
            return decremento;
        }

        bool hayClientesEnCola(int cola)
        {
            if (cola>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        int contadorClientes(int clientes)
        {
            int incrementar = clientes + 1;
            return incrementar;
        }

        double acumuladorOcio(string estadoAnterior, double relojActual, double relojAnterior, double ocioAnterior)
        {
            double resultado;
            //Console.WriteLine(String.Equals(ejEqual1, ejEqual2));
            if (estadoAnterior == "Libre")
            //if(String.Equals(estadoAnterior, "Libre"))
            {
                resultado = ocioAnterior + (relojActual - relojAnterior);
            }
            else
            {
                resultado = ocioAnterior;
            }

            return resultado;
        }
        string estadoClienteQueLlega(string estadoAnteriorCajero1, string estadoAnteriorCajero2, int colaAnteriorCajero1, int colaAnteriorCajero2, decimal rndMontecarlo)
        {
            string estadoCliente="";
            if (estadoAnteriorCajero1=="Libre" && estadoAnteriorCajero2=="Libre")
            {
                if (rndMontecarlo<(decimal)0.5)
                {
                    estadoCliente = "SA1";
                }
                else
                {
                    estadoCliente = "SA2";
                }
            }

            if (estadoAnteriorCajero1 == "Libre" && estadoAnteriorCajero2 == "Ocupado")
            {
                estadoCliente = "SA1";
            }
            if (estadoAnteriorCajero1 == "Ocupado" && estadoAnteriorCajero2 == "Libre")
            {
                estadoCliente = "SA2";
            }
            if (estadoAnteriorCajero1 == "Ocupado" && estadoAnteriorCajero2 == "Ocupado")
            {
                if (aQueColaVa(colaAnteriorCajero1,colaAnteriorCajero2, rndMontecarlo)==1)
                {
                    estadoCliente = "EA1";
                }
                else
                {
                    estadoCliente = "EA2";
                }
                                
            }
            return estadoCliente;
        }

        decimal acumuladorTiempoEnSistema(decimal acumuladorAnterior, decimal reloj, decimal horaLlegada)
        {
            decimal redondeado;
            decimal resultado;
            resultado = (decimal)(acumuladorAnterior + (reloj - horaLlegada));
            redondeado= (decimal)Math.Round(resultado, 3);
            return redondeado;
        }

        decimal controlReloj(decimal llegadaCliente, decimal finAtencionCajero1, decimal finAtencionCajero2)
        {

            if ((llegadaCliente<finAtencionCajero1) && (llegadaCliente<finAtencionCajero2))
            {
                return llegadaCliente;
            }
            else
            {
                if ((finAtencionCajero1<llegadaCliente) && (finAtencionCajero1<finAtencionCajero2))
                {
                    return finAtencionCajero1;
                }
                else
                {
                    return finAtencionCajero2;
                }
            }
        }

        string aDonde(decimal rndMontecarlo)
        {
            string cadena;

            if (rndMontecarlo < (decimal)0.5)
            {
                cadena = "Cajero1";
            }
            else
            {
                cadena = "Cajero2";
            }
            return cadena;
        }
        bool muestroRandom(string estadoAnteriorCajero1, string estadoAnteriorCajero2, int colaAnteriorCajero1, int colaAnteriorCajero2)
        {        
            if (estadoAnteriorCajero1=="Libre" && estadoAnteriorCajero2=="Libre")
            {
                return true;
            }
            else
            {
                if ((estadoAnteriorCajero1 == "Ocupado" && estadoAnteriorCajero2 == "Ocupado") && (colaAnteriorCajero1==colaAnteriorCajero2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        
        
       
    }
}
