using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InsumoPrenda:BaseEntity
    {
        public int IdPrendaFk { get; set; }
        public Prenda Prenda { get; set; }

        public int IdInsumoFk { get; set; }
        public Insumo Insumo { get; set; }
    }
}