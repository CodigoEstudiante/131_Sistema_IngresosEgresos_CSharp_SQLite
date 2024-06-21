using Sistema.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Logica
{
    public class PersonaLogica
    {
        
        
        private static PersonaLogica _instancia = null;

        public PersonaLogica()
        {

        }

        public static PersonaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new PersonaLogica();

                return _instancia;
            }
        }
        
        public int Guardar(Persona objeto,out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("insert into Persona(Documento,Nombres,Correo,Clave,TipoPersona) values (@documento,@nombres,@correo,@clave,@tipopersona);");
                    query.AppendLine("SELECT ifnull(MAX(IdPersona),0) FROM Persona WHERE Documento = @documento and Nombres = @nombres  ORDER BY IdPersona DESC LIMIT 1;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@documento", objeto.Documento));
                    cmd.Parameters.Add(new SQLiteParameter("@nombres", objeto.Nombres));
                    cmd.Parameters.Add(new SQLiteParameter("@correo", objeto.Correo));
                    cmd.Parameters.Add(new SQLiteParameter("@clave", objeto.Clave));
                    cmd.Parameters.Add(new SQLiteParameter("@tipopersona", objeto.TipoPersona));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta < 1)
                        mensaje = "No se pudo registrar el usuario";

                }
            } catch (Exception ex) {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public List<Persona> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Persona> oLista = new List<Persona>();

            try {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select IdPersona,Documento,Nombres,Correo,Clave,TipoPersona from Persona";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Persona()
                            {
                                IdPersona = int.Parse(dr["IdPersona"].ToString()),
                                Documento = dr["Documento"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                TipoPersona = dr["TipoPersona"].ToString()
                            });
                        }
                    }
                }
            } catch (Exception ex) {
                oLista = new List<Persona>();
                mensaje = ex.Message;
            }


            return oLista;
        }

        public int Editar(Persona objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update Persona set Documento = @documento,Nombres = @nombres,Correo = @correo,Clave = @clave,TipoPersona = @tipopersona where IdPersona= @idpersona;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idpersona", objeto.IdPersona));
                    cmd.Parameters.Add(new SQLiteParameter("@documento", objeto.Documento));
                    cmd.Parameters.Add(new SQLiteParameter("@nombres", objeto.Nombres));
                    cmd.Parameters.Add(new SQLiteParameter("@correo", objeto.Correo));
                    cmd.Parameters.Add(new SQLiteParameter("@clave", objeto.Clave));
                    cmd.Parameters.Add(new SQLiteParameter("@tipopersona", objeto.TipoPersona));
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

        public int Eliminar(Persona objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("delete from Persona where IdPersona= @idpersona;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idpersona", objeto.IdPersona));
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
