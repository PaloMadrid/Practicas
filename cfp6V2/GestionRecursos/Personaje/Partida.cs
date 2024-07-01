using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mis_librerias
{
    internal class Partida
    {
        string nombre;
        int dias;

        public Partida(string nombre, int dias)
        {
            this.nombre = nombre;
            this.dias = dias;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Dias { get => dias; set => dias = value; }

        
    }
}
