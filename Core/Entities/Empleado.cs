using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Empleado:BaseEntity
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public DateTime FechaIngreso { get; set; }


        public int IdCargoFk { get; set; }
        public Cargo Cargo { get; set; }

        public int IdMunicipioFk { get; set; }
        public Municipio Municipio { get; set; }

        public ICollection<Venta> Venstas  { get; set; }
        public ICollection<Orden> Ordens { get; set; }
    }
}