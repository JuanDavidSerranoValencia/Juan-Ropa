using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class PrendaDto
    {
        public int IdPrenda { get; set; }
        public string NombrePrenda { get; set; }
        public int ValorUnitCop { get; set; }
        public int ValorUnitUsd { get; set; }
    }
}