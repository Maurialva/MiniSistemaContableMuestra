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
    public partial class Vista_Asiento : Form
    {
        Ctrl_Vistas vista = new Ctrl_Vistas();
        public Vista_Asiento()
        {
            InitializeComponent();
        }

        private void Vista_Cuenta_Load(object sender, EventArgs e)
        {

            cbMetodoPago.DataSource = vista.metodosdepago();
            cmMetodo2.DataSource = vista.metodosdepago();


            this.MaximizeBox = false;
            this.MinimizeBox = false;
            lblCantidad.Hide();
            lblPorcentaje1.Hide();
            cmMetodo2.Hide();
            lblMetodo2.Hide();
            numCantidad.Hide();
            numMetodo1.Hide();
            cbCuenta.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (cbCuenta.Enabled==false || txtMonto.Text=="")
            {
                MessageBox.Show($"Por Favor Rellene las Casillas");
            }
            else
            {
                double parsedValue;
                if (!double.TryParse(txtMonto.Text, out parsedValue))
                {
                    MessageBox.Show("Por Favor Ingrese un Numero");
                    return;
                }
                else
                {
                    if (double.Parse(txtMonto.Text)<=0)
                    {
                        MessageBox.Show("Por Favor Ingrese un Numero Positivo");
                    }else
                    {
                        Ctrl_Asientos Asiento = new Ctrl_Asientos();
                        Asiento.nuevoAsiento(cbCuenta.Text,cbTransaccion.Text,cbMetodoPago.Text,cmMetodo2.Text,(double)numMetodo1.Value, (double)numCantidad.Value, checkMetodo.Checked, double.Parse(txtMonto.Text));
                        MessageBox.Show("Transaccion Cargada");
                        this.Close();
                    }
                }
                         
            }
         

        }

        private void cbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransaccion.Text == "Compra" || cbTransaccion.Text == "Venta")
            {
                cbCuenta.Enabled=true;
               cbCuenta.DataSource = vista.Bienes();
            }
            else
            {
                if (cbTransaccion.Text == "Devolucion por Compra"|| cbTransaccion.Text == "Devolucion por Venta" )
                {
                    cbCuenta.Enabled = true;
                    cbCuenta.DataSource = vista.Devoluciones();
                }
                else
                {
                    cbCuenta.Enabled = true;
                    cbCuenta.DataSource = vista.Ingresos();
                }
            }
            
        }

        private void cbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            if (cbCuenta.Text == "Mercaderia" || cbCuenta.Text =="Moneda extranjera")
            {
                lblCantidad.Show();

                numCantidad.Show();


            }
            else
            {
                lblCantidad.Hide();

                numCantidad.Hide();
            }
        }

        private void checkMetodo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMetodo.Checked)
            {
                lblMetodo1.Text = "Metodo de Pago 1";
                lblMetodo2.Show();
                cmMetodo2.Show();
              
                numMetodo1.Show();
                lblPorcentaje1.Show();
                
            }
            else
            {
                lblMetodo1.Text = "Metodo de Pago";
                cmMetodo2.Hide();
                lblMetodo2.Hide();
            
                numMetodo1.Hide();
                lblPorcentaje1.Hide();
              
            }
        }
    }
}
