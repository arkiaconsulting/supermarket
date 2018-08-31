using System;
using System.Collections.Generic;

namespace supermarket.app
{
    public sealed class Product : IEquatable<Product>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Product);
        }

        public bool Equals(Product other)
        {
            return other != null &&
                   Id == other.Id &&
                   Name == other.Name &&
                   Price == other.Price;
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}