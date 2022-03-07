using AplicacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Datos
{
    public class DataCuenta
    {

       
        DataAsientoLibro Asiento = new DataAsientoLibro();
        public DatoConexion cnn = new DatoConexion();
        internal void CrearCuenta(string cuenta, double debe, double haber)
        {
            string tipo = this.TraerTipo(cuenta);
            int id = Asiento.IdAsiento();
            cnn.Conectar();
            string query = "insert into Cuentas (Cuenta_AsientoId,Cuenta_Nombre,Cuenta_Debe,Cuenta_Haber,Cuenta_Tipo)  values (@Cuenta_AsientoId,@Cuenta_Nombre,@Cuenta_Debe,@Cuenta_Haber,@Cuenta_Tipo)";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@Cuenta_AsientoId", id);
            cmd.Parameters.AddWithValue("@Cuenta_Nombre", cuenta);
            cmd.Parameters.AddWithValue("@Cuenta_Debe", debe);
            cmd.Parameters.AddWithValue("@Cuenta_Haber", haber);
            cmd.Parameters.AddWithValue("@Cuenta_Tipo", tipo);
            cmd.ExecuteNonQuery();
            cnn.Desconectar();
        }

        private string TraerTipo(string cuenta)
        {
            string tipo = "";
            cnn.Conectar();
            string query = "select top 1 TipoCuenta_Cod from TiposDeCuenta where TipoCuenta_Nombre=@cuenta order by TipoCuenta_Cod desc ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@cuenta", cuenta);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tipo = Convert.ToString(reader["TipoCuenta_Cod"]);
            }
            
            cnn.Desconectar();
            return tipo;
        }

        internal Cuenta trarCuenta(string cuenta)
        {
            Cuenta cuentauso = new Cuenta();
            
            cnn.Conectar();
            string query = "select top 1 * from Cuentas where Cuenta_Nombre=@cuenta order by Cuenta_Id desc ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@cuenta", cuenta);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cuentauso.Cuenta_id = Convert.ToInt32(reader["Cuenta_Id"]);
                cuentauso.Cuenta_Nombre = Convert.ToString(reader["Cuenta_Id"]);
                cuentauso.Cuenta_Debe = Convert.ToDouble(reader["Cuenta_Debe"]);
                cuentauso.Cuenta_haber = Convert.ToDouble(reader["Cuenta_Haber"]);
                cuentauso.Cuenta_Tipo = Convert.ToString(reader["Cuenta_Tipo"]);
            }

            cnn.Desconectar();
            return cuentauso;
        }
    }
}
