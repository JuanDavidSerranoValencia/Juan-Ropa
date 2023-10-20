using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoPersona:BaseEntity
    {
        public string NombreTipoPer { get; set; }

        public ICollection<Proveedor> Proveedors { get; set; }
        public ICollection<Cliente> Clienstes { get; set; }
    }
}