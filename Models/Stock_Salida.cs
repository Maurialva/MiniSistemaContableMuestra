using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Models
{
    public class Stock_Salida
    {
        public int Stock_salida_id { set; get; }
        public double Salida_precio { get; set; }

        public long Salida_cantidad { get; set; }
        public double Salida_total { get; set; }

    }
}
