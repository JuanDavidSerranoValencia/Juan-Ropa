using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public  DateTime FechaIngreso { get; set; }

    }
}