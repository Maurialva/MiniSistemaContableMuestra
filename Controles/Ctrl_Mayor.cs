using AplicacionFinal.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Controles
{
    class Ctrl_Mayor
    {
        DataMayores mayores = new DataMayores();

        internal bool MayorNuevo(string cuenta)
        {
            return mayores.CuentaNueva(cuenta);
        }

        internal void CrearNuevo(string cuenta, double monto)
        {
            mayores.crearNuevo(cuenta,monto,0);
        }
        internal void CrearNuevohaber(string cuenta, double monto)
        {
            mayores.crearNuevo(cuenta, 0,monto);
        }

        internal void ActualizarHaber(string cuenta, double monto)
        {
            mayores.actualizarHaber(cuenta, monto);
        }

        internal void ActualizarDebe(string cuenta, double monto)
        {
            mayores.actualizarDebe(cuenta, monto);
        }
    }
}
