using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1
{
    class Prestamo
    {
        int carnet_del_Alumno;
        int codigo_Libro;
        DateTime fecha_Prestamo;
        DateTime fecha_Devolucion;

        public int Carnet_del_Alumno { get => carnet_del_Alumno; set => carnet_del_Alumno = value; }
        public int Codigo_Libro { get => codigo_Libro; set => codigo_Libro = value; }
        public DateTime Fecha_Prestamo { get => fecha_Prestamo; set => fecha_Prestamo = value; }
        public DateTime Fecha_Devolucion { get => fecha_Devolucion; set => fecha_Devolucion = value; }
    }
}
