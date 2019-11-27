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
        public decimal randomLlegadas;
        public decimal randomFinAtencionCajero1;
        public decimal randomFinAtencionCajero2;
        public int idCliente=1;
        public Form1()
        {
            InitializeComponent();
            dgv.Visible = false;
        }

        //private void btnLlegadaCliente_Click(object sender, EventArgs e)
        //{
        //    lblLlegadaCliente.Text = tiempoEntreLlegadas(int.Parse(txtBoxFrecuencia.Text)).ToString();
        //}

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
        decimal elRandom()
        {
            Random _Random = new Random();
            double rnd = _Random.NextDouble();
            decimal redondeado = (decimal)Math.Round(rnd, 3);
            return redondeado;
        }
        decimal guardarRandom()
        {
            decimal rnd = elRandom();
            return rnd;
        }

        decimal tiempoEntreLlegadas(int frecuencia)
        {

            
            double frecuenciaClientesPorMinuto = frecuencia*0.016666666666;
            double x;
            double cociente;
            cociente = -1 / frecuenciaClientesPorMinuto;
            
            x = cociente * Math.Log(1 - (double)randomLlegadas);
            decimal redondeado = (decimal)Math.Round(x, 3);
            return redondeado;
        }

        decimal tiempoCajero1(double media)
        {

            
            double x = (double)(-media) * Math.Log(1 - (double)randomFinAtencionCajero1);
            decimal redondeado = (decimal)Math.Round(x, 3);
            return redondeado;
        }
        decimal tiempoCajero2(double a, double b)
        {
           

            double x = ((double)randomFinAtencionCajero2 * (b - a)) + a;
            decimal redondeado = (decimal)Math.Round(x, 3);
            return redondeado;
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
        public double controlReloj;
        public float valor1;
        public float valor2;
        public float valor3;
        public float pintar;
        public int cola1;
        public int cola2;
        private void btnSimular_Click(object sender, EventArgs e)
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
      
            do
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);

                if (dgv.Rows.Count==0)
                {
                    //Reloj
                    fila.Cells[0].Value = 0;

                    //Evento
                    fila.Cells[1].Value = "Inicio";

                    //RND llegadas
                    randomLlegadas = guardarRandom();
                    fila.Cells[2].Value = randomLlegadas.ToString();

                    //Tiempo entre llegadas
                    fila.Cells[3].Value = tiempoEntreLlegadas(int.Parse(txtBoxFrecuencia.Text));

                    //Próxima Llegada
                    fila.Cells[4].Value = Convert.ToDecimal(fila.Cells[0].Value) + Convert.ToDecimal(fila.Cells[3].Value);

                    //RND Atención Cajero 1
                    fila.Cells[5].Value = "";

                    //Tiempo Atención Cajero 1
                    fila.Cells[6].Value = "";

                    //Fin Atención Cajero 1
                    fila.Cells[7].Value = "";

                    //RND Atención Cajero 2
                    fila.Cells[8].Value = "";

                    //Tiempo Atención Cajero 2
                    fila.Cells[9].Value = "";

                    //Fin Atención Cajero 2
                    fila.Cells[10].Value = "";

                    //Estado Cajero 1
                    fila.Cells[11].Value = "Libre";

                    //Cola Cajero 1
                    fila.Cells[12].Value = (decimal)0;

                    //Contador Clientes con espera finalizada Cajero 1
                    fila.Cells[13].Value = (decimal)0;

                    //Acumulador tiempo ocioso Cajero 1
                    fila.Cells[14].Value = (decimal)0;

                    //Estado Cajero 2
                    fila.Cells[15].Value = "Libre";

                    //Cola Cajero 2
                    fila.Cells[16].Value = (decimal)0;

                    //Contador Clientes con espera finalizada Cajero 2
                    fila.Cells[17].Value = (decimal)0;

                    //Acumulador tiempo ocioso Cajero 2
                    fila.Cells[18].Value = (decimal)0;

                    //Acumulador Tiempo clientes en el banco (tiempo en el sistema)
                    fila.Cells[19].Value = (decimal)0;

                    //Contador clientes con atención finalizada
                    fila.Cells[20].Value = (decimal)0;

                    controlReloj = Convert.ToDouble(fila.Cells[4].Value);
                }
                else
                {
                    //Creo variable row para ir viendo los valores de la última fila
                    DataGridViewRow filaAnterior = dgv.Rows[dgv.Rows.Count - 1];

                    //Reloj y verifico que evento sucede
                   
                    if (float.TryParse(Convert.ToString(filaAnterior.Cells[4].Value), out valor1))
                    {                   
                        
                    }
                    else
                    {
                        valor1 = 0;
                    }
                    if (float.TryParse(Convert.ToString(filaAnterior.Cells[7].Value), out valor2))
                    {

                    }
                    else
                    {
                        valor2 = 0;
                    }
                    if (float.TryParse(Convert.ToString(filaAnterior.Cells[10].Value), out valor3))
                    {

                    }
                    else
                    {
                        valor3 = 0;
                    }
                    pintar = calculoReloj(valor1, valor2, valor3);

                    fila.Cells[0].Value = pintar.ToString();

                    if (pintar==valor1)
                    {
                        filaAnterior.Cells[4].Style.BackColor = Color.Aqua;
                        fila.Cells[1].Value = "Llegada de Cliente"; //Columna evento
                    }
                    else
                    {
                        if (pintar==valor2)
                        {
                            filaAnterior.Cells[7].Style.BackColor = Color.Aqua;
                            fila.Cells[1].Value = "Fin de Atención Cajero 1"; //Columna evento
                        }
                        else
                        {
                            filaAnterior.Cells[10].Style.BackColor = Color.Aqua;
                            fila.Cells[1].Value = "Fin de Atención Cajero 2"; //Columna evento
                        }
                    }

                    //RND llegadas
                    if (pintar==valor1)
                    {
                        randomLlegadas = guardarRandom();
                        fila.Cells[2].Value = randomLlegadas.ToString();
                        
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
                        fila.Cells[3].Value = tiempoEntreLlegadas(int.Parse(txtBoxFrecuencia.Text));
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
                            fila.Cells[4].Value = filaAnterior.Cells[4].Value;
                        }
                        else
                        {
                            fila.Cells[4].Value = filaAnterior.Cells[4].Value;
                        }
                    }


                    //RND Atención Cajero 1 y 2
                    //Estados Cajeros
                    //Colas
                    if (pintar == valor1)
                    {
                        if (Convert.ToString(filaAnterior.Cells[11].Value)=="Libre" && Convert.ToString(filaAnterior.Cells[15].Value) == "Libre")
                        {
                            randomFinAtencionCajero1 = guardarRandom(); //Se genera un fin de atención ya que están los 2 libres
                            fila.Cells[5].Value = randomFinAtencionCajero1.ToString(); //Va al Cajero 1 por defecto
                            fila.Cells[8].Value = ""; //No pasa nada con el Cajero 2

                            fila.Cells[11].Value = "Ocupado"; //Cajero 1
                            fila.Cells[12].Value = 0;

                            fila.Cells[15].Value = "Libre"; //Cajero 2
                            fila.Cells[16].Value = 0;
                        }
                        else
                        {
                            if (Convert.ToString(filaAnterior.Cells[11].Value) == "Libre")
                            {
                                randomFinAtencionCajero1 = guardarRandom();
                                fila.Cells[5].Value = randomFinAtencionCajero1.ToString();
                                fila.Cells[8].Value = ""; //No pasa nada con el Cajero 2

                                fila.Cells[11].Value = "Ocupado";
                                fila.Cells[12].Value = 0;

                                fila.Cells[15].Value = filaAnterior.Cells[15].Value; //Cajero 2 como estaba
                                fila.Cells[16].Value = filaAnterior.Cells[16].Value;
                            }
                            else
                            {
                                if (Convert.ToString(filaAnterior.Cells[15].Value) == "Libre")
                                {
                                    randomFinAtencionCajero2 = guardarRandom();
                                    fila.Cells[8].Value = randomFinAtencionCajero2.ToString(); //Va al Cajero 2 ya que está ocupado el 1
                                    fila.Cells[5].Value = ""; //No pasa nada con el Cajero 1

                                    fila.Cells[15].Value = "Ocupado";
                                    fila.Cells[16].Value = 0;

                                    fila.Cells[11].Value = filaAnterior.Cells[11].Value; //Cajero 1 como estaba
                                    fila.Cells[12].Value = filaAnterior.Cells[12].Value;

                                }
                                else //los dos Cajeros Ocupados
                                {
                                    fila.Cells[5].Value = ""; //No pasa nada con los Random fin de atencion
                                    fila.Cells[8].Value = "";

                                    fila.Cells[11].Value = "Ocupado"; //Se mantienen ocupados los Cajeros
                                    fila.Cells[15].Value = "Ocupado";

                                    cola1 = Convert.ToInt16(filaAnterior.Cells[12].Value);
                                    cola2 = Convert.ToInt16(filaAnterior.Cells[16].Value);
                                    if (aQueColaVa(cola1,cola2)==1)
                                    {
                                        fila.Cells[12].Value = incrementarCola(cola1).ToString();//va al Cajero 1, incrementa cola
                                        fila.Cells[16].Value = filaAnterior.Cells[16].Value; //Cola del Cajero 2 como estaba
                                        
                                    }
                                    else
                                    {
                                        fila.Cells[16].Value = incrementarCola(cola2).ToString(); //va al Cajero 2, incrementa cola
                                        fila.Cells[12].Value = filaAnterior.Cells[12].Value; //Cola del Cajero 1 como estaba
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (pintar == valor2)
                        {
                            cola1 = Convert.ToInt16(filaAnterior.Cells[12].Value); //mira las colas de la fila anterior
                            cola2 = Convert.ToInt16(filaAnterior.Cells[16].Value);
                            if (hayClientesEnCola(cola1))
                            {
                                randomFinAtencionCajero1 = guardarRandom(); //Genero Rnd para Cajero 1 porque hay gente en la cola
                                fila.Cells[5].Value = randomFinAtencionCajero1.ToString();
                                fila.Cells[8].Value = ""; //No pasa nada con el Rnd del Cajero 2

                                

                                fila.Cells[11].Value = "Ocupado"; //Sigue ocupado el Cajero 1 pero con nuevo cliente que seguia en la cola
                                fila.Cells[12].Value = decrementarCola(cola1); //decremento cola

                                fila.Cells[15].Value = filaAnterior.Cells[15].Value; //Estado y Cola del cajero 2 como estaban
                                fila.Cells[16].Value = cola2;
                            }
                            else
                            {
                                fila.Cells[5].Value = ""; //No pasa nada con los Randoms fin atencion
                                fila.Cells[8].Value = "";

                                fila.Cells[11].Value = "Libre"; //Se libera el Cajero 1
                                fila.Cells[12].Value = 0;

                                fila.Cells[15].Value = filaAnterior.Cells[15].Value; //Estado y Cola del cajero 2 como estaban
                                fila.Cells[16].Value = cola2;
                            }
                        }
                        else
                        {
                            cola1 = Convert.ToInt16(filaAnterior.Cells[12].Value); //miro las colas de la fila anterior
                            cola2 = Convert.ToInt16(filaAnterior.Cells[16].Value);
                            if (hayClientesEnCola(cola2))
                            {
                                randomFinAtencionCajero2 = guardarRandom(); //Genero Rnd para Cajero 2 porque hay gente en la cola
                                fila.Cells[5].Value = "";//No pasa nada con el Rnd del Cajero 1
                                fila.Cells[8].Value = randomFinAtencionCajero2.ToString(); 

                                fila.Cells[11].Value = filaAnterior.Cells[11].Value; //Cajero 1 como estaba
                                fila.Cells[12].Value = cola1; 

                                fila.Cells[15].Value = "Ocupado"; //Sigue ocupado, pero con otro cliente
                                fila.Cells[16].Value = decrementarCola(cola2);
                            }
                            else //No quedan clientes en la cola del Cajero 2
                            {
                                fila.Cells[5].Value = ""; //No pasa nada con los Randoms fin atencion
                                fila.Cells[8].Value = "";

                                fila.Cells[11].Value = filaAnterior.Cells[11].Value; //Estado y Cola del Cajero 1 como estaban
                                fila.Cells[12].Value = cola1;

                                fila.Cells[15].Value = "Libre"; //Se libera el cajero 2
                                fila.Cells[16].Value = 0;
                            }
                        }
                    }



                    //Tiempo Atención Cajero 1

                    if ((string)fila.Cells[5].Value=="")
                    {
                        fila.Cells[6].Value = "";

                    }
                    else
                    {
                        fila.Cells[6].Value = (tiempoCajero1(double.Parse(txtBoxMedia.Text))).ToString();
                    }

                    //Fin Atención Cajero 1
                    if (Convert.ToString(fila.Cells[5].Value) == "")
                    {
                        if (pintar == valor1 || pintar ==valor3)
                        {
                            fila.Cells[7].Value = filaAnterior.Cells[7].Value;
                        }
                        else
                        {
                            fila.Cells[7].Value = "";
                        }

                    }
                    else
                    {
                        fila.Cells[7].Value = (Convert.ToDouble(fila.Cells[0].Value) + Convert.ToDouble(fila.Cells[6].Value)).ToString();
                    }


                    //RND Atención Cajero 2
                    //Controlado más arriba

                    //Tiempo Atención Cajero 2
                    if ((string)fila.Cells[8].Value == "")
                    {
                        fila.Cells[9].Value = "";

                    }
                    else
                    {
                        fila.Cells[9].Value = (tiempoCajero2(double.Parse(txtBoxA.Text), double.Parse(txtBoxB.Text))).ToString();
                    }

                    //Fin Atención Cajero 2
                    if (Convert.ToString(fila.Cells[8].Value) == "")
                    {
                        if (pintar == valor1 || pintar == valor2)
                        {
                            fila.Cells[10].Value = filaAnterior.Cells[10].Value;
                        }
                        else
                        {
                            fila.Cells[10].Value = "";
                        }

                    }
                    else
                    {
                        fila.Cells[10].Value = (Convert.ToDouble(fila.Cells[0].Value) + Convert.ToDouble(fila.Cells[9].Value)).ToString();
                    }

                    //Estado Cajero 1
                    //Ya controlado más arriba


                    //Cola Cajero 1
                    //Ya controlado más arriba

                    //Contador Clientes con espera finalizada Cajero 1
                    if (pintar == valor2)
                    {
                        fila.Cells[13].Value = (contadorClientes(Convert.ToInt16(filaAnterior.Cells[13].Value))).ToString();
                    }
                    else
                    {
                        fila.Cells[13].Value = filaAnterior.Cells[13].Value;
                    }

                    //Acumulador tiempo ocioso Cajero 1
                    fila.Cells[14].Value = (acumuladorOcio(Convert.ToString(filaAnterior.Cells[11]), Convert.ToDouble(fila.Cells[0].Value), Convert.ToDouble(filaAnterior.Cells[0].Value), Convert.ToDouble(filaAnterior.Cells[14].Value))).ToString();

                    //Estado Cajero 2
                    //ya controlado más arriba

                    //Cola Cajero 2
                    //ya controlado más arriba

                    //Contador Clientes con espera finalizada Cajero 2
                    if (pintar == valor3)
                    {
                        fila.Cells[17].Value = (contadorClientes(Convert.ToInt16(filaAnterior.Cells[17].Value))).ToString();
                    }
                    else
                    {
                        fila.Cells[17].Value = filaAnterior.Cells[17].Value;
                    }

                    //Acumulador tiempo ocioso Cajero 2
                    fila.Cells[18].Value = (acumuladorOcio(Convert.ToString(filaAnterior.Cells[15]), Convert.ToDouble(fila.Cells[0].Value), Convert.ToDouble(filaAnterior.Cells[0].Value), Convert.ToDouble(filaAnterior.Cells[18].Value))).ToString();

                    //Acumulador Tiempo clientes en el banco (tiempo en el sistema)
                    fila.Cells[19].Value = (decimal)0; //yyyyy acaaaaaaaaaaa queee ondaaaaa losss clientessssssssss

                    //Contador clientes con atención finalizada
                    fila.Cells[20].Value = (Convert.ToInt16(fila.Cells[13].Value) + Convert.ToInt16(fila.Cells[17].Value)).ToString();

                    //Que pasa con los clientes ante los distintos eventos
                    if (pintar == valor1)
                    {
                        if (Convert.ToInt16(filaAnterior.Cells[0].Value)==0)
                        {

                        }
                        else
                        {
                            fila.Cells[dgv.Columns.Count - 2].Value = filaAnterior.Cells[dgv.Columns.Count - 2].Value;
                            fila.Cells[dgv.Columns.Count - 1].Value = filaAnterior.Cells[dgv.Columns.Count - 1].Value;
                        }

                        Cliente cliente = new Cliente();
                        cliente.Id = idCliente;
                        idCliente = idCliente + 1;
                        //Creo columna de estado del nuevo cliente
                        DataGridViewColumn columna1 = new DataGridViewColumn();
                        columna1.HeaderText = "Estado cliente " + Convert.ToString(idCliente);
                        //Creo columna hora de llegada del nuevo cliente
                        DataGridViewColumn columna2 = new DataGridViewColumn();
                        columna1.HeaderText = "Hora de llegada cliente " + Convert.ToString(idCliente);
                        //Agrego columnas efectivamente
                        dgv.Columns.Add(columna1);
                        dgv.Columns.Add(columna2);
                        

                        //Seteo estado al nuevo cliente
                        cliente.Estado = (estadoClienteQueLlega(Convert.ToString(filaAnterior.Cells[11].Value), Convert.ToString(filaAnterior.Cells[15]), Convert.ToInt16(filaAnterior.Cells[12].Value), Convert.ToInt16(filaAnterior.Cells[16]))).ToString();
                        //Seteo la celda
                        fila.Cells[dgv.Columns.Count - 2].Value = cliente.Estado;

                        //Seteo hora de llegada del nuevo cliente
                        cliente.HoraLlegada = Convert.ToDouble(fila.Cells[0].Value);
                        //Seteo la celda
                        fila.Cells[dgv.Columns.Count - 1].Value = (cliente.HoraLlegada).ToString();

                    }
                    else
                    {
                        if (pintar==valor2)
                        {
                            double i = 9999999999999999999; //Para controlar quién pasa a ser atendido de los que estan esperando
                            int indice=-1;
                            //Actualizo el estado de cada cliente
                            foreach (DataGridViewCell celda in filaAnterior.Cells)
                            {
                                if (Convert.ToString(celda.Value)== "Siendo atendido por el Cajero 1")
                                {
                                    fila.Cells[celda.ColumnIndex].Value = "Atencion finalizada";
                                }
                                if (Convert.ToString(celda.Value) == "Siendo atendido por el Cajero 2")
                                {
                                    fila.Cells[celda.ColumnIndex].Value = celda.Value;
                                    fila.Cells[celda.ColumnIndex+1].Value = filaAnterior.Cells[celda.ColumnIndex+1].Value;
                                }
                                if (Convert.ToString(celda.Value) == "Esperando atencion del Cajero 1")
                                {
                                    
                                    if (Convert.ToDouble(filaAnterior.Cells[celda.ColumnIndex+1].Value)<i)
                                    {
                                        i = Convert.ToInt16(filaAnterior.Cells[celda.ColumnIndex + 1].Value);
                                        indice = celda.ColumnIndex + 1;
                                        //El cambio de estado lo tengo que hacer afuera del foreach, una verga
                                    }
                                    else
                                    {
                                        fila.Cells[celda.ColumnIndex].Value = "Esperando atencion del Cajero 1";
                                        fila.Cells[celda.ColumnIndex+1].Value = filaAnterior.Cells[celda.ColumnIndex+1].Value;
                                    }

                                    
                                }
                                if (Convert.ToString(celda.Value) == "Esperando atencion del Cajero 2")
                                {
                                    fila.Cells[celda.ColumnIndex].Value = celda.Value;
                                    fila.Cells[celda.ColumnIndex + 1].Value = filaAnterior.Cells[celda.ColumnIndex + 1].Value;
                                }
                            }
                            if (indice!=-1)
                            {
                                fila.Cells[indice - 1].Value = "Siendo atendido por el Cajero 1";
                                fila.Cells[indice].Value = filaAnterior.Cells[indice].Value;
                            }
                            

                        }
                        else //por acaaaaaaaaaaaaaaaaaa quedeeeeeeeeeeeeeeeeeeeee
                        {
                            //aca todo lo que pasa con los clientes si hay un fin de servicio del cajero 2, parecido al if anterior

                        }
                        
                    }
                  
                    controlReloj = Convert.ToDouble(fila.Cells[4].Value);
                }

                //saco el botón de la cabecera de cada columna que permitía ordenar
                for (int i = 0; i < dgv.Columns.Count - 1; i++)
                {
                    dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                //Insertamos nueva fila efectivamente
                dgv.Rows.Add(fila);

            } while (tiempoAIterar>controlReloj);

            idCliente = 1;

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

        int aQueColaVa(int colaCajero1, int colaCajero2)
        {
            if (colaCajero1<=colaCajero2)
            {
                return 1;
            }
            else
            {
                return 2;
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
            if (estadoAnterior=="Libre")
            {
                resultado = ocioAnterior + (relojActual - relojAnterior);
            }
            else
            {
                resultado = ocioAnterior;
            }

            return resultado;
        }
        string estadoClienteQueLlega(string estadoAnteriorCajero1, string estadoAnteriorCajero2, int colaAnteriorCajero1, int colaAnteriorCajero2)
        {
            string estadoCliente;
            if (estadoAnteriorCajero1=="Libre" || estadoAnteriorCajero2=="Libre")
            {
                if (estadoAnteriorCajero1=="Libre")
                {
                    estadoCliente = "Siendo atendido por el Cajero 1";
                }
                else
                {
                    estadoCliente = "Siendo atendido por el Cajero 2";
                }
            }
            else //los dos cajeros ocupados
            {
                if (aQueColaVa(colaAnteriorCajero1,colaAnteriorCajero2)==1)
                {
                    estadoCliente = "Esperando atencion del Cajero 1";
                }
                else
                {
                    estadoCliente = "Esperando atencion del Cajero 2";
                }
                                
            }
            return estadoCliente;
        }

        
       
    }
}
