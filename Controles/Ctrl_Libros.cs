using AplicacionFinal.Datos;
using AplicacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionFinal.Controles
{
    public class Ctrl_Libros 
    {
        DataLibroDiario datos = new DataLibroDiario();


        public void CrearLibro()
        {
            Ctrl_FichaStock fichaStock = new Ctrl_FichaStock();

            datos.crearLibro();
            fichaStock.CrearFicha(datos.IdLibroActivo());
        }

        public void CerrarLibro(double cantidad)
        {
           
            Ctrl_FichaStock fichaStock = new Ctrl_FichaStock();

            fichaStock.CerrarMercaderia(cantidad);
            Ctrl_Asientos asientos = new Ctrl_Asientos();
            asientos.RegularizadorMercaderia();
            Ctrl_Cuenta cuenta = new Ctrl_Cuenta();
            cuenta.calculariva();
            datos.CerrarLibro();


        }

        internal List<Libro_Asiento> LibrodeHoy()
        {

            return datos.CargarAsientos(datos.IdLibroActivo());
        }

        internal bool HayActivo()
        {
            if (datos.IdLibroActivo()!=0)
            {
                return true;
            }
            return false;
        }

       

        public int IdLibroDiario()
        {
            return datos.IdLibroActivo();
        }
        public Libro_Diario TraerLibroActivo()
        {
            return datos.LibrodeHoy();
        }

        internal void CerrarLibro()
        {
            Ctrl_Cuenta cuenta = new Ctrl_Cuenta();
            cuenta.calculariva();
            datos.CerrarLibro();
        }
    }
}
