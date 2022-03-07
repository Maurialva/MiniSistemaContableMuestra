using AplicacionFinal.Datos;
using AplicacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Controles
{
    class Ctrl_FichaStock
    {
        
        public  void CrearAsientoEntrada(string transaccion, double cantidad, double monto)
        {
            DataAsientoFicha asiento = new DataAsientoFicha();
            if (asiento.ExistenciaInicial())
            {
                asiento.crearExistencia();
                asiento.crearAsiento(transaccion, cantidad, monto/cantidad, 0, 0, 0, 0);
            } else
            {
                asiento.crearAsiento(transaccion, cantidad, monto / cantidad, 0, 0, 0, 0);
            }
        }

        internal void CerrarMercaderia(double cantidad)
        {
            DataAsientoFicha asiento = new DataAsientoFicha();
            asiento.CerrarMercaderia(cantidad);
        }

        internal void CrearAsientoSalida(string transaccion, double cantidad, double monto)
        {
            DataAsientoFicha asiento = new DataAsientoFicha();
            asiento.crearAsiento(transaccion, 0, 0, cantidad, monto / cantidad, 0, 0);

        }

        internal double TraerCMV(double cantidad)
        {
            DataAsientoFicha asiento = new DataAsientoFicha();
            return asiento.traerCMW(cantidad);

        }

        public void CrearFicha(int idlibro)
        {
            DataFichaStock ficha = new DataFichaStock();

            ficha.crearFicha(idlibro);

        }

    }
}
