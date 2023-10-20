using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Estado : BaseEntity
    {
        public string Descripcion { get; set; }

        public int IdTipoEstadoFk { get; set; }
        public TipoEstado TipoEstado { get; set; }


        public ICollection<Orden> Ordens { get; set; }
        public ICollection<Prenda> Prends { get; set; }
        public ICollection<DetalleOrden> DatallesOrdens { get; set; }

    }
}