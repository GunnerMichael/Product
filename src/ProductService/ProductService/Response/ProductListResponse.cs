using ProductService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Response
{
    /// <summary>
    /// object representing the ProductListResponse returned by making a GET call to the API
    /// </summary>
    public class ProductListResponse
    {
        /// <summary>
        /// list to hold the products
        /// </summary>
        private List<ProductEntity> products = new List<ProductEntity>();

        /// <summary>
        /// List of products
        /// </summary>
        public List<ProductEntity> Products => products;
    }
}
