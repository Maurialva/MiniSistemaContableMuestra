using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Models
{
    public class Stock_Entrada
    {

        public int Stock_ent_id { set; get; }
        public double Entrada_precio { get; set; }

        public  long Entrada_cantidad { get; set; }
        public double Entrada_total { get; set; }

    }
}
