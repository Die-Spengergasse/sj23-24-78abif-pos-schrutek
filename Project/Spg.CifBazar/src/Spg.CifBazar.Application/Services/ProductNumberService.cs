using Spg.CifBazar.DomainModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Application.Services
{
    public class ProductNumberService : IProductNumberService
    {
        public Guid CreateProductNumber() 
            => Guid.NewGuid();
    }
}
