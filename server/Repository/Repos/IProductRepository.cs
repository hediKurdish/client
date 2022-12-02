using client.Server.models;
using ViewModel;

namespace server.Repository.Repos
{
    public interface IProductRepository
    {
        //Get All Product
        Task<IEnumerable<Product>> GetAllProducts();
        //Get product by id
        Task<Product> GetProductById(int id);
        //By Category
        Task<IEnumerable<Category>> GetCategories();
        //Get cateogry by id
        Task<Category> GetCategoryById(int id);

        //Get product by a category
        Task<IEnumerable<Product>> GetProductsByCategory(int id);
    }
}
