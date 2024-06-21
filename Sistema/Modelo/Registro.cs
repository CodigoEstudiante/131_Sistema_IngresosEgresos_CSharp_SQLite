using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Registro
    {
        public int IdRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public string FechaCreacion { get; set; }
        public int IdPersona { get; set; }
        public string NombreCliente { get; set; }
        public int IdServicio { get; set; }
        public string DescripcionServicio { get; set; }
        public string Comentario { get; set; }
        public string Fecha { get; set; }
        public string TipoMoneda { get; set; }
        public string Monto { get; set; }
        public string TipoRegistro { get; set; }
    }
}
