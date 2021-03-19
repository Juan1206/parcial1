using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1
{
    class Libro
    {
        int codigo;
        string titulo;
        string autor;
            int año;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Año { get => año; set => año = value; }
    }
}
