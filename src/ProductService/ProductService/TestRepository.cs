using ProductShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService
{
    public class TestRepository : IProductRepository
    {
        public IEnumerable<ProductEntity> Get()
        {
            var products = new List<ProductEntity>();

           products.Add( new ProductEntity() { Code = "Test", Description = "This is a test product", Id = Guid.NewGuid(), Name = "My product" } );
            products.Add(new ProductEntity() { Code = "aaa/111", Description = "Product aaa/111", Id = Guid.NewGuid(), Name = "Product AAA/111" });


                return products;
        }

    }
}
