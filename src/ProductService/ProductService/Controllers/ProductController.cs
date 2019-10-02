using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductService.Model;
using ProductService.Response;
using ProductShared;

namespace ProductService.Controllers
{
    /// <summary>
    /// Product API for accessing product data
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _productRepository;

        /// <summary>
        /// Initializes a new instance of the ProductController
        /// </summary>
        /// <param name="logger">instance of a logger to use</param>
        /// <param name="productRepository">instance of the product repostitory used to read data</param>
        public ProductController(ILogger<ProductController> logger,
            IProductRepository productRepository)
        {
            _logger = logger;
            this._productRepository = productRepository;
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult Post([FromBody]ProductItem item)
        {
            Guid id = Guid.NewGuid();

            return AcceptedAtAction(nameof(Get), new { id = id }, id);
        }

        /// <summary>
        /// Get a product
        /// </summary>
        /// <returns>A ProductListResponse object</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<ProductListResponse> Get([FromRoute]string id)
        {
            return Ok();
        }

        /// <summary>
        /// Get a list of products
        /// </summary>
        /// <returns>A ProductListResponse object</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<ProductListResponse> Get()
        {
            var x = new ProductListResponse();

            var items = MapProduct(_productRepository.Get());

            x.Products.AddRange(items);

            return Ok(x);
        }

        /// <summary>
        /// Map between the internal product entity and the one exposed by the API
        /// </summary>
        /// <param name="products">source product data</param>
        /// <returns>the mapped data</returns>
        private IEnumerable<Model.ProductItem> MapProduct(IEnumerable<ProductShared.ProductEntity> products)
        {
            List<Model.ProductItem> mapped = new List<Model.ProductItem>();
            foreach(var item in products)
            {
                var mapItem = new Model.ProductItem() { Code = item.Code, Description = item.Description, Id = item.Id, Name = item.Name, PrimaryImageUri = item.PrimaryImageUri };
                mapped.Add(mapItem);
            }

            return mapped;
        }
    }
}
