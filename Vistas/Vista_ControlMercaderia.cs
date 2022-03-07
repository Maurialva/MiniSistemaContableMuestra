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
    public partial class Vista_ControlMercaderia : Form
    {
        int id;
        public Vista_ControlMercaderia(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void ControlMercaderia_Load(object sender, EventArgs e)
        {
           this.MaximizeBox = false;
          this.MinimizeBox = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Ctrl_Libros libro = new Ctrl_Libros();
            libro.CerrarLibro((double)numMercaderia.Value);
            this.Owner.Close();
            this.Close();
        }
    }
}
