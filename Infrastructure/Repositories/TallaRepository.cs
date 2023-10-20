using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class TallaRepository : GenericRepository<Talla>, ITallaRepository
    {
        private readonly AplicationContext _contex;
        public TallaRepository(AplicationContext context) : base(context)
        {
             _contex =context;
        }
    }
}