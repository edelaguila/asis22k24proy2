﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo;


namespace Capa_Controlador
{
    public class Logica
    {

        private Sentencia sn = new Sentencia();

        public class DetalleComision
        {
            public int iIdFactura { get; set; }         // ID de la factura asociada al detalle de comisión
            public decimal dePorcentaje { get; set; }     // Porcentaje de comisión
            public decimal deMontoVenta { get; set; }     // Monto de la venta
            public decimal deMontoComision { get; set; }  // Monto de la comisión calculada
        }


        public DataTable funObtenerVendedores()
        {
            try
            {
                OdbcDataAdapter adapter = sn.funObtenerVendedores();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los vendedores: " + ex.Message);
                return null;
            }
        }

        public DataTable funObtenerVentasFiltradas(int iIdVendedor, string sFiltro, DateTime dFechaInicio, DateTime dFechaFin, string sValorFiltro)
        {
            try
            {
                OdbcDataAdapter adapter = sn.FunObtenerVentasPorVendedor(iIdVendedor, sFiltro, dFechaInicio, dFechaFin, sValorFiltro);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las ventas filtradas: " + ex.Message);
                return null;
            }
        }


        public void funGuardarComision(int iIdVendedor, decimal deTotalVenta, decimal deTotalComision, List<DetalleComision> detalles)
        {
            try
            {
                // Insertamos el encabezado de la comisión
                sn.funInsertarComisionEncabezado(iIdVendedor, deTotalVenta, deTotalComision);

                // Obtenemos el último ID de encabezado para asociar los detalles
                int idComisionEnc = funObtenerUltimoIdComisionEncabezado();

                // Insertamos cada detalle de comisión
                foreach (var detalle in detalles)
                {
                    sn.funInsertarComisionDetalle(idComisionEnc, detalle.iIdFactura, detalle.dePorcentaje, detalle.deMontoVenta, detalle.deMontoComision);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la comision: " + ex.Message);
            }

        }

        private int funObtenerUltimoIdComisionEncabezado()
        {
            // Consulta para obtener el último ID de comisión encabezado
            return 0; // Implementación pendiente
        }

        public bool funGuardarComision(int iIdVendedor, DateTime dFecha, decimal deTotalVentas, decimal deTotalComision, decimal dePorcentajeComision, List<int> iIdVentas)
        {
            try
            {
                // Genera el encabezado de la comisión
                int iIdComisionEnc = sn.funInsertarComisionEncabezado(iIdVendedor, dFecha, deTotalVentas, deTotalComision);

                if (iIdComisionEnc > 0)
                {
                    // Inserta cada detalle de la comisión en base a las ventas
                    foreach (int iIdFactura in iIdVentas)
                    {
                        // Calcular la parte proporcional de la comisión para cada venta
                        decimal deMontoComision = (deTotalVentas / iIdVentas.Count) * dePorcentajeComision;
                        decimal deMontoVentaIndividual = deTotalVentas / iIdVentas.Count;

                        sn.funInsertarDetalleComision(iIdComisionEnc, iIdFactura, dePorcentajeComision, deMontoVentaIndividual, deMontoComision);
                    }
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al guardar la comision: " + ex.Message);
                return false;
            }

            
        }

        public DataTable funObtenerMarcas()
        {
            try
            {
                return sn.funObtenerMarcas();
            }catch(Exception ex)
            {
                Console.WriteLine("Error al obtener las marcas: " + ex.Message);
                return null;
            }
            
        }

        public DataTable funObtenerLineas()
        {
            try
            {
                return sn.funObtenerLineas();
            }catch(Exception ex)
            {
                Console.WriteLine("Error al obtener las marcas: " + ex.Message);
                return null;
            }
        }
    }
}
