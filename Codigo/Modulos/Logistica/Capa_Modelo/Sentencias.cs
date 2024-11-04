using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data;


namespace Capa_Modelo
{
    public class Sentencias
    {
        private Conexion cn = new Conexion();
        // Aca inicia toda la logica de sentencias relacionado al modulo de mantenimiento de vehiculos
        public void InsertarSolicitudMantenimiento(string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_vehiculo)
        {
            OdbcConnection conn = cn.conexion();
            try
            {
                string query = "INSERT INTO tbl_mantenimiento (nombre_Solicitante, tipo_de_Mantenimiento, componente_Afectado, fecha, responsable_Asignado, codigo_Error_Problema, estado_del_Mantenimiento, tiempo_Estimado, Fk_id_vehiculo) " +
               "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre_Solicitante", nombreSolicitante);
                cmd.Parameters.AddWithValue("@tipo_de_mantenimiento", tipoMantenimiento);
                cmd.Parameters.AddWithValue("@componente_Afectado", componenteAfectado);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@responsable_Asignado", responsableAsignado);
                cmd.Parameters.AddWithValue("@codigo_Error_Problema", codigo_error_Problema);
                cmd.Parameters.AddWithValue("@estado_del_Mantenimiento", estadoMantenimiento);
                cmd.Parameters.AddWithValue("@tiempo_Estimado", tiempoEstimado);
                cmd.Parameters.AddWithValue("@Fk_id_vehiculo", id_vehiculo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha ingresado de forma exitosa la solicitud");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar solicitud de mantenimiento: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); 
                }
            }
        }
        public void ModificarSolicitudMantenimiento(int idMantenimiento, string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_vehiculo)
        {
            OdbcConnection conn = cn.conexion();
            try
            {
                string query = "UPDATE tbl_mantenimiento SET " +
                       "nombre_Solicitante = ?, " +
                       "tipo_de_Mantenimiento = ?, " +
                       "componente_Afectado = ?, " +
                       "fecha = ?, " +
                       "responsable_Asignado = ?, " +
                       "codigo_Error_Problema = ?, " +
                       "estado_del_Mantenimiento = ?, " +
                       "tiempo_Estimado = ?, " +
                       "Fk_id_vehiculo = ? " +
                       "WHERE Pk_id_mantenimiento = ?";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre_Solicitante", nombreSolicitante);
                cmd.Parameters.AddWithValue("@tipo_de_mantenimiento", tipoMantenimiento);
                cmd.Parameters.AddWithValue("@componente_Afectado", componenteAfectado);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@responsable_Asignado", responsableAsignado);
                cmd.Parameters.AddWithValue("@codigo_Error_Problema", codigo_error_Problema);
                cmd.Parameters.AddWithValue("@estado_del_Mantenimiento", estadoMantenimiento);
                cmd.Parameters.AddWithValue("@tiempo_Estimado", tiempoEstimado);
                cmd.Parameters.AddWithValue("@Fk_id_vehiculo", id_vehiculo);
                cmd.Parameters.AddWithValue("@Pk_id_mantenimiento", idMantenimiento); // Agrega este parámetro

                cmd.ExecuteNonQuery(); // Ejecuta la consulta
                MessageBox.Show("Se ha modificado de forma exitosa la solicitud");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar solicitud de mantenimiento: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); 
                }
            }
        }
        public OdbcDataAdapter DisplaySolicitudesMantenimiento()
        {
            string TablaMantenimiento = "Tbl_mantenimiento";
            string sSql = "SELECT * FROM " + TablaMantenimiento;
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, cn.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + TablaMantenimiento);
            }
            return dataTable;
        }
        public void eliminarSolicitudMantenimiento(int idMantenimiento)
        {
            OdbcConnection conn = cn.conexion();
            try
            {
                string query = "DELETE FROM Tbl_mantenimiento WHERE Pk_id_mantenimiento = ?";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@Pk_id_mantenimiento", idMantenimiento);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Solicitud Eliminada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la solicitud: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); 
                }
            }
        }
        public void GenerarPDFMantenmiento(int idMantenimiento)
        {
            OdbcConnection conn = cn.conexion();
            OdbcDataReader dr = null;
            try
            {
                string query = "SELECT *FROM tbl_mantenimiento WHERE Pk_id_mantenimiento = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@Pk_id_mantenimiento", idMantenimiento);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string ID_Mantenimiento = dr["Pk_id_Mantenimiento"].ToString();
                    string NombreSolicitante = dr["nombre_Solicitante"].ToString();
                    string Tipo_de_Mantenimiento = dr["tipo_de_Mantenimiento"].ToString();
                    string Componente_Afectado = dr["componente_Afectado"].ToString();
                    string Fecha = dr["fecha"].ToString();
                    string ResponsableAsignado = dr["responsable_Asignado"].ToString();
                    string Codigo_Error_Problema = dr["codigo_Error_Problema"].ToString();
                    string Estado = dr["estado_del_Mantenimiento"].ToString();
                    string Tiempo_Estimado = dr["tiempo_Estimado"].ToString();
                    string Fk_id_vehiculo = dr["Fk_id_vehiculo"].ToString();

                    Document doc = new Document();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "mantenimiento_" + idMantenimiento + ".pdf");
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();

                    // Título Principal
                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                    doc.Add(new Paragraph("Datos del Mantenimiento a Realizar al Vehículo", titleFont) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph(" ")); // Espacio en blanco para separar secciones

                    // Datos de Solicitud
                    var sectionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                    doc.Add(new Paragraph("Información de la Solicitud", sectionFont));
                    doc.Add(new Paragraph("ID de la solicitud: " + ID_Mantenimiento));
                    doc.Add(new Paragraph("Nombre del solicitante: " + NombreSolicitante));
                    doc.Add(new Paragraph("Fecha de solicitud: " + Fecha));
                    doc.Add(new Paragraph(" ")); // Espacio en blanco

                    // Detalles del Mantenimiento
                    doc.Add(new Paragraph("Detalles del Mantenimiento Solicitado", sectionFont));
                    doc.Add(new Paragraph("Tipo de Mantenimiento: " + Tipo_de_Mantenimiento));
                    doc.Add(new Paragraph("Componente del vehículo: " + Componente_Afectado));
                    doc.Add(new Paragraph("Mecánico Asignado: " + ResponsableAsignado));
                    doc.Add(new Paragraph("Problema Reportado: " + Codigo_Error_Problema));
                    doc.Add(new Paragraph("Estado de la Solicitud: " + Estado));
                    doc.Add(new Paragraph("Tiempo Estimado: " + Tiempo_Estimado));
                    doc.Add(new Paragraph("ID del Vehículo en taller: " + Fk_id_vehiculo));
                    doc.Add(new Paragraph(" ")); // Espacio en blanco

                    // Firma
                    doc.Add(new Paragraph("Firma del Mecánico a Cargo: _______________________", sectionFont));
                    doc.Add(new Paragraph(" "));

                    // Pie de Página
                    var footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 8);
                    doc.Add(new Paragraph("Documento generado automáticamente - Fecha y Hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), footerFont) { Alignment = Element.ALIGN_RIGHT });

                    doc.Close();

                    MessageBox.Show("PDF generado con éxito: " + filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la solicitud ingresada" + ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Cerrar la conexión
                }
            }
        }
        //Aca finaliza toda la logica relacionada al modulo de mantenimiento de vehiculos

        //Aca empieza la logica relacionada al modulo de movimiento de inventario;
        public void InsertarMovimientoInventario(int estado, int fk_id_producto, int Fk_id_stock, int fk_id_locales)
        {
            Conexion conexion = new Conexion();
            OdbcConnection cn = conexion.conexion(); // Aquí obtienes la conexión
            if (cn == null) // Verifica si la conexión fue exitosa
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            try
            {
                string query = "INSERT INTO Tbl_movimiento_de_inventario (estado, Fk_id_producto, Fk_id_stock, Fk_ID_LOCALES) " +
                               "VALUES (?, ?, ?, ?)";
                OdbcCommand cmd = new OdbcCommand(query, cn);

                // Asignar los valores de los parámetros
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@Fk_id_producto", fk_id_producto);
                cmd.Parameters.AddWithValue("@Fk_id_stock", Fk_id_stock);
                cmd.Parameters.AddWithValue("@Fk_ID_LOCALES", fk_id_locales);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Movimiento de inventario agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el movimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.desconexion(cn); // Cierra la conexión
            }
        }

        public DataTable llenarcmb(string tabla, string campoID)
        {
            Conexion conexion = new Conexion();
            OdbcConnection cn = conexion.conexion(); // Obtén la conexión desde la clase Conexion
            DataTable dt = new DataTable();

            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open(); // Asegúrate de abrir la conexión
                }

                string queryComboBox = $"SELECT {campoID} FROM {tabla}";
                OdbcCommand cmd = new OdbcCommand(queryComboBox, cn);
                OdbcDataAdapter data = new OdbcDataAdapter(cmd);
                data.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    conexion.desconexion(cn); // Asegúrate de cerrar la conexión si está abierta
                }
            }

            return dt;
        }
        public OdbcDataAdapter DisplayMovimientos()
        {
            string TablaMovimientoInventario = "tbl_movimiento_de_inventario";
            string sSql = "SELECT * FROM " + TablaMovimientoInventario;
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, cn.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + TablaMovimientoInventario);
            }
            return dataTable;
        }
        public void ModificarMovimientoInventario(int idMovimiento, int estado, int Fk_id_producto, int Fk_id_stock, int Fk_ID_LOCALES)
        {
            Conexion conexion = new Conexion();
            OdbcConnection cn = conexion.conexion(); // Aquí obtienes la conexión
            if (cn == null) // Verifica si la conexión fue exitosa
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "UPDATE tbl_movimiento_de_inventario SET " +
                       "estado = ?, " +
                       "Fk_id_producto = ?, " +
                       "Fk_id_stock = ?, " +
                       "Fk_ID_LOCALES = ? " + // Elimina la coma al final de esta línea
                       "WHERE Pk_id_movimiento = ?";
                OdbcCommand cmd = new OdbcCommand(query, cn);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@Fk_id_producto", Fk_id_producto);
                cmd.Parameters.AddWithValue("@Fk_id_stock", Fk_id_stock);
                cmd.Parameters.AddWithValue("@Fk_ID_LOCALES", Fk_ID_LOCALES);
                cmd.Parameters.AddWithValue("@Pk_id_movimiento", idMovimiento);
                cmd.ExecuteNonQuery(); // Ejecuta la consulta
                MessageBox.Show("Se ha modificado de forma exitosa la solicitud");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo en la edicion del movimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.desconexion(cn); // Cierra la conexión
            }
        }
        public void eliminarMovimientoInventario(int idMovimiento)
        {
            Conexion conexion = new Conexion();
            OdbcConnection cn = conexion.conexion(); // Aquí obtienes la conexión
            if (cn == null) // Verifica si la conexión fue exitosa
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query = "DELETE FROM tbl_movimiento_de_inventario WHERE Pk_id_movimiento = ?";
                OdbcCommand cmd = new OdbcCommand(query, cn);
                cmd.Parameters.AddWithValue("@Pk_id_movimiento", idMovimiento);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Solicitud Eliminada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la solicitud: " + ex.Message);
            }
            finally
            {
                conexion.desconexion(cn); // Cierra la conexión
            }
        }
        public void GenerarPDFMovimiento(int idMovimiento)
        {
            OdbcConnection conn = cn.conexion();
            OdbcDataReader dr = null;
            try
            {
                string query = "SELECT * FROM tbl_movimiento_de_inventario WHERE Pk_id_movimiento = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@Pk_id_movimiento", idMovimiento);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string Pk_id_movimiento = dr["Pk_id_movimiento"].ToString();
                    string estado = dr["estado"].ToString();
                    string Fk_id_producto = dr["Fk_id_producto"].ToString();
                    string Fk_id_stock = dr["Fk_id_stock"].ToString();
                    string Fk_ID_LOCALES = dr["Fk_ID_LOCALES"].ToString();

                    Document doc = new Document();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "Movimiento_" + idMovimiento + ".pdf");
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();

                    // Título Principal
                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    doc.Add(new Paragraph("Informe de Movimiento de Inventario", titleFont) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph(" ")); // Espacio en blanco

                    // Información General
                    var sectionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                    doc.Add(new Paragraph("Datos del Movimiento", sectionFont));
                    doc.Add(new Paragraph(" "));

                    var contentFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    doc.Add(new Paragraph("ID de Movimiento: " + Pk_id_movimiento, contentFont));
                    doc.Add(new Paragraph("Estado del Movimiento: " + estado, contentFont));
                    doc.Add(new Paragraph("ID de Producto: " + Fk_id_producto, contentFont));
                    doc.Add(new Paragraph("ID de Stock: " + Fk_id_stock, contentFont));
                    doc.Add(new Paragraph("ID de Local: " + Fk_ID_LOCALES, contentFont));
                    doc.Add(new Paragraph(" ")); // Espacio en blanco

                    // Información de Movimiento
                    doc.Add(new Paragraph("Detalles del Movimiento", sectionFont));
                    doc.Add(new Paragraph(" "));

                    // Información detallada del inventario (ejemplo ficticio)
                    doc.Add(new Paragraph("Producto transferido de bodega a local.", contentFont));
                    
                    doc.Add(new Paragraph("Fecha de Movimiento: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), contentFont));
                    doc.Add(new Paragraph(" ")); // Espacio en blanco

                    // Firma
                    doc.Add(new Paragraph("Firma del Responsable: _______________________", sectionFont));
                    doc.Add(new Paragraph(" "));

                    // Pie de página con fecha y hora
                    var footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 8);
                    doc.Add(new Paragraph("Documento generado automáticamente - Fecha y Hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), footerFont) { Alignment = Element.ALIGN_RIGHT });

                    doc.Close();

                    MessageBox.Show("PDF generado con éxito: " + filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la solicitud ingresada: " + ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

    }
}
