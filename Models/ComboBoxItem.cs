using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Models
{
    public class ComboBoxItem
    {
        int id;
        DateTime fecha;

        // Constructor
        public ComboBoxItem(int id, DateTime fecha)
        {
            this.id = id;
            this.fecha = fecha;
        }

        // Accessor
        public int IdLibro
        {
            get
            {
                return id;
            }
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Actividad de {fecha.ToString()}";
        }
    }
}
