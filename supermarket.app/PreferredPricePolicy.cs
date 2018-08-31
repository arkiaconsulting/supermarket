namespace supermarket.app
{
    public class PreferredPricePolicy : IPricePolicy
    {
        public double Apply(double price)
        {
            return price * (1 - 0.1);
        }
    }
}