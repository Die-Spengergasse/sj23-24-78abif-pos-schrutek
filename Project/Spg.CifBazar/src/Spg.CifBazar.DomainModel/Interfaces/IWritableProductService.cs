﻿using Spg.CifBazar.DomainModel.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Interfaces
{
    public interface IWritableProductService
    {
        ProductDto Create(CreateProductCommand productCommand);
    }
}
