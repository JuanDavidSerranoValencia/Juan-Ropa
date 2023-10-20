using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Insumo : BaseEntity
    {
        public string NombreInsumo { get; set; }
        public int ValorUnit { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }

        public ICollection<InsumoPrenda> InsumosPrendas { get; set; }
        public ICollection<InsumoProveedor> InsumosProveedores { get; set; }
    }
}