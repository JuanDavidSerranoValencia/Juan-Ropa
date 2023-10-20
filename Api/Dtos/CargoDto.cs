using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class CargoDto
    {
        public int Id { get; set; }
        public string NombreCargo { get; set; }
        public int Sueldo { get; set; }
    }
}