using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class InventarioDto
    {
        public int Id { get; set; }    
         public int CodInventario { get; set; }
         public int IdPrenda { get; set; }
         public int ValorVtaCop { get; set; }
         public int ValorVtaUsd { get; set; }
    }
}