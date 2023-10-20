using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class InsumoProveedorRepository : GenericRepository<InsumoProveedor>, IIsumoProveedorRepository
    {

         private readonly AplicationContext _contex;
        public InsumoProveedorRepository(AplicationContext context) : base(context)
        {
             _contex =context;
        }
    }
}