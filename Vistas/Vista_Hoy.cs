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
    public partial class Vista_Hoy : Form
    {
        Ctrl_Libros ctrl_Libro = new Ctrl_Libros();
        public Vista_Hoy()
        {
            InitializeComponent();
        }

        private void btnLibroDiario_Click(object sender, EventArgs e)
        {
            try
            {
                Vista_LibroHoy libro = new Vista_LibroHoy();
                libro.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnFichaStock_Click(object sender, EventArgs e)
        {
            Ctrl_Libros libro = new Ctrl_Libros();
            Vista_Stock ficha = new Vista_Stock(libro.IdLibroDiario());
            ficha.ShowDialog();
        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
            Ctrl_Libros libro = new Ctrl_Libros();
            Vista_Mayor mayores = new Vista_Mayor(libro.IdLibroDiario());
            mayores.ShowDialog();
        }

        private void btnNuevoAsiento_Click(object sender, EventArgs e)
        {
            
            Vista_Asiento Asiento = new Vista_Asiento();
            Asiento.ShowDialog();
        }

        private void btnCerrarDia_Click(object sender, EventArgs e)
        {
           var result = MessageBox.Show("Tiene mercaderia?", "Esta Por cerrar la actividad",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                Ctrl_Libros libro = new Ctrl_Libros();
                Vista_ControlMercaderia cerrar = new Vista_ControlMercaderia(libro.IdLibroDiario());
                cerrar.Owner = this;
                cerrar.ShowDialog();
            }else
            {
                ctrl_Libro.CerrarLibro();
                this.Close();
            }
           

           
        }

        private void Vista_Hoy_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
