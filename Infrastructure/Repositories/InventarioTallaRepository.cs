using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class InventarioTallaRepository : GenericRepository<Inventario>, IInventarioRepository
    {
        private readonly AplicationContext _contex;
        public InventarioTallaRepository(AplicationContext context) : base(context)
        {
            _contex =context;
        }
    }
}