using Sistema.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Logica
{
    public class TipoMonedaLogica
    {

        private static TipoMonedaLogica _instancia = null;

        public TipoMonedaLogica()
        {

        }

        public static TipoMonedaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new TipoMonedaLogica();

                return _instancia;
            }
        }

        public int Guardar(TipoMoneda objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("insert into TipoMoneda(Descripcion) values (@descripcion);");
                    query.AppendLine("SELECT ifnull(MAX(IdTipoMoneda),0) FROM TipoMoneda WHERE Descripcion = @descripcion ORDER BY IdTipoMoneda DESC LIMIT 1;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@descripcion", objeto.Descripcion));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta < 1)
                        mensaje = "No se pudo registrar moneda";

                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }


        public List<TipoMoneda> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<TipoMoneda> oLista = new List<TipoMoneda>();

            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select IdTipoMoneda,Descripcion from TipoMoneda";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new TipoMoneda()
                            {
                                IdTipoMoneda = int.Parse(dr["IdTipoMoneda"].ToString()),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<TipoMoneda>();
                mensaje = ex.Message;
            }


            return oLista;
        }

        public int Eliminar(TipoMoneda objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("delete from TipoMoneda where IdTipoMoneda = @idtipomoneda;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idtipomoneda", objeto.IdTipoMoneda));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }

    }
}
