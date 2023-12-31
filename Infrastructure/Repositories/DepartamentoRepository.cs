using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamentoRepository
    {
         private readonly AplicationContext _contex;  
        public DepartamentoRepository(AplicationContext context) : base(context)
        {
            _contex =context;
        }
    }
}