using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMCM.BL;

namespace TMCM.BLTest
{
    [TestClass()]
    public class ProductRepositoryTests
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 16.74M,
                ProductDescription = "Assorted Size Set of 4 Taylor-Made Web Designed Templates",
                ProductName = "Templates"
            };

            //-- Act
            var actual = productRepository.Retrieve(2);

            //-- Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
}
