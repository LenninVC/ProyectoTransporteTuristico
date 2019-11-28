using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Accesos
    {
        public int IdAcceso { get; set; }
        public string Descripcion { get; set; }
        public int ParentId { get; set; }
        public int Level { get; set; }
        public int Order { get; set; }
        public string Area { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string QueryString { get; set; }
        public string Icon { get; set; }
        public string Estado { get; set; }
    }
}
