using AplicacionFinal.Datos;
using AplicacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Controles
{
    class Ctrl_Cuenta
    {
        Ctrl_Mayor Mayores = new Ctrl_Mayor();


        internal void AgregarHaber(string cuenta, double monto)
        {
            DataCuenta DataCuenta = new DataCuenta();

            if (Mayores.MayorNuevo(cuenta))
            {
                Mayores.CrearNuevohaber(cuenta, monto);
            }
            else
            {
                Mayores.ActualizarHaber(cuenta, monto);
            }

            DataCuenta.CrearCuenta(cuenta, 0, monto);
        }

        internal void AgregarDebe(string cuenta, double monto)
        {
            DataCuenta DataCuenta = new DataCuenta();

            if (Mayores.MayorNuevo(cuenta))
            {
                Mayores.CrearNuevo(cuenta, monto);
            }
            else
            {
                Mayores.ActualizarDebe(cuenta, monto);
            }

            DataCuenta.CrearCuenta(cuenta, monto, 0);

        }

        internal void calculariva()
        {
            DataMayores mayores = new DataMayores();

            mayores.CerrarIvas();

        }

        internal void agregarFaltante()
        {
            DataAsientoFicha ficha = new DataAsientoFicha();

            AgregarDebe("Faltante de Mercaderia", ficha.traerFaltante());
            AgregarHaber("Mercaderia", ficha.traerFaltante());
        }
        internal void agregarSobrante()
        {
            DataAsientoFicha ficha = new DataAsientoFicha();

            AgregarDebe("Mercaderia", ficha.traerSobrante());
            AgregarHaber("Sobrante de Mercaderia", ficha.traerSobrante());
        }

        internal Cuenta traercuenta(string cuenta)
        {
            DataCuenta DataCuenta = new DataCuenta();

            return DataCuenta.trarCuenta(cuenta);
        }
    }
}
