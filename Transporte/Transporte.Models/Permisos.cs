using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Permisos
    {
        public int IdPermiso { get; set; }
        public int IdAcceso { get; set; }
        public int IdPerfil { get; set; }
        public int IdUsuario { get; set; }
    }
}
