using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cliente
    {
        private int id;
        private string estado;
        private double horaLlegada;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Estado
        {
            set
            {
                estado = value;
            }
            get
            {
                return estado;
            }
        }

        public double HoraLlegada
        {
            set
            {
                horaLlegada = value;
            }
            get
            {
                return horaLlegada;
            }
        }

    }
}
