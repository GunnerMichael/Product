using System;
using System.Collections.Generic;

namespace ProductShared
{
    /// <summary>
    /// Contract interface for getting product data
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>Gets this instance.</summary>
        /// <returns>A list of <see cref="ProductEntity"/> </returns>
        IEnumerable<ProductEntity> Get();
    }
}
