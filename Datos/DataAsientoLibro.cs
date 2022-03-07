using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Datos
{
    public class DataAsientoLibro
    {
        public DatoConexion cnn = new DatoConexion();
        public DataLibroDiario libroDiario = new DataLibroDiario();
        public DataAsientoFicha ficha = new DataAsientoFicha();
        
        public void CrearAsiento()
        {
            int idlibro = libroDiario.IdLibroActivo();
            cnn.Conectar();
            string query = "insert into Asientos_Libro values(@Asiento_LibroId,@Asiento_Fecha)";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@Asiento_LibroId", idlibro);
            cmd.Parameters.AddWithValue("@Asiento_Fecha", DateTime.Now) ;
            SqlDataReader reader = cmd.ExecuteReader();
            cnn.Desconectar();
        }

        public int IdAsiento()
        {
            int idAsiento = 0;
            int idlibro = libroDiario.IdLibroActivo();
            cnn.Conectar();
            string query = "select top 1 Asiento_Id from Asientos_Libro where Asiento_LibroId=@id order by Asiento_Id desc ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", idlibro);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idAsiento = Convert.ToInt32(reader["Asiento_Id"]);
            }
            
            cnn.Desconectar();
            return idAsiento;
        }

        internal string reguralizarMercaderia()
        {
            string concepto = "";
            concepto = ficha.ComprobarCierre();
            return concepto;
        }
    }
}
