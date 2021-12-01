using NUnit.Framework;

namespace HPlusSportTDD.Core.Tests
{
    public class ShoppingCartTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnArticleAddedToCart()
        {
            var item = new AddToCartItem
            {
                ArticleId = 42,
                Quantity = 3
            };

            var request = new AddToCartRequest()
            {
                Item = item
            };

            var manager = new ShoppingCartManager();

            var response = manager.AddToCart(request);
            
            Assert.NotNull(response);
            Assert.Contains(item, response.Items);
        }
    }

    public class ShoppingCartManager
    {
        public AddToCartResponse AddToCart(AddToCartRequest request)
        {
            throw new System.NotImplementedException();
        }
    }

    public class AddToCartResponse
    {
        public AddToCartItem[] Items { get; set; }
    }

    public class AddToCartRequest
    {
        public AddToCartItem Item { get; set; }
    }

    public class AddToCartItem
    {
        public int ArticleId { get; set; }
        public int Quantity { get; set; }
    }
}