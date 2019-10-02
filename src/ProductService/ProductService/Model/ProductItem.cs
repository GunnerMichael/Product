using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Model
{
    /// <summary>
    /// Item that represents a product in the API
    /// </summary>
    public class ProductItem
    {
        /// <summary>
        /// Unique product identifer
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Product Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// URI to the main product image
        /// </summary>
        public string PrimaryImageUri { get; set; }
    }
}
