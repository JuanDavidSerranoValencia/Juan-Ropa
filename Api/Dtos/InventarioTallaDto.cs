using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class InventarioTallaDto
    {
        public int Id { get; set; }
        public int IdInventarioFk{ get; set; }
        public int IdTallFk{ get; set; }
    }
}