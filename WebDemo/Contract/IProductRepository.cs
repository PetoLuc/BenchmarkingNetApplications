using BenchmarkingWebDemo.Domain;

namespace BenchmarkingWebDemo.Contract
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllProducts();
        public Task<List<ProductOptimized>> GetAllProductsOptimized();
    }

}
