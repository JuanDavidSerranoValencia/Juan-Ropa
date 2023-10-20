using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente : BaseEntity
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaRegistro { get; set; }

        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TipoPersona { get; set; }

        public int IdMunicipioFk { get; set; }
        public Municipio Municipio { get; set; }

         public ICollection<Orden> Ordens { get; set; }
        public ICollection<Venta> Venstas { get; set; }
    }
}