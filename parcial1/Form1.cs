using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial1
{
    public partial class Form1 : Form
    {
        List<Prestamo> prestamos = new List<Prestamo>();
        List<Listado> lista = new List<Listado>();
        List<Alumno> alumnos = new List<Alumno>();
        List<Libro> libros = new List<Libro>();



        public Form1()
        {
            InitializeComponent();
            Leer();
            Leer2();
            Leer3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prestamo presTemp = new Prestamo();
            presTemp.Carnet_del_Alumno = Int32.Parse(textBox1.Text);
            presTemp.Codigo_Libro = Int32.Parse(textBox2.Text);
            presTemp.Fecha_Prestamo = monthCalendar1.SelectionStart;
            presTemp.Fecha_Devolucion = monthCalendar2.SelectionStart;
           prestamos.Add(presTemp);
            FileStream stream = new FileStream("prestamos.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var p in prestamos)
            {
                writer.WriteLine(p.Carnet_del_Alumno);
                writer.WriteLine(p.Codigo_Libro);
                writer.WriteLine(p.Fecha_Prestamo);
                writer.WriteLine(p.Fecha_Devolucion);
            }
            writer.Close();
            textBox1.Text = "";
            textBox2.Text = "";

        }
        private void Leer()
        {
            FileStream stream = new FileStream("prestamos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Prestamo prestamoTemp = new Prestamo();

                prestamoTemp.Carnet_del_Alumno = Int32.Parse(reader.ReadLine());
                prestamoTemp.Codigo_Libro = Int32.Parse(reader.ReadLine());
                prestamoTemp.Fecha_Prestamo = Convert.ToDateTime(reader.ReadLine());
                prestamoTemp.Fecha_Devolucion= Convert.ToDateTime(reader.ReadLine());
                prestamos.Add(prestamoTemp);
            }
            reader.Close();
        }
        private void Leer2()
        {
            FileStream stream = new FileStream("libros.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Libro libroTemp = new Libro();

              libroTemp.Codigo = Int32.Parse(reader.ReadLine());
                libroTemp.Titulo = reader.ReadLine();
                libroTemp.Autor= reader.ReadLine();
              libroTemp.Año= Int32.Parse(reader.ReadLine());
               
                libros.Add(libroTemp);
            }
            reader.Close();
        }
        private void Leer3()
        {
            FileStream stream = new FileStream("estudiantes.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alumno esTemp = new Alumno();

                esTemp.Carnet = Int32.Parse(reader.ReadLine());
              esTemp.Nombre= reader.ReadLine();
                esTemp.Direccion = reader.ReadLine();
               

                alumnos.Add(esTemp);
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < libros.Count; i++)
            {
                for (int j = 0; j < prestamos.Count; j++)
                {
                    if (libros[i].Codigo == prestamos[j].Codigo_Libro)
                    {
                        Listado datos = new Listado();
                        datos.Nombre = alumnos[i].Nombre;
                        datos.Titulo = libros[j].Titulo;
                        datos.Fecha_Prestamo = prestamos[i].Fecha_Prestamo;
                        datos.Fecha_Devolucion = prestamos[i].Fecha_Devolucion;
                    

                        lista.Add(datos);
                    }
                }


            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            dataGridView1.Refresh();
        }
    }
}
