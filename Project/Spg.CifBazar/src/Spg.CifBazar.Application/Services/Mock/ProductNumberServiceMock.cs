using Spg.CifBazar.DomainModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Application.Services.Mock
{
    public class ProductNumberServiceMock : IProductNumberService
    {
        public Guid CreateProductNumber()
            => new Guid("f575a460-8337-4e7b-a0ab-961b4621fdd8");
    }
}
