using AplicacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Datos
{
    public class DataLibroDiario
    {
        
        
        public DatoConexion cnn = new DatoConexion();
       

        public List<Libro_Diario> Listar()
        {

            List<Libro_Diario> libros = new List<Libro_Diario>();
            try
            {
             cnn.Conectar();
            const string query = "select * from Libro_Diario";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Libro_Diario Libro_Diario = new Libro_Diario
                {
                    Libro_id = Convert.ToInt32(reader["Libro_Id"]),
                    Libro_Activo = Convert.ToBoolean(reader["Libro_Estado"]),
                    Libro_Fecha = Convert.ToDateTime(reader["Libro_Fecha"]),
                };

                libros.Add(Libro_Diario);
            }
               
                cnn.Desconectar();
         
            }
            catch (Exception)
            {

                throw;
            }
           
            return libros;
        }

        

        public Stock_Ficha CargarFichaStock(int id)
        {
            Stock_Ficha Stock_Ficha = new Stock_Ficha();

            cnn.Conectar();
            const string query = "Select * from Stocks where Stock_LibroId=@id";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Stock_Ficha Stock = new Stock_Ficha
                {
                    Stock_Id = Convert.ToInt32(reader["Stock_Id"]),

                };
                Stock_Ficha=Stock;
            }
            
            cnn.Desconectar();
            Stock_Ficha.Stock_Asientos = CargarAsientosStock(Stock_Ficha.Stock_Id);
            return Stock_Ficha;
        }

        public List<Stock_Asiento> CargarAsientosStock(int id)
        {
            List < Stock_Asiento > Stocks_Asientos = new List<Stock_Asiento>();

            cnn.Conectar();
            const string query = "select * from AsientoStock inner join Entrada_Ficha on AsientoStock.AsientoF_Id= Entrada_Ficha.Entrada_AsientoId inner join Saldo_Stock on AsientoStock.AsientoF_Id = Saldo_Stock.Saldo_AsientoId inner join Salidas_Ficha on AsientoStock.AsientoF_Id = Salidas_Ficha.Salida_AsientoId  where AsientoF_StockId=@id";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Stock_Entrada Stock_Entrada = new Stock_Entrada
                {
                    Stock_ent_id = Convert.ToInt32(reader["Entrada_Id"]),
                    Entrada_cantidad = Convert.ToInt64(reader["Entrada_Cantidad"]),
                    Entrada_precio=Convert.ToDouble(reader["Entrada_Precio"]),
                    Entrada_total = Convert.ToDouble(reader["Entrada_total"]),
                };

                Stock_Saldo Stock_Saldo = new Stock_Saldo
                {
                    Stock_saldo_id = Convert.ToInt32(reader["Saldo_Id"]),
                    Saldo_cantidad = Convert.ToInt64(reader["Saldo_Cantidad"]),
                    Saldo_precio = Convert.ToDouble(reader["Saldo_Precio"]),
                    Saldo_total = Convert.ToDouble(reader["Saldo_total"]),
                };
                Stock_Salida Stock_Salida = new Stock_Salida
                {
                    Stock_salida_id = Convert.ToInt32(reader["Salida_Id"]),
                    Salida_cantidad = Convert.ToInt64(reader["Salida_Cantidad"]),
                    Salida_precio = Convert.ToDouble(reader["Salida_Precio"]),
                    Salida_total = Convert.ToDouble(reader["Salida_total"]),
                };

                Stock_Asiento Stock_Asiento = new Stock_Asiento
                {
                    Stock_Aid = Convert.ToInt32(reader["AsientoF_Id"]),
                    Stock_Fecha = Convert.ToDateTime(reader["AsientoF_Fecha"]),
                    Stock_Concepto=Convert.ToString(reader["AsientoF_Concepto"]),

                };
                Stock_Asiento.Stock_entrada = Stock_Entrada;
                Stock_Asiento.Stock_salida = Stock_Salida;
                Stock_Asiento.Stock_saldo = Stock_Saldo;
               Stocks_Asientos.Add(Stock_Asiento);
            }
            
            cnn.Desconectar();

            

            return Stocks_Asientos;
        }

        public List<Libro_Asiento> CargarAsientos(int id)
        {
            List<Libro_Asiento> Libros_Asientos = new List<Libro_Asiento>();
            cnn.Conectar();
            const string query = "Select * from Asientos_Libro where Asiento_LibroId=@id";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Libro_Asiento Libro_Asiento = new Libro_Asiento
                {
                    Asiento_id = Convert.ToInt32(reader["Asiento_Id"]),
                    Fecha = Convert.ToDateTime(reader["Asiento_Fecha"]),
                   
                };
                Libros_Asientos.Add(Libro_Asiento);
            }
            
            cnn.Desconectar();

            foreach (Libro_Asiento asiento in Libros_Asientos)
            {
                asiento.Asiento_cuenta = CargarCuentas(asiento.Asiento_id);
            }

            return Libros_Asientos;
        }

        public List<Cuenta> CargarCuentas(int id)
        {
            List<Cuenta> Cuentas = new List<Cuenta>();
            cnn.Conectar();
            const string query = "Select * from Cuentas where Cuenta_AsientoId=@id";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Cuenta Cuenta = new Cuenta
                {
                    Cuenta_id = Convert.ToInt32(reader["Cuenta_Id"]),
                    Cuenta_Debe = Convert.ToDouble(reader["Cuenta_Debe"]),
                    Cuenta_haber = Convert.ToDouble(reader["Cuenta_Haber"]),
                    Cuenta_Nombre = Convert.ToString(reader["Cuenta_Nombre"]),
                    Cuenta_Tipo = Convert.ToString(reader["Cuenta_Tipo"]),
                };
                Cuentas.Add(Cuenta);
            }
            
            cnn.Desconectar();
            return Cuentas;
        }

        public List<Mayor_Cuenta> CargarMayores(int id)
        {
            List<Mayor_Cuenta> Mayores = new List<Mayor_Cuenta>();
            cnn.Conectar();
            const string query = "Select * from Mayores where Mayor_LibroId=@id";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Mayor_Cuenta Mayor_Cuenta = new Mayor_Cuenta
                {
                    Mayor_id = Convert.ToInt32(reader["Mayor_Id"]),
                    Mayor_Debe = Convert.ToDouble(reader["Mayor_Debe"]),
                    Mayor_haber = Convert.ToDouble(reader["Mayor_Haber"]),
                    Mayor_Nombre = Convert.ToString(reader["Mayor_Nombre"]),
                };
                Mayores.Add(Mayor_Cuenta);
            }
            
            cnn.Desconectar();
            return Mayores;
        }


        public Libro_Diario LibrodeHoy()
        {
            Libro_Diario libros = new Libro_Diario();
            try
            {
                cnn.Conectar();
                const string query = "select * from Libro_Diario";
                SqlCommand cmd = new SqlCommand(query, cnn.Con());
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Libro_Diario Libro_Diario = new Libro_Diario
                    {
                        Libro_id = Convert.ToInt32(reader["Libro_Id"]),
                        Libro_Activo = Convert.ToBoolean(reader["Libro_Estado"]),
                        Libro_Fecha = Convert.ToDateTime(reader["Libro_Fecha"]),
                    };

                    libros=Libro_Diario;
                }
               
                cnn.Desconectar();

                libros.Libro_mayores = CargarMayores(libros.Libro_id);
                libros.Libro_asientos = CargarAsientos(libros.Libro_id);
                libros.Libro_Stock_Ficha = CargarFichaStock(libros.Libro_id);

            }
            catch (Exception)
            {

                throw;
            }

            return libros;



        }


        public int IdLibroActivo ()
        {
            int id = 0;
            cnn.Conectar();
            string query = "select top 1 Libro_Id from Libro_Diario where Libro_Estado=1 ";
            SqlCommand cmd2 = new SqlCommand(query, cnn.Con());
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["Libro_Id"]);
            }
            cnn.Desconectar();
            return id;
        }


        public void CerrarLibro()
        {
            int id = IdLibroActivo();
            cnn.Conectar();
            string query = "update Libro_Diario set Libro_Estado=@cerrar where Libro_Estado=@abierto";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@cerrar", false);
            cmd.Parameters.AddWithValue("@abierto",true);
            cmd.ExecuteNonQuery();
            cnn.Desconectar();

           
        }

        public void crearLibro()
        {
            cnn.Conectar();
            string query = "insert into Libro_Diario values(@Libro_Estado,@Libro_Fecha)";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@Libro_Estado", true);
            cmd.Parameters.AddWithValue("@Libro_Fecha", DateTime.Now);
            cmd.ExecuteNonQuery();
            cnn.Desconectar();
        }

    }
}
