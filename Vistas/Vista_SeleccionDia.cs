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
    public partial class Vista_SeleccionDia : Form
    {
        int id ;
        public Vista_SeleccionDia(int idlibro)
        {
            this.id = idlibro;
            InitializeComponent();
        }

        private void btnFichaStock_Click(object sender, EventArgs e)
        {
           
            Vista_Stock ficha = new Vista_Stock(id);
            ficha.ShowDialog();
        }

        private void btnLibroDiario_Click(object sender, EventArgs e)
        {
            
            Vista_LibroHoy libro = new Vista_LibroHoy(id);
            libro.ShowDialog();
        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
           
            Vista_Mayor mayores = new Vista_Mayor(id);
            mayores.ShowDialog();
        }

        private void Vista_SeleccionDia_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
