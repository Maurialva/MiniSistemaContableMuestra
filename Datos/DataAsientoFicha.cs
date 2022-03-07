using AplicacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Datos
{
    public class DataAsientoFicha
    {
        
        public DataLibroDiario libro = new DataLibroDiario();
       
        public DatoConexion cnn = new DatoConexion();
        internal bool ExistenciaInicial()
        {
            bool hay = false;
            cnn.Conectar();
            string query = "select top 1 Existencia_Estado from ExistenciaInicial ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                hay = Convert.ToBoolean(reader["Existencia_Estado"]);
            }
           
            cnn.Desconectar();
            return hay;

        }

        internal void crearExistencia()
        {
            
            double precio=0;
            double cantidad=0;

            cnn.Conectar();
            string query = "select * from ExistenciaInicial ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                precio = Convert.ToDouble(reader["Existencia_Precio"]);
                cantidad = Convert.ToDouble(reader["Existencia_Cantidad"]);
            }
            cnn.Desconectar();
            cnn.Conectar();
            string query2 = "update ExistenciaInicial set Existencia_estado=0 ";
            SqlCommand cmd2 = new SqlCommand(query2, cnn.Con());
            cmd2.ExecuteNonQuery();
            cnn.Desconectar();
            this.crearAsiento("E. Inicial", 0, 0, 0, 0, cantidad, precio);

        }

        internal double traerCMW(double cantidad)
        {
            double precio = 0;
            cnn.Conectar();
            string query = "select top 1 * from Saldo_Stock order by  Saldo_Id desc";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {  
                precio = Convert.ToDouble(reader["Saldo_Precio"]);
            }

            cnn.Desconectar();


            return precio*cantidad;


        }

        public DataFichaStock ficha = new DataFichaStock();
        internal void crearAsiento(string transaccion, double entradaCan, double entradaPrecio, double salidaCan, double salidaPrecio,double saldoCant,double saldoPrecio)
        {
            int id = ficha.IdFicha();
            Stock_Entrada ent = new Stock_Entrada();
            Stock_Saldo saldo = new Stock_Saldo();
            Stock_Salida salida = new Stock_Salida();

            ent.Entrada_cantidad = (long)entradaCan;
            ent.Entrada_precio = entradaPrecio;
            ent.Entrada_total = entradaCan * entradaPrecio;
            salida.Salida_cantidad = (long)salidaCan;
            salida.Salida_precio = salidaPrecio;
            salida.Salida_total = salidaPrecio;

            if (this.hayAnterior(id))
            {
                saldo = this.traerPrevio();
                if (transaccion=="Compra" || transaccion == "Devolucion Por Venta" )
                {
                    if (transaccion == "Compra")
                    {
                        saldo.Saldo_cantidad = saldo.Saldo_cantidad + ent.Entrada_cantidad;
                        saldo.Saldo_total = saldo.Saldo_total + ent.Entrada_total;
                        saldo.Saldo_precio = saldo.Saldo_total / saldo.Saldo_cantidad;
                    }
                   
                }
                else
                {
                    if (transaccion=="Venta")
                    {
                        salida.Salida_precio = saldo.Saldo_precio;
                        salida.Salida_total = salida.Salida_precio * salida.Salida_cantidad;
                        saldo.Saldo_cantidad = saldo.Saldo_cantidad - (long)salidaCan;
                        saldo.Saldo_total = saldo.Saldo_cantidad * saldo.Saldo_precio;
                    }
                    else
                    {
                        if (transaccion=="Faltante")
                        {
                            salida.Salida_cantidad = (long)salidaCan;
                            salida.Salida_precio = saldo.Saldo_precio;
                            salida.Salida_total = salida.Salida_cantidad* saldo.Saldo_precio;
                            saldo.Saldo_cantidad = saldo.Saldo_cantidad - salida.Salida_cantidad;
                            saldo.Saldo_total = saldo.Saldo_total- salida.Salida_total;

                        }
                        else
                        {
                            if (transaccion == "Sobrante")
                            {
                                saldo.Saldo_cantidad = saldo.Saldo_cantidad + ent.Entrada_cantidad;
                                saldo.Saldo_total = saldo.Saldo_total + ent.Entrada_total;
                                saldo.Saldo_precio = saldo.Saldo_total / saldo.Saldo_cantidad;
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
            else
            {
                if (transaccion == "E. Inicial")
                {
                    saldo.Saldo_cantidad = (long)saldoCant;
                    saldo.Saldo_precio = saldoPrecio;
                    saldo.Saldo_total = saldoCant * saldoPrecio;
                }
                else
                {
                    saldo.Saldo_cantidad= (long)entradaCan;
                    saldo.Saldo_precio = entradaPrecio;
                    saldo.Saldo_total = entradaCan * entradaPrecio;

                }

            }



            //asiento
            cnn.Conectar();
            string query = "insert into AsientoStock (AsientoF_StockId,AsientoF_Fecha,AsientoF_Concepto) values(@AsientoF_StockId,@AsientoF_Fecha,@AsientoF_Concepto)";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@AsientoF_StockId", id);
            cmd.Parameters.AddWithValue("@AsientoF_Fecha", DateTime.Now);
            cmd.Parameters.AddWithValue("@AsientoF_Concepto", transaccion);
            cmd.ExecuteNonQuery();
            cnn.Desconectar();
            int idasiento = this.traerId();

            //entrada
            cnn.Conectar();
            string query2 = "insert into Entrada_Ficha values(@Entrada_AsientoId,@Entrada_Precio,@Entrada_Cantidad,@Entrada_Total)";
            SqlCommand cmd2 = new SqlCommand(query2, cnn.Con());
            cmd2.Parameters.AddWithValue("@Entrada_AsientoId", idasiento);
            cmd2.Parameters.AddWithValue("@Entrada_Precio", ent.Entrada_precio);
            cmd2.Parameters.AddWithValue("@Entrada_Cantidad", ent.Entrada_cantidad);
            cmd2.Parameters.AddWithValue("@Entrada_Total", ent.Entrada_total);
            cmd2.ExecuteNonQuery();


            //salida
            string query3 = "insert into Salidas_Ficha values(@Salida_AsientoId,@Salida_Precio,@Salida_Cantidad,@Salida_Total)";
            SqlCommand cmd3 = new SqlCommand(query3, cnn.Con());
            cmd3.Parameters.AddWithValue("@Salida_AsientoId", idasiento);
            cmd3.Parameters.AddWithValue("@Salida_Precio", salida.Salida_precio);
            cmd3.Parameters.AddWithValue("@Salida_Cantidad", salida.Salida_cantidad);
            cmd3.Parameters.AddWithValue("@Salida_Total", salida.Salida_total);
            cmd3.ExecuteNonQuery();

            //saldo
            string query4 = "insert into Saldo_Stock values(@Saldo_AsientoId,@Saldo_Precio,@Saldo_Cantidad,@Saldo_Total)";
            SqlCommand cmd4 = new SqlCommand(query4, cnn.Con());
            cmd4.Parameters.AddWithValue("@Saldo_AsientoId", idasiento);
            cmd4.Parameters.AddWithValue("@Saldo_Precio",saldo.Saldo_precio);
            cmd4.Parameters.AddWithValue("@Saldo_Cantidad", saldo.Saldo_cantidad);
            cmd4.Parameters.AddWithValue("@Saldo_Total", saldo.Saldo_total);
            cmd4.ExecuteNonQuery();

            cnn.Desconectar();

        }

        public  Stock_Saldo traerPrevio()
        {
            Stock_Saldo Stock_Saldo = new Stock_Saldo();
            cnn.Conectar();
            string query = "select top 1 * from Saldo_Stock order by  Saldo_Id desc";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Stock_Saldo.Stock_saldo_id = Convert.ToInt32(reader["Saldo_Id"]);
                Stock_Saldo.Saldo_precio = Convert.ToDouble(reader["Saldo_Precio"]);
                Stock_Saldo.Saldo_cantidad = Convert.ToInt64(reader["Saldo_Cantidad"]);
                Stock_Saldo.Saldo_total= Convert.ToDouble(reader["Saldo_Total"]);
            }
            
            cnn.Desconectar();


            return Stock_Saldo;
        }

        private int traerId()
        {
            int ultimo = 0;
            cnn.Conectar();
            string query = "select top 1 AsientoF_Id from AsientoStock order by  AsientoF_Id desc";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ultimo = Convert.ToInt32(reader["AsientoF_Id"]);
            }
           
            cnn.Desconectar();
           
            return ultimo;
        }

        public bool hayAnterior(int id)
        {
            int anterior = 0;
            cnn.Conectar();
            string query = "select top 1 AsientoF_Id from AsientoStock where AsientoF_StockId=@id ";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                anterior = Convert.ToInt32(reader["AsientoF_Id"]);
            }
            
            cnn.Desconectar();
            if (anterior==0)
            {
                return false;
            }
            return true;
        }
        public void CerrarMercaderia(double restante)
        {
            //double resto = 0;
            if (hayAnterior(ficha.IdFicha()))
            {
                Stock_Saldo saldo = traerPrevio();
                if (saldo.Saldo_cantidad != restante)
                {
                    if (saldo.Saldo_cantidad > restante)
                    {
                        this.crearAsiento("Faltante", 0, 0, saldo.Saldo_cantidad - restante, saldo.Saldo_precio, saldo.Saldo_cantidad, saldo.Saldo_precio);
                        if ((saldo.Saldo_cantidad - restante)>0)
                        {
                            this.activarExistencia(saldo.Saldo_cantidad-(saldo.Saldo_cantidad - restante), saldo.Saldo_precio);
                        }
                    }
                    else
                    {
                        this.crearAsiento("Sobrante", restante - saldo.Saldo_cantidad, saldo.Saldo_precio, 0, 0, saldo.Saldo_cantidad, saldo.Saldo_precio);
                        if ((restante - saldo.Saldo_cantidad) >0)
                        {
                            this.activarExistencia(saldo.Saldo_cantidad + (restante - saldo.Saldo_cantidad), saldo.Saldo_precio);
                        }
                    }
                }

            }

            if (true)
            {

            }

            
        }

        private void activarExistencia(double cantidad, double saldo_precio)
        {
            cnn.Conectar();
            string query4 = "update ExistenciaInicial set Existencia_estado=@estado,Existencia_Cantidad=@cant,Existencia_Precio=@precio,Existencia_Total=@total where ExistenciaInicial_Id=1";
            SqlCommand cmd4 = new SqlCommand(query4, cnn.Con());
            cmd4.Parameters.AddWithValue("@estado", true);
            cmd4.Parameters.AddWithValue("@cant", cantidad);
            cmd4.Parameters.AddWithValue("@precio", saldo_precio);
            cmd4.Parameters.AddWithValue("@total", (saldo_precio*cantidad));
            cmd4.ExecuteNonQuery();

            cnn.Desconectar();

        }

        public double traerFaltante()
        {
            double faltante = new double();
            cnn.Conectar();
            string query = "select top 1 Salida_Total from Salidas_Ficha order by  Salida_Id desc";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                faltante = Convert.ToDouble(reader["Salida_Total"]);
            }
            
            cnn.Desconectar();


            return faltante;
        }
        public double traerSobrante()
        {
            double sobrante = new double();
            cnn.Conectar();
            string query = "select top 1 Entrada_Total from Entrada_Ficha order by  Entrada_Id desc";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sobrante = Convert.ToDouble(reader["Entrada_Total"]);
            }
            
            cnn.Desconectar();

            return sobrante;
        }
        public string ComprobarCierre()
        {
            string nombre = "";
            cnn.Conectar();
            string query = "select top 1 AsientoF_Concepto from AsientoStock order by  AsientoF_Id desc";
            SqlCommand cmd = new SqlCommand(query, cnn.Con());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nombre = Convert.ToString(reader["AsientoF_Concepto"]);
            }
            
            cnn.Desconectar();


            return nombre;
        }
    }
}
