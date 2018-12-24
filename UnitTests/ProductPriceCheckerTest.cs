using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Moq;

namespace UnitTests
{
    [TestClass]
    public class ProductPriceCheckerTest
    {
        [TestMethod]
        public void Assert_Product_Price_101_Is_Expensive()
        {
            //arrange 
            Product product = new Product()
            {
                Price = 101
            };

            Mock<IPriceChecker> mock = new Mock<IPriceChecker>();
            mock.Setup(m => m.GetProductPriceStatus(product)).Returns(PriceStatus.Expensive);
            ProductPriceChecker checker = new ProductPriceChecker();

            //act
            var expected = mock.Object.GetProductPriceStatus(product);
            var actual = checker.GetProductPriceStatus(product);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Assert_Product_Price_100_Is_Average()
        {
            //arrange
            Product product = new Product()
            {
                Price = 100
            };

            Mock<IPriceChecker> mock = new Mock<IPriceChecker>();
            mock.Setup(m => m.GetProductPriceStatus(product)).Returns(PriceStatus.Average);
            ProductPriceChecker checker = new ProductPriceChecker();

            //act
            var expected = mock.Object.GetProductPriceStatus(product);
            var actual = checker.GetProductPriceStatus(product);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Assert_Product_Price_20_Is_Cheap()
        {
            //arrange
            Product product = new Product()
            {
                Price = 20
            };

            Mock<IPriceChecker> mock = new Mock<IPriceChecker>();
            mock.Setup(m => m.GetProductPriceStatus(product)).Returns(PriceStatus.Cheap);
            ProductPriceChecker checker = new ProductPriceChecker();

            //act
            var expected = mock.Object.GetProductPriceStatus(product);
            var actual = checker.GetProductPriceStatus(product);

            //assert
            Assert.AreEqual(expected, actual);
        }



    }
}
