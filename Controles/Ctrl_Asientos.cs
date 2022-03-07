using AplicacionFinal.Datos;
using AplicacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinal.Controles
{
    class Ctrl_Asientos
    {

        DataAsientoLibro DAsiento = new DataAsientoLibro();
        internal void nuevoAsiento(string cuenta, string Transaccion, string MetodoPago, string MetodoPago2, double porcentaje1, double Cantidad, bool segundoMetodo, double monto)
        {
            Ctrl_FichaStock ctrlFicha = new Ctrl_FichaStock();
            Ctrl_Cuenta CtrlCuenta = new Ctrl_Cuenta();

            DAsiento.CrearAsiento();

            if (Transaccion == "Compra")
            {
                double debe = monto / 1.21;
                CtrlCuenta.AgregarDebe(cuenta, debe);
                CtrlCuenta.AgregarDebe("Iva Credito Fiscal",monto-debe);
                if (cuenta=="Mercaderia")
                {
                    ctrlFicha.CrearAsientoEntrada(Transaccion, Cantidad, monto/1.21);
                }
                if (segundoMetodo)
                {
                    if (porcentaje1==100)
                    {
                        CtrlCuenta.AgregarHaber(MetodoPago,monto);
                    }
                    else
                    {
                        double por1 = (porcentaje1 * monto) / 100;
                        double por2 = monto - por1;
                        CtrlCuenta.AgregarHaber(MetodoPago, por1);
                        CtrlCuenta.AgregarHaber(MetodoPago2, por2);
                    }

                }
                else
                {
                    CtrlCuenta.AgregarHaber(MetodoPago, monto);
                }

            }
            else
            {
                if (Transaccion == "Venta")
                {
                    if (cuenta == "Mercaderia")
                    {
                        if (segundoMetodo)
                        {
                            if (porcentaje1 == 100)
                            {
                                CtrlCuenta.AgregarDebe(MetodoPago, monto);
                            }
                            else
                            {
                                double por1 = (porcentaje1 * monto) / 100;
                                double por2 = monto - por1;
                                CtrlCuenta.AgregarDebe(MetodoPago, por1);
                                CtrlCuenta.AgregarDebe(MetodoPago2, por2);
                            }

                        }
                        else
                        {
                            CtrlCuenta.AgregarDebe(MetodoPago, monto);
                        }

                        CtrlCuenta.AgregarHaber("Iva Debito Fiscal", monto/1.21*0.21 );
                        CtrlCuenta.AgregarHaber("Ventas", monto/1.21);
                        ctrlFicha.CrearAsientoSalida(Transaccion, Cantidad, monto/1.21);
                        double cmv=ctrlFicha.TraerCMV(Cantidad);
                        CtrlCuenta.AgregarDebe("CMV", cmv);
                        CtrlCuenta.AgregarHaber("Mercaderia",cmv);



                    }
                    else
                    {
                      
                        if (cuenta == "Rodados" || cuenta == "Instalaciones" || cuenta == "Maquinaria" || cuenta == "Muebles y Utiles" || cuenta == "Equipos de Computacion")
                        {

     
                            if (segundoMetodo)
                            {
                                if (porcentaje1 == 100)
                                {
                                    CtrlCuenta.AgregarDebe(MetodoPago, monto );
                                }
                                else
                                {
                                    double por1 = (porcentaje1 * (monto)) / 100;
                                    double por2 = (monto ) - por1;
                                    CtrlCuenta.AgregarDebe(MetodoPago, por1);
                                    CtrlCuenta.AgregarDebe(MetodoPago2, por2);
                                }

                            }
                            else
                            {
                                CtrlCuenta.AgregarDebe(MetodoPago, monto);
                            }
                            
                            Cuenta bduso = CtrlCuenta.traercuenta(cuenta);
                            if (Math.Round(bduso.Cuenta_Debe) > Math.Round(monto /1.21))
                            {

                                CtrlCuenta.AgregarDebe("Res. por Vta BS Uso",(bduso.Cuenta_Debe - monto) + monto / 1.21 * 0.21 );
                                CtrlCuenta.AgregarHaber("Iva Debito Fiscal", monto / 1.21 * 0.21);
                                CtrlCuenta.AgregarHaber(cuenta, bduso.Cuenta_Debe);
                            }
                            else
                            {
                                if (Math.Round(bduso.Cuenta_Debe) < Math.Round(monto / 1.21))
                                {
                                    CtrlCuenta.AgregarHaber("Iva Debito Fiscal", (monto / 1.21) * 0.21);
                                    CtrlCuenta.AgregarHaber(cuenta, bduso.Cuenta_Debe);
                                    CtrlCuenta.AgregarHaber("Res. por Vta BS Uso", (monto- bduso.Cuenta_Debe) - (monto / 1.21 * 0.21));

                                }
                                else
                                {
                                    CtrlCuenta.AgregarHaber("Iva Debito Fiscal", (monto/1.21) * 0.21);
                                    CtrlCuenta.AgregarHaber(cuenta, bduso.Cuenta_Debe);
                                }
                                            
                            }
                                       
                        }
                        else
                        {
                            if (segundoMetodo)
                            {
                                if (porcentaje1 == 100)
                                {
                                    CtrlCuenta.AgregarDebe(MetodoPago, monto);
                                }
                                else
                                {
                                    double por1 = (porcentaje1 * monto) / 100;
                                    double por2 = monto - por1;
                                    CtrlCuenta.AgregarDebe(MetodoPago, por1);
                                    CtrlCuenta.AgregarDebe(MetodoPago2, por2);
                                }

                            }
                            else
                            {
                                CtrlCuenta.AgregarDebe(MetodoPago, monto);
                            }
                            CtrlCuenta.AgregarHaber("Iva Debito Fiscal", monto / 1.21 * 0.21);
                            CtrlCuenta.AgregarHaber(cuenta, monto / 1.21);
                        }
                          

                    }
                       
                    
                   
                }
                else
                {
                    if (Transaccion == "Devolucion por Comrpa")
                    {

                    }
                    else
                    {
                        if (Transaccion == "Devolucion por Venta")
                        {

                        }
                        else
                        {
                            if (Transaccion == "Ingreso")
                            {


                                if (segundoMetodo)
                                {
                                    if (porcentaje1 == 100)
                                    {
                                        CtrlCuenta.AgregarDebe(MetodoPago, monto);
                                    }
                                    else
                                    {
                                        double por1 = (porcentaje1 * monto) / 100;
                                        double por2 = monto - por1;
                                        CtrlCuenta.AgregarDebe(MetodoPago, por1);
                                        CtrlCuenta.AgregarDebe(MetodoPago2, por2);
                                    }

                                }
                                else
                                {
                                    CtrlCuenta.AgregarDebe(MetodoPago, monto);
                                    
                                }
                                CtrlCuenta.AgregarHaber(cuenta, monto);



                            }
                            else
                            {
                                if (Transaccion=="Salida")
                                {
                                    if (segundoMetodo)
                                    {
                                        if (porcentaje1 == 100)
                                        {
                                            CtrlCuenta.AgregarDebe(MetodoPago, monto);
                                        }
                                        else
                                        {
                                            double por1 = (porcentaje1 * monto) / 100;
                                            double por2 = monto - por1;
                                            CtrlCuenta.AgregarDebe(MetodoPago, por1);
                                            CtrlCuenta.AgregarDebe(MetodoPago2, por2);
                                        }

                                    }
                                    else
                                    {
                                        CtrlCuenta.AgregarDebe(MetodoPago, monto);

                                    }
                                    CtrlCuenta.AgregarHaber(cuenta, monto);
                                }
                                else
                                {

                                }

                            }
                        }
                    }
                }
            }


        }

  

        internal void RegularizadorMercaderia()
        {
            Ctrl_Cuenta CtrlCuenta = new Ctrl_Cuenta();

            DAsiento.CrearAsiento();
            if (DAsiento.reguralizarMercaderia()=="Faltante")
            {
                CtrlCuenta.agregarFaltante();
            }
            else
            {
                CtrlCuenta.agregarSobrante();
            }

        }
    }
}
