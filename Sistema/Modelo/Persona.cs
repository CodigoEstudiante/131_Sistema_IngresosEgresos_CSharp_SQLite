using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string TipoPersona { get; set; }
    }
}
