using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Pais:BaseEntity
    {
        public string NomPais { get; set; }
        public ICollection<Departamento> Deparstamentos { get; set; }
    }
}