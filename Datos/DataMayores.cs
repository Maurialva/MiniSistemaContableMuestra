using AplicacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Datos
{
    public class DataMayores
    {
        
        public DataLibroDiario Libro = new DataLibroDiario();

        public DatoConexion cnn = new DatoConexion();
        internal bool CuentaNueva(string cuenta)
        {
            int id = 0;
            string nombre=cuenta.Replace("\"", "'");
            int idLibro = Libro.IdLibroActivo();
            cnn.Conectar();
            string query = "select top 1 Mayor_Id from Mayores where Mayor_Nombre=@cuenta and Mayor_LibroId=@id order by Mayor_Id desc ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@cuenta", cuenta);
            cmd.Parameters.AddWithValue("@id", idLibro);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["Mayor_Id"]);
            }
            
            cnn.Desconectar();

            if (id == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void actualizarDebe(string cuenta, double monto)
        {
            int idlibro = Libro.IdLibroActivo();
            double debe = this.Debe(cuenta);
            cnn.Conectar();
            string query = "Update Mayores set Mayor_Debe=@debe where Mayor_LibroId=@id and Mayor_Nombre=@nombre";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id",idlibro);
            cmd.Parameters.AddWithValue("@nombre",cuenta);
            cmd.Parameters.AddWithValue("@debe",debe+monto);
            cmd.ExecuteNonQuery();
            cnn.Desconectar();
        }

        internal void CerrarIvas()
        {
            Cuenta credito = new Cuenta();
            int idlibro = Libro.IdLibroActivo();
            string cuenta = "Iva Debito Fiscal";
            cnn.Conectar();
            string query = "select top 1 * from Mayores where Mayor_Nombre=@cuenta and Mayor_LibroId=@id order by Mayor_Id desc ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@cuenta", cuenta);
            cmd.Parameters.AddWithValue("@id", idlibro);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                credito.Cuenta_Debe = Convert.ToDouble(reader["Mayor_Debe"]);
                credito.Cuenta_haber = Convert.ToDouble(reader["Mayor_Haber"]);
                credito.Cuenta_Nombre = Convert.ToString(reader["Mayor_Nombre"]);

            }
            cnn.Desconectar();

            Cuenta ivadebito = new Cuenta();
            ivadebito.Cuenta_Nombre = "Iva Debito Fiscal";
            ivadebito.Cuenta_Tipo = "P";
            if (credito.Cuenta_Debe<credito.Cuenta_haber)
            {
                
               
                ivadebito.Cuenta_Debe = credito.Cuenta_haber - credito.Cuenta_Debe;
                ivadebito.Cuenta_haber = 0;
            }
            else
            {
                if (credito.Cuenta_Debe > credito.Cuenta_haber)
                {
                   
                   
                    ivadebito.Cuenta_Debe = 0;
                    ivadebito.Cuenta_haber =  credito.Cuenta_Debe - credito.Cuenta_haber;
                }
                else
                {
                  
                    ivadebito.Cuenta_Debe = 0;
                    ivadebito.Cuenta_haber =0;
                }
            }

            cuenta = "Iva Credito Fiscal";
            cnn.Conectar();
            string query2 = "select top 1 * from Mayores where Mayor_Nombre=@cuenta and Mayor_LibroId=@id order by Mayor_Id desc ";
            SqlCommand cmd2 = new SqlCommand(query2, cnn.Con());
            cmd2.Parameters.AddWithValue("@cuenta", cuenta);
            cmd2.Parameters.AddWithValue("@id", idlibro);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                credito.Cuenta_Debe = Convert.ToDouble(reader2["Mayor_Debe"]);
                credito.Cuenta_haber = Convert.ToDouble(reader2["Mayor_Haber"]);
                credito.Cuenta_Nombre = Convert.ToString(reader2["Mayor_Nombre"]);

            }


            Cuenta ivacredito = new Cuenta();
            ivacredito.Cuenta_Nombre = "Iva Credito Fiscal";
            ivacredito.Cuenta_Tipo = "A";
            if (credito.Cuenta_Debe > credito.Cuenta_haber)
            {

               
                ivacredito.Cuenta_Debe = 0;
                ivacredito.Cuenta_haber = credito.Cuenta_Debe - credito.Cuenta_haber;
            }
            else
            {
                if (credito.Cuenta_Debe > credito.Cuenta_haber)
                {
                    ivacredito.Cuenta_Debe = credito.Cuenta_haber - credito.Cuenta_Debe;
                    ivacredito.Cuenta_haber = 0;
                }
                else
                {  
                    ivacredito.Cuenta_Debe = 0;
                    ivacredito.Cuenta_haber = 0;
                }
            }
            
            if (ivadebito.Cuenta_Debe>0)
            {
                DataCuenta data = new DataCuenta();
                data.CrearCuenta(ivadebito.Cuenta_Nombre,ivadebito.Cuenta_Debe,ivadebito.Cuenta_haber);
                if (ivacredito.Cuenta_haber>0)
                {
                    if (ivadebito.Cuenta_Debe> ivacredito.Cuenta_haber)
                    {
                        data.CrearCuenta("Iva a pagar", 0, ivadebito.Cuenta_Debe - ivacredito.Cuenta_haber);
                        data.CrearCuenta(ivacredito.Cuenta_Nombre, ivacredito.Cuenta_Debe, ivacredito.Cuenta_haber);
                    }
                    else
                    {
                        if (ivacredito.Cuenta_haber > ivadebito.Cuenta_Debe)
                        {
                            data.CrearCuenta("Iva Saldo a Favor", ivacredito.Cuenta_haber - ivadebito.Cuenta_Debe,0);
                            data.CrearCuenta(ivacredito.Cuenta_Nombre, ivacredito.Cuenta_Debe, ivacredito.Cuenta_haber);
                        }
                        else
                        {
                            data.CrearCuenta(ivacredito.Cuenta_Nombre, ivacredito.Cuenta_Debe, ivacredito.Cuenta_haber);
                        }
                    }

                }
                else
                {
                    data.CrearCuenta("Iva Saldo a Favor", ivacredito.Cuenta_haber - ivadebito.Cuenta_Debe, 0);
                    data.CrearCuenta(ivacredito.Cuenta_Nombre, ivacredito.Cuenta_Debe, ivacredito.Cuenta_haber);
                }

            }



            cnn.Desconectar();

            
        }

        internal void actualizarHaber(string cuenta, double monto)
        {
            int idlibro = Libro.IdLibroActivo();
            double haber = this.Haber(cuenta);
            cnn.Conectar();
            string query = "Update Mayores set Mayor_Haber=@haber where Mayor_LibroId=@id and Mayor_Nombre=@nombre";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", idlibro);
            cmd.Parameters.AddWithValue("@nombre", cuenta);
            cmd.Parameters.AddWithValue("@haber", haber + monto);
            cmd.ExecuteNonQuery();
            cnn.Desconectar();
        }

       

        internal void crearNuevo(string cuenta, double debe, double haber)
        {
            int idlibro = Libro.IdLibroActivo();
            cnn.Conectar();
            string query = "insert into Mayores values(@Mayor_LibroId,@Mayor_Nombre,@Mayor_Debe,@Mayor_Haber)";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@Mayor_LibroId", idlibro);
            cmd.Parameters.AddWithValue("@Mayor_Nombre", cuenta);
            cmd.Parameters.AddWithValue("@Mayor_Debe", debe);
            cmd.Parameters.AddWithValue("@Mayor_Haber", haber);
            cmd.ExecuteNonQuery();
            cnn.Desconectar();
        }

        internal double Debe(string cuenta)
        {
            double debe = 0;
            int idlibro = Libro.IdLibroActivo();
            cnn.Conectar();
            string query = "select top 1 Mayor_Debe from Mayores where Mayor_LibroId=@id and Mayor_Nombre=@nombre order by Mayor_Id desc ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", idlibro);
            cmd.Parameters.AddWithValue("@nombre",cuenta);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                debe = Convert.ToDouble(reader["Mayor_Debe"]);
            }
            
            cnn.Desconectar();

            return debe;

        }
        private double Haber(string cuenta)
        {
            double haber = 0;
            int idlibro = Libro.IdLibroActivo();
            cnn.Conectar();
            string query = "select top 1 Mayor_Haber from Mayores where Mayor_LibroId=@id and Mayor_Nombre= @nombre order by Mayor_Id desc ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", idlibro);
            cmd.Parameters.AddWithValue("@nombre", cuenta);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                haber = Convert.ToDouble(reader["Mayor_Haber"]);
            }
            
            cnn.Desconectar();

            return haber;
        }
    }
}
