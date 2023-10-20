using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class InventarioRepository : GenericRepository<Inventario>, IInventarioRepository
    {
        private readonly AplicationContext _contex;
        public InventarioRepository(AplicationContext context) : base(context)
        {
            _contex =context;
        }
    }
}