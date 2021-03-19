using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1
{
    class Alumno
    {
        int carnet;
        string nombre;
        string direccion;

        public int Carnet { get => carnet; set => carnet = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
