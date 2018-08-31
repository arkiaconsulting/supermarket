using System.Collections.Generic;

namespace supermarket.app
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetByCategory(string categoryName);
    }
}