using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Net;
using System.Data;


namespace Capa_Modelo_Cotizacion
{
    public class Sentencia
    {
        Conexion cn = new Conexion();
        private string idUsuario;

        public Sentencia(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public Sentencia()
        {

        }

        // combo de 3

        public string[] funllenarCmb(string stabla, string scampo1, string scampo2)
        {
            Conexion cn = new Conexion();
            string[] sCampos = new string[300];
            int i = 0;

            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            /* La sentencia consulta el modelo de la base de datos con cada campo */
            try
            {
                // Muestra la consulta SQL antes de ejecutarla
                Console.Write(ssql);
                MessageBox.Show(ssql);

                OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + stabla + "\n -" + scampo1);
            }

            return sCampos;
        }


        public DataTable funobtener(string stabla, string scampo1, string scampo2)
        {
            Conexion cn = new Conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        /****************************************************************************************************************/
        //2
        public string[] funllenarCmbPerfiles(string stabla, string scampo1, string scampo2)
        {
            Conexion cn = new Conexion();
            string[] sCampos = new string[300];
            int i = 0;

            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;


            try
            {

                Console.Write(ssql);
                MessageBox.Show(ssql);

                OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + stabla + "\n -" + scampo1);
            }

            return sCampos;
        }


        public DataTable funobtenerPerfiles(string stabla, string scampo1, string scampo2)
        {
            Conexion cn = new Conexion();
            string sql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }

        // ////////////////////////////////////////////////////////////////


        public string[] funllenarCboAsigUP(string stabla, string scampo1)
        {
            Conexion cn = new Conexion();
            string[] sCampos = new string[300];
            int i = 0;

            string ssql = "SELECT DISTINCT " + scampo1 + " FROM " + stabla;


            try
            {

                Console.Write(ssql);
                MessageBox.Show(ssql);

                OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[i] = reader.GetValue(0).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + stabla + "\n -" + scampo1);
            }

            return sCampos;
        }


        public DataTable funobtenerAsigUP(string stabla, string scampo1)
        {
            Conexion cn = new Conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
    }
}
