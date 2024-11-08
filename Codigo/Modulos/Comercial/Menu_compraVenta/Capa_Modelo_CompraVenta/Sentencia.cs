namespace Capa_Modelo_CompraVenta
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
    }
}
