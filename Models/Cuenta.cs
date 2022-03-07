using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Models
{
    public class Cuenta 
    {
        public int Cuenta_id { get; set; }
        public string Cuenta_Nombre { get; set; }
        public double Cuenta_Debe { get; set; }
        public double Cuenta_haber { get; set; }

        public string Cuenta_Tipo { get; set; }

       
    }
}
