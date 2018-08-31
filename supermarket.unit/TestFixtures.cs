using supermarket.app;
using System.Collections.Generic;

namespace supermarket.unit
{
    class TestFixtures
    {
        public static class Products
        {
            public static IEnumerable<Product> Main = new List<Product>
            {
                new Product { Id = "12a", Name = "p1", Category = "c1" },
                new Product { Id = "34b", Name = "p2", Category = "c2" },
                new Product { Id = "56c", Name = "p3", Category = "c2" }
            };
        }
    }
}
