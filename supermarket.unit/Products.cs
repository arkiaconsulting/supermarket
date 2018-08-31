using supermarket.app;
using System.Linq;
using Xunit;

namespace supermarket.unit
{
    public class Products
    {
        public class Queries
        {
            private readonly IProductsRepository _repository = new InMemoryProductRepository(TestFixtures.Products.Main);
            private readonly IPricePolicy _defaultPricePolicy = new NotPreferredPricePolicy();

            [Fact]
            public void QueryingProductsAndNoProductShouldReturnEmptyList()
            {
                var queries = new app.Queries(_repository);

                var result = queries.ProductsByCategory(string.Empty, _defaultPricePolicy);

                Assert.Empty(result);
            }

            [Fact]
            public void QueryingProductsFromSpecificCategoryShouldReturnCategoryProductsOnly()
            {
                var expectedCategory = "c1";
                var queries = new app.Queries(_repository);

                var result = queries.ProductsByCategory(expectedCategory, _defaultPricePolicy);

                Assert.Equal(TestFixtures.Products.Main.Where(p => p.Category == expectedCategory), result);
            }

            [Fact]
            public void QueryingProductsFromSpecificCategoryAsPreferredCustomerShouldReturnComputeRightPrices()
            {
                var expectedCategory = "c1";
                var queries = new app.Queries(_repository);

                var result = queries.ProductsByCategory(expectedCategory, new PreferredPricePolicy());

                Assert.Equal(TestFixtures.Products.Main.Where(p => p.Category == expectedCategory), result);
            }
        }
    }
}
