using System.Collections.Generic;

namespace HPlusSportTDD.Core.Tests
{
    public interface IShoppingCartManager
    {
        public AddToCartResponse AddToCart(AddToCartRequest request);
        public IEnumerable<AddToCartItem> GetCart();
    }
}