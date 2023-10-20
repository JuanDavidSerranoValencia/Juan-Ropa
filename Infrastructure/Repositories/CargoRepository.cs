using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class CargoRepository : GenericRepository<Cargo>, ICargoRepository
    {

        private readonly AplicationContext _contex;
        public CargoRepository(AplicationContext context) : base(context)
        {
            _contex =context;
        }
    }
}