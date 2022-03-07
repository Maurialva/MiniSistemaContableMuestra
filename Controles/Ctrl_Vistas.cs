using AplicacionFinal.Datos;
using AplicacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionFinal.Controles
{
    class Ctrl_Vistas
    {


        internal DataGridView traerLibroHoy(DataGridView dataLibro)
        {

            DataLibroDiario libro = new DataLibroDiario();
            List<Libro_Asiento> asientos = new List<Libro_Asiento>();

            asientos = libro.CargarAsientos(libro.IdLibroActivo());
            int num = 1;
            foreach (Libro_Asiento asiento in asientos)
            {

                int n = dataLibro.Rows.Add();
                dataLibro.Rows[n].Cells[0].Value = asiento.Fecha;
                dataLibro.Rows[n].Cells[2].Value = $"Asiento N° {num}";
                num++;
                foreach (Cuenta cuenta in asiento.Asiento_cuenta)
                {
                    int c = dataLibro.Rows.Add();
                    if (cuenta.Cuenta_Tipo == "A")
                    {
                        if (cuenta.Cuenta_Debe > 0)
                        {
                            dataLibro.Rows[c].Cells[1].Value = $"{cuenta.Cuenta_Tipo}+";
                        }
                        else
                        {
                            dataLibro.Rows[c].Cells[1].Value = $"{cuenta.Cuenta_Tipo}-";
                        }
                    }
                    else
                    {
                        if (cuenta.Cuenta_Debe > 0)
                        {
                            dataLibro.Rows[c].Cells[1].Value = $"{cuenta.Cuenta_Tipo}-";
                        }
                        else
                        {
                            dataLibro.Rows[c].Cells[1].Value = $"{cuenta.Cuenta_Tipo}+";
                        }

                    }

                    if (cuenta.Cuenta_Debe > 0)
                    {
                        dataLibro.Rows[c].Cells[2].Value = cuenta.Cuenta_Nombre;
                        dataLibro.Rows[c].Cells[4].Value = $"$ {cuenta.Cuenta_Debe}";
                    }
                    else
                    {
                        dataLibro.Rows[c].Cells[3].Value = cuenta.Cuenta_Nombre;
                        dataLibro.Rows[c].Cells[5].Value = $"$ {cuenta.Cuenta_haber}";
                    }
                }
                int s = dataLibro.Rows.Add();
                dataLibro.Rows[s].Cells[0].Value = "-----";
                dataLibro.Rows[s].Cells[1].Value = "-----";
                dataLibro.Rows[s].Cells[2].Value = "-----";
                dataLibro.Rows[s].Cells[3].Value = "-----";
                dataLibro.Rows[s].Cells[4].Value = "-----";
                dataLibro.Rows[s].Cells[5].Value = "-----";
            }
            return dataLibro;

        }
        internal DataGridView traerMayores(DataGridView dataMayores, int idlibro)
        {


            DataLibroDiario libro = new DataLibroDiario();
            List<Mayor_Cuenta> Libro_mayores = libro.CargarMayores(idlibro);
            foreach (Mayor_Cuenta mayor in Libro_mayores)
            {
                int n = dataMayores.Rows.Add();
                dataMayores.Rows[n].Cells[0].Value = mayor.Mayor_Nombre;
                dataMayores.Rows[n].Cells[1].Value = $"$ {mayor.Mayor_Debe}";
                dataMayores.Rows[n].Cells[2].Value = $"$ {mayor.Mayor_haber}";

                if (mayor.Mayor_Debe >= mayor.Mayor_haber)
                {
                    dataMayores.Rows[n].Cells[3].Value = $"$ {mayor.Mayor_Debe - mayor.Mayor_haber}";
                }
                else
                {
                    dataMayores.Rows[n].Cells[4].Value = $"$ {mayor.Mayor_haber - mayor.Mayor_Debe}";
                }
            }



            return dataMayores;
        }





        internal DataGridView traerFicha(DataGridView dataFichaStock, int idlibro)
        {
            DataLibroDiario libro = new DataLibroDiario();
            Stock_Ficha Ficha = libro.CargarFichaStock(idlibro);
            foreach (Stock_Asiento asiento in Ficha.Stock_Asientos)
            {
                int n = dataFichaStock.Rows.Add();
                dataFichaStock.Rows[n].Cells[0].Value = asiento.Stock_Fecha;
                dataFichaStock.Rows[n].Cells[1].Value = asiento.Stock_Concepto;
                dataFichaStock.Rows[n].Cells[8].Value = asiento.Stock_saldo.Saldo_cantidad;
                dataFichaStock.Rows[n].Cells[9].Value = $"$ {asiento.Stock_saldo.Saldo_precio }";
                dataFichaStock.Rows[n].Cells[10].Value = $"$ {asiento.Stock_saldo.Saldo_total}";
                if (asiento.Stock_entrada.Entrada_cantidad > 0)
                {
                    dataFichaStock.Rows[n].Cells[2].Value = asiento.Stock_entrada.Entrada_cantidad;
                    dataFichaStock.Rows[n].Cells[3].Value = $"$ {asiento.Stock_entrada.Entrada_precio}";
                    dataFichaStock.Rows[n].Cells[4].Value = $"$ {asiento.Stock_entrada.Entrada_total}";

                }
                else
                {
                    dataFichaStock.Rows[n].Cells[5].Value = asiento.Stock_salida.Salida_cantidad;
                    dataFichaStock.Rows[n].Cells[6].Value = $"$ {asiento.Stock_salida.Salida_precio}";
                    dataFichaStock.Rows[n].Cells[7].Value = $"$ {asiento.Stock_salida.Salida_total}";

                }
            }



            return dataFichaStock;
        }

        public ComboBox ListarLibros(ComboBox cboxLibros)
        {
            DataLibroDiario libro = new DataLibroDiario();
            List<Libro_Diario> libros = libro.Listar();

            foreach (Libro_Diario item in libros)
            {
                cboxLibros.Items.Add(new ComboBoxItem(item.Libro_id, item.Libro_Fecha));
            }


            return cboxLibros;
        }


        internal DataGridView traerLibro(DataGridView dataLibro,int id)
        {

            DataLibroDiario libro = new DataLibroDiario();
            List<Libro_Asiento> asientos = new List<Libro_Asiento>();

            asientos = libro.CargarAsientos(id);
            int num = 1;
            foreach (Libro_Asiento asiento in asientos)
            {

                int n = dataLibro.Rows.Add();
                dataLibro.Rows[n].Cells[0].Value = asiento.Fecha;
                dataLibro.Rows[n].Cells[2].Value = $"Asiento N° {num}";
                num++;
                foreach (Cuenta cuenta in asiento.Asiento_cuenta)
                {
                    int c = dataLibro.Rows.Add();
                    if (cuenta.Cuenta_Tipo == "A")
                    {
                        if (cuenta.Cuenta_Debe > 0)
                        {
                            dataLibro.Rows[c].Cells[1].Value = $"{cuenta.Cuenta_Tipo}+";
                        }
                        else
                        {
                            dataLibro.Rows[c].Cells[1].Value = $"{cuenta.Cuenta_Tipo}-";
                        }
                    }
                    else
                    {
                        if (cuenta.Cuenta_Debe > 0)
                        {
                            dataLibro.Rows[c].Cells[1].Value = $"{cuenta.Cuenta_Tipo}-";
                        }
                        else
                        {
                            dataLibro.Rows[c].Cells[1].Value = $"{cuenta.Cuenta_Tipo}+";
                        }

                    }

                    if (cuenta.Cuenta_Debe > 0)
                    {
                        dataLibro.Rows[c].Cells[2].Value = cuenta.Cuenta_Nombre;
                        dataLibro.Rows[c].Cells[4].Value = $"$ {cuenta.Cuenta_Debe}";
                    }
                    else
                    {
                        dataLibro.Rows[c].Cells[3].Value = cuenta.Cuenta_Nombre;
                        dataLibro.Rows[c].Cells[5].Value = $"$ {cuenta.Cuenta_haber}";
                    }
                }
                int s = dataLibro.Rows.Add();
                dataLibro.Rows[s].Cells[0].Value = "-----";
                dataLibro.Rows[s].Cells[1].Value = "-----";
                dataLibro.Rows[s].Cells[2].Value = "-----";
                dataLibro.Rows[s].Cells[3].Value = "-----";
                dataLibro.Rows[s].Cells[4].Value = "-----";
                dataLibro.Rows[s].Cells[5].Value = "-----";
            }
            return dataLibro;


        }


        public string[] Bienes()
        {
            string[] compras = { 
            "Mercaderia",
            "Rodados",
            "Instalaciones",
            "Maquinaria",
            "Moneda Extranjera",
            "Muebles y Utiles",
            "Equipos de Computacion",
            "Acciones"
            };

            return compras;

        }
        public string[] Ingresos()
        {
            string[] compras = {
            "Caja",
            "Banco cta.cte",
            "Documento a cobrar",
            "Banco cta. de ahorro",
            "Valores a depositar",
            "Muebles y Utiles",
            "Señas recibidas",
            "Fletes a pagar",
            "Luz a pagar",
            "Gas a pagar",
            "Telefono a pagar",
            "Sueldos a pagar",
            "Sueldos y jornales",
            "Gastos flete",
            "Gastos de Luz",
            "Gastos de Gas",
            "Gastos de Telefono",
            "Capital Social"
            };

            return compras;

        }

        public string[] Devoluciones()
        {
            string[] compras = {
            "Mercaderia"
            };

            return compras;

        }

        public string[]metodosdepago()
        {
            string[] pagos =
            {
                "Caja",
                "Banco cta. cte",
                "Banco cta. de ahorro",
                "Moneda extranjera",
                "Valores a depositar",
                "Anticipo a proveedores",
                "Anticipo de clientes",
                "Reservas"
            };
            return pagos;
        }






    }
}
