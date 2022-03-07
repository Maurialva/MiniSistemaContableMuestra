using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Models
{
    public class Libro_Diario
    {

        public int Libro_id { get; set; }

        public List<Libro_Asiento> Libro_asientos { get; set; }

        public List<Mayor_Cuenta> Libro_mayores { get; set; }

        public Stock_Ficha Libro_Stock_Ficha { get; set; }

        public bool Libro_Activo { get; set; }
         public DateTime Libro_Fecha { get; set; }

        

    }
}
