using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShared
{
    public class ProductEntity
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PrimaryImageUri { get; set; }
    }
}
