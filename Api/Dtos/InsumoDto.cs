using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class InsumoDto
    {
        public int Id { get; set; }
        public string NombreInsumo { get; set; }
        public int ValorUnit { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
    }
}