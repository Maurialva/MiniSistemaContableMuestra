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
    public partial class Vista_Stock : Form
    {
        int idlibro = 0;
        public Vista_Stock(int idlibro)
        {
            this.idlibro = idlibro;
            InitializeComponent();
        }

        private void Vista_Stock_Load(object sender, EventArgs e)
        {


            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Ctrl_Vistas vista = new Ctrl_Vistas();
            dataFichaStock = vista.traerFicha(dataFichaStock,idlibro);
            foreach (DataGridViewColumn column in dataFichaStock.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
           
            



        }
    }
}
