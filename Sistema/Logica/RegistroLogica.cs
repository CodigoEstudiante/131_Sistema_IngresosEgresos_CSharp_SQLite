using Sistema.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Logica
{
    public class RegistroLogica
    {
        private static RegistroLogica _instancia = null;

        public RegistroLogica()
        {

        }

        public static RegistroLogica Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new RegistroLogica();

                return _instancia;
            }
        }

        
        public int Guardar(List<Registro> objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            SQLiteTransaction objTransaccion = null;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    objTransaccion = conexion.BeginTransaction(); 
                    StringBuilder query = new StringBuilder();

                    foreach (Registro r in objeto) {
                        query.AppendLine(string.Format("insert into Registros(UsuarioCreacion,FechaCreacion,IdPersona,NombreCliente,IdServicio,DescripcionServicio,Comentario,Fecha,TipoMoneda,Monto,TipoRegistro) values('{0}',{1},{2},'{3}',{4},'{5}','{6}','{7}','{8}','{9}','{10}');",
                            r.UsuarioCreacion,
                            "date('now','localtime')",
                            r.IdPersona,
                            r.NombreCliente,
                            r.IdServicio,
                            r.DescripcionServicio,
                            r.Comentario,
                            r.Fecha,
                            r.TipoMoneda,
                            r.Monto,
                            r.TipoRegistro));
                    }

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Transaction = objTransaccion;
                    respuesta = cmd.ExecuteNonQuery();


                    if (respuesta < 1) {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo registrar el usuario";
                    }

                    objTransaccion.Commit();

                }


            }
            catch (Exception ex)
            {
                objTransaccion.Rollback();
                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public List<Registro> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Registro> oLista = new List<Registro>();

            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select * from Registros";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Registro()
                            {
                                IdRegistro = int.Parse(dr["IdRegistro"].ToString()),
                                FechaCreacion = dr["FechaCreacion"].ToString(),
                                IdPersona = int.Parse(dr["IdPersona"].ToString()),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                IdServicio = int.Parse(dr["IdServicio"].ToString()),
                                DescripcionServicio = dr["DescripcionServicio"].ToString(),
                                Comentario = dr["Comentario"].ToString(),
                                Fecha = dr["Fecha"].ToString(),
                                TipoMoneda = dr["TipoMoneda"].ToString(),
                                Monto = dr["Monto"].ToString(),
                                TipoRegistro = dr["TipoRegistro"].ToString(),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Registro>();
                mensaje = ex.Message;
            }


            return oLista;
        }


    }
}
