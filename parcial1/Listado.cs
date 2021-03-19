using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1
{
    class Listado
    {
        string nombre;
        string titulo;
        DateTime fecha_Prestamo;
        DateTime fecha_Devolucion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime Fecha_Prestamo { get => fecha_Prestamo; set => fecha_Prestamo = value; }
        public DateTime Fecha_Devolucion { get => fecha_Devolucion; set => fecha_Devolucion = value; }
    }
}
