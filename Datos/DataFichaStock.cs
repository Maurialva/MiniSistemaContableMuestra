using AplicacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Datos
{
    public class DataFichaStock
    {
       
        public DataLibroDiario libroDiario = new DataLibroDiario();
        public DatoConexion cnn = new DatoConexion();

        internal int IdFicha()
        {
            int idFicha = 0;
            int idlibro = libroDiario.IdLibroActivo();
            cnn.Conectar();
            string query = "select top 1 Stock_Id from Stocks where Stock_LibroId=@id order by Stock_Id desc ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", idlibro);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idFicha = Convert.ToInt32(reader["Stock_Id"]);
            }
            
            cnn.Desconectar();
            return idFicha;
        }

        internal void crearFicha(int idlibro)
        {
            cnn.Conectar();
            string query = "insert into Stocks (Stock_LibroId) values(@id) ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", idlibro);
            cmd.ExecuteNonQuery();
            cnn.Desconectar();
        }
    }
}
