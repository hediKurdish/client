using client.Server.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using server.Data;
using server.Repository.Repos;
using ViewModel;

namespace server.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly KurdDbcontext _context;

        //DI(Dependency Injection)
        public ProductRepository(KurdDbcontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts() =>
            await _context.Products
                .Include(p => p.Category)
            .Include(p => p.PhoneDetail)
            .Include(p => p.Accessories)
            .Include(p=> p.LaptopDetail)
            .ToListAsync();


        public async Task<IEnumerable<Category>> GetCategories() =>

            await _context.Categories.ToListAsync();

        public async Task<Category> GetCategoryById(int id) =>
            await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);


        public async Task<Product> GetProductById(int id) =>
            await _context.Products
            .Include(p => p.Category)
             .Include(p => p.PhoneDetail)
            .Include(p => p.Accessories)
            .Include(p => p.LaptopDetail)
            .FirstOrDefaultAsync(p => p.Id == id);

        public async Task<IEnumerable<Product>> GetProductsByCategory(int id) =>
            await _context.Products
            .Include(p => p.Category)
            .Include(p => p.PhoneDetail)
            .Include(p => p.Accessories)
            .Include(p => p.LaptopDetail)
            .Where(p => p.CategoryId == id).ToListAsync();
    }
}
