namespace Models
{
    public interface IPriceChecker
    {
        PriceStatus GetProductPriceStatus(Product product);
    }
}
