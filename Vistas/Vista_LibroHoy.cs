using AplicacionFinal.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionFinal.Vistas
{
    public partial class Vista_LibroHoy : Form
    {
        Ctrl_Libros libro = new Ctrl_Libros();
        int id =0;
        public Vista_LibroHoy(int idlibro)
        {
            this.id= idlibro;
            InitializeComponent();
        }
        public Vista_LibroHoy()
        {
            InitializeComponent();
        }
        private void Vista_LibroHoy_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Ctrl_Vistas vista = new Ctrl_Vistas();
            if (id==0)
            {
                
                dataLibro = vista.traerLibroHoy(dataLibro);
            }
            else
            {
                dataLibro = vista.traerLibro(dataLibro, id);
            }
            
            foreach (DataGridViewColumn column in dataLibro.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DataGridViewColumn var = dataLibro.Columns[1];
            var.Width = 40;

        }


    }
}
