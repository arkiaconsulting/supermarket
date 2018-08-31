namespace supermarket.app
{
    public interface IPricePolicy
    {
        double Apply(double price);
    }
}