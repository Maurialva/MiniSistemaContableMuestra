using AplicacionFinal.Controles;
using AplicacionFinal.Models;
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
    public partial class Vista_Archivos : Form
    {
        public Vista_Archivos()
        {
            InitializeComponent();
        }

        private void btnLibroSeleccionado_Click(object sender, EventArgs e)
        {
            int id = ((ComboBoxItem)(cboxLibros.SelectedItem)).IdLibro;
            Vista_SeleccionDia seleccionado = new Vista_SeleccionDia(id);
            seleccionado.ShowDialog();
        }

        private void Vista_Archivos_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Ctrl_Vistas libros = new Ctrl_Vistas();
            cboxLibros = libros.ListarLibros(cboxLibros);
        }
    }
}
