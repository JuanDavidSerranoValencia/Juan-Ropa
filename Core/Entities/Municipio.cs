using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Municipio:BaseEntity
    {
        public string NombreMunicipio { get; set; }

        public int IdDepartamentoFK { get; set; }
        public Departamento Departamento { get; set; }
        
        public ICollection<Proveedor> Proveedors { get; set; }
        public ICollection<Empleado> Emplsados { get; set; }
        public ICollection<Empresa> Emspresas { get; set; }
        public ICollection<Cliente> Clienstes { get; set; }
    }
}