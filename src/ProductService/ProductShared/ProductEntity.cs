using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShared
{
    /// <summary>
    /// Product Entity class used internally and not for public consumption via API
    /// </summary>
    public class ProductEntity
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
