using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleadoRepository
    {
         private readonly AplicationContext _contex;
        public EmpleadoRepository(AplicationContext context) : base(context)
        {
            _contex =context;
        }
    }
}