using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Models
{
    public class Stock_Asiento
    {
    
        public int Stock_Aid { set; get; }
        public DateTime Stock_Fecha { get; set; }
        public Stock_Entrada Stock_entrada { get; set; }
        public Stock_Salida Stock_salida { get; set; }
        public Stock_Saldo Stock_saldo { get; set; }
        public string Stock_Concepto { get; set; }


    }
}
