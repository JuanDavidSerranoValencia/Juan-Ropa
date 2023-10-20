using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class FormaPagoRepository : GenericRepository<FormaPago>, IFormaPagoRepository
    {

        private readonly AplicationContext _contex;
        public FormaPagoRepository(AplicationContext context) : base(context)
        {
            _contex =context;
        }
    }
}