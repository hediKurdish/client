using client.Server.models;
using Microsoft.AspNetCore.Mvc;
using server.Repository.Repos;
using ViewModel;

namespace server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repo;
        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduts()
        {
            try
            {
                var products = await _repo.GetAllProducts();

                if (products is not null)
                    return Ok(products);
              
               
                return NotFound();

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Something happened on the server.");
            }
        }
    }
}
