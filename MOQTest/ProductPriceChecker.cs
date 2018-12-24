namespace Models
{
    public class ProductPriceChecker : IPriceChecker
    {

        public PriceStatus GetProductPriceStatus(Product product)
        {
            if (product.Price > 100)
                return PriceStatus.Expensive;
            else if (product.Price > 50 && product.Price <= 100)
                return PriceStatus.Average;
            else
                return PriceStatus.Cheap;
        }
    }
}
