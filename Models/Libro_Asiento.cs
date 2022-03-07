using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Models
{
    public class Libro_Asiento 
    {
        public int Asiento_id { get; set; }
        public List<Cuenta> Asiento_cuenta { get; set; }

        public DateTime Fecha { get; set; }


        
    }
}
