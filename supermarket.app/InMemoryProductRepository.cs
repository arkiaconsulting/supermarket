using System.Collections.Generic;
using System.Linq;

namespace supermarket.app
{
    public class InMemoryProductRepository : IProductsRepository
    {
        private readonly IEnumerable<Product> _products;

        public InMemoryProductRepository(IEnumerable<Product> products)
        {
            _products = products;
        }

        public IEnumerable<Product> GetByCategory(string categoryName)
        {
            return _products.Where(p => p.Category == categoryName);
        }
    }
}
