using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Models
{
    public class Stock_Saldo
    {

        public int Stock_saldo_id { set; get; }
        public double Saldo_precio { get; set; }

        public long Saldo_cantidad { get; set; }
        public double Saldo_total { get; set; }

    }
}
