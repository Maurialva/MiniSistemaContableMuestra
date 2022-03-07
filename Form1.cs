using AplicacionFinal.Controles;
using AplicacionFinal.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionFinal
{
    public partial class formInicio : Form
    {
        Ctrl_Libros libros = new Ctrl_Libros();

        public formInicio()
        {
            
            InitializeComponent();
        }

        private void ClickHoy(object sender, EventArgs e)
        {
            bool abrir = false;
            if (!libros.HayActivo())
            {
                var result = MessageBox.Show("Desea crear uno?", "No hay un libro diario abierto",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                
                if (result == DialogResult.Yes)
                {
                    libros.CrearLibro();
                    abrir = true;
                }
            }else
            {
                abrir = true;
            }
            if (abrir)
            {
                Vista_Hoy hoy = new Vista_Hoy();
                hoy.ShowDialog();
            }
           
        }

        private void btnLibroDiario_Click(object sender, EventArgs e)
        {
            Vista_Archivos libros = new Vista_Archivos();
            libros.ShowDialog();
        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
          //  Vista_Mayor mayor = new Vista_Mayor();
           // mayor.ShowDialog();

        }

        private void btnFichaStock_Click(object sender, EventArgs e)
        {
          //  Vista_Stock stock = new Vista_Stock();
           // stock.ShowDialog();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
          //  Vista_SeleccionDia balance = new Vista_SeleccionDia();
           // balance.ShowDialog();
        }

        private void btnMenuArchivado_Click(object sender, EventArgs e)
        {
            Vista_Archivos archivos = new Vista_Archivos();
            archivos.ShowDialog();
        }

        private void formInicio_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
