using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Colores:BaseEntity
    {
        public string DescripcionColor { get; set; }

        
        public ICollection<DetalleOrden> DatallesOrdens { get; set; }
    }
}