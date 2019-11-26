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

        decimal tiempoEntreLlegadas(int frecuencia)
        {
            //Creo random 0-1
            Random _Random = new Random();
            double rnd = _Random.NextDouble();

            double frecuenciaClientesPorMinuto = frecuencia*0.016666666666;
            double x;
            double cociente;
            cociente = -1 / frecuenciaClientesPorMinuto;
            x = cociente * Math.Log(1 - rnd);
            decimal redondeado = (decimal)Math.Round(x, 3);
            return redondeado;
        }

        decimal tiempoCajero1(double media)
        {
            Random _Random = new Random();
            double rnd = _Random.NextDouble();

            double x = (double)(-media) * Math.Log(1 - rnd);
            decimal redondeado = (decimal)Math.Round(x, 3);
            return redondeado;
        }
        decimal tiempoCajero2(double a, double b)
        {
            Random _Random = new Random();
            double rnd = _Random.NextDouble();

            double x = (rnd * (b - a)) + a;
            decimal redondeado = (decimal)Math.Round(x, 3);
            return redondeado;
        }

        //private void btnCajero1_Click(object sender, EventArgs e)
        //{
            
        //    double x = float.Parse(txtBoxMedia.Text, CultureInfo.CreateSpecificCulture("en-US"));
        //    lblCajero1.Text = tiempoCajero1(x).ToString();
        //    //lblCajero1.Text = tiempoCajero1(Convert.ToDouble(txtBoxMedia.Text)).ToString();
        //}

        //private void btnCajero2_Click(object sender, EventArgs e)
        //{
        //    double a = float.Parse(txtBoxA.Text, CultureInfo.CreateSpecificCulture("en-US"));
        //    double b = float.Parse(txtBoxB.Text, CultureInfo.CreateSpecificCulture("en-US"));
        //    lblCajero2.Text = tiempoCajero2(a, b).ToString();

        //}
    }
}
