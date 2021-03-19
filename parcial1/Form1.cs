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
            

        public Form1()
        {
            InitializeComponent();
            Leer();
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
    }
}
