using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Reporte
    {
        
        public string FechaCreacion { get; set; }
        public string TipoRegistro { get; set; }
        public string Fecha { get; set; }
        public string DescripcionServicio { get; set; }
        public string Comentario { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string TipoMoneda { get; set; }
        public string Monto { get; set; }
    }
}
