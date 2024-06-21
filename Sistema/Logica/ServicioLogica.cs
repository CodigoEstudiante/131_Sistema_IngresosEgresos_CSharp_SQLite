using Sistema.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Logica
{
    public class ServicioLogica
    {

        private static ServicioLogica _instancia = null;

        public ServicioLogica()
        {

        }

        public static ServicioLogica Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ServicioLogica();

                return _instancia;
            }
        }

        public int Guardar(Servicio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("insert into Servicios(Descripcion,TipoServicio) values (@descripcion,@tiposervicio);");
                    query.AppendLine("SELECT ifnull(MAX(IdServicio),0) FROM Servicios WHERE Descripcion = @descripcion ORDER BY IdServicio DESC LIMIT 1;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@descripcion", objeto.Descripcion));
                    cmd.Parameters.Add(new SQLiteParameter("@tiposervicio", objeto.TipoServicio));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta < 1)
                        mensaje = "No se pudo registrar el servicio";

                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }


        public List<Servicio> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Servicio> oLista = new List<Servicio>();

            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select IdServicio,Descripcion,TipoServicio from Servicios";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Servicio()
                            {
                                IdServicio = int.Parse(dr["IdServicio"].ToString()),
                                Descripcion = dr["Descripcion"].ToString(),
                                TipoServicio = dr["TipoServicio"].ToString(),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Servicio>();
                mensaje = ex.Message;
            }


            return oLista;
        }


        public int Editar(Servicio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update Servicios set Descripcion = @descripcion,TipoServicio = @tiposervicio where IdServicio= @idservicio;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idservicio", objeto.IdServicio));
                    cmd.Parameters.Add(new SQLiteParameter("@descripcion", objeto.Descripcion));
                    cmd.Parameters.Add(new SQLiteParameter("@tiposervicio", objeto.TipoServicio));
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

        public int Eliminar(Servicio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("delete from Servicios where IdServicio= @idservicio;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idservicio", objeto.IdServicio));
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
