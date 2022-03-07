using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Datos
{
    public class DatoConexion
    {
        public readonly SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-D8TPKQ6\\SQLEXPRESS;Initial Catalog=FinalEconomia;Integrated Security=True");

        public void Conectar()
        {
            cnn.Open();
        }

        public void Desconectar()
        {
            cnn.Close();
        }

        public SqlConnection Con()
        {
            return cnn;
        }

    }
}
