using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Proveedor:BaseEntity
    {
        public int NitProveedor { get; set; }
        public string NombreProveedor { get; set; }

        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TipoPersona { get; set; }

        public int IdMunicipioFk { get; set; }
        public Municipio Municipio { get; set; }

        public ICollection<InsumoProveedor> InsumosProveedores { get; set; }
    }
}