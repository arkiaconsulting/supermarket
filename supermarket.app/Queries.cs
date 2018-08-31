using System.Collections.Generic;

namespace supermarket.app
{
    public class Queries
    {
        private readonly IProductsRepository _productsRepository;

        public Queries(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public IEnumerable<Product> ProductsByCategory(string categoryName, IPricePolicy pricePolicy)
        {
            var products = _productsRepository.GetByCategory(categoryName);
            foreach (var product in products)
                product.Price = pricePolicy.Apply(product.Price);

            return products;
        }
    }
}