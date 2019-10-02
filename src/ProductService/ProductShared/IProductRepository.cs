using System;
using System.Collections.Generic;

namespace ProductShared
{
    public interface IProductRepository
    {
        IEnumerable<ProductEntity> Get();
    }
}
