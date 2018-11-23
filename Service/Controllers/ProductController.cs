using AutoMapper;
using Bll.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ViewModel;
using System.Linq;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        // GET: api/Product
        [HttpGet]
        public IActionResult Get()
        {
            var list = _productService.GetAllWithoutPagination().Select(t=>  _mapper.Map<ProductViewModel>(t));
            return Ok(list);
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(_productService.GetById(id));
        }

        // POST: api/Product
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
