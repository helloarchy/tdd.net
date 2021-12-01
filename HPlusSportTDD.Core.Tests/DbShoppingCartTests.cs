using Moq;
using Moq.EntityFrameworkCore;
using NUnit.Framework;

namespace HPlusSportTDD.Core.Tests
{
    public class DbShoppingCartTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnArticlesInCart()
        {
            var initialItems = new[]
            {
                new AddToCartItem
                {
                    ArticleId = 42,
                    Quantity = 3
                }
            };

            var mockedContext = new Mock<ShoppingCartContext>();
            mockedContext.Setup(context => context.Items).ReturnsDbSet(initialItems);

            var manager = new DbShoppingCartManager(mockedContext.Object);
            var items = manager.GetCart();

            Assert.AreEqual(initialItems, items);
        }
    }
}