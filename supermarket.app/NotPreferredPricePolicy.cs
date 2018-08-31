namespace supermarket.app
{
    public class NotPreferredPricePolicy : IPricePolicy
    {
        public double Apply(double price)
        {
            return price;
        }
    }
}