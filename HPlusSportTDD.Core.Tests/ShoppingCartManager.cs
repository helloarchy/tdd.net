using System.Collections.Generic;

namespace HPlusSportTDD.Core.Tests
{
    public class ShoppingCartManager : IShoppingCartManager
    {
        private List<AddToCartItem> _shoppingCart;

        public ShoppingCartManager()
        {
            _shoppingCart = new List<AddToCartItem>();
        }
        
        public AddToCartResponse AddToCart(AddToCartRequest request)
        {
            // Check item exists before adding
            var existingItem = _shoppingCart.Find(item => item.ArticleId == request.Item.ArticleId);
            if (existingItem != null)
            {
                existingItem.Quantity += request.Item.Quantity;
            }
            else
            {
                _shoppingCart.Add(request.Item);
            }

            return new AddToCartResponse()
            {
                Items = _shoppingCart.ToArray()
            };
        }

        public AddToCartItem[] GetCart()
        {
            return _shoppingCart.ToArray();
        }
    }
}