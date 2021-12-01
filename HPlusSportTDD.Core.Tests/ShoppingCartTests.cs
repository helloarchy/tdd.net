using System.Collections.Generic;
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
        
        [Test]
        public void ShouldReturnArticlesAddedToCart()
        {
            var item1 = new AddToCartItem
            {
                ArticleId = 42,
                Quantity = 3
            };
            
            var request = new AddToCartRequest()
                        {
                            Item = item1
                        };
            
            var manager = new ShoppingCartManager();

            var response = manager.AddToCart(request);
            
            var item2 = new AddToCartItem
            {
                ArticleId = 43,
                Quantity = 10
            };

            var request2 = new AddToCartRequest()
            {
                Item = item2
            };

            response = manager.AddToCart(request2);

            Assert.NotNull(response);
            Assert.Contains(item1, response.Items);
            Assert.Contains(item2, response.Items);
        }
    }

    public class ShoppingCartManager
    {
        private List<AddToCartItem> _shoppingCart;

        public ShoppingCartManager()
        {
            _shoppingCart = new List<AddToCartItem>();
        }

        
        public AddToCartResponse AddToCart(AddToCartRequest request)
        {
            _shoppingCart.Add(request.Item);
            
            return new AddToCartResponse()
            {
                Items = _shoppingCart.ToArray()
            };
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