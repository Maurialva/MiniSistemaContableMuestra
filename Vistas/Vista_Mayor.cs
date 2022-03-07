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
    public partial class Vista_Mayor : Form
    {
        int idlibro = 0;
        public Vista_Mayor(int v)
        {
            this.idlibro = v;
            InitializeComponent();
        }

        private void Vista_Mayor_Load(object sender, EventArgs e)
        {

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Ctrl_Vistas vista = new Ctrl_Vistas();
            dataMayores = vista.traerMayores(dataMayores, idlibro);
            foreach (DataGridViewColumn column in dataMayores.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
