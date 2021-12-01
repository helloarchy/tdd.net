using System.Collections.Generic;

namespace HPlusSportTDD.Core
{
    public interface IShoppingCartManager
    {
        public AddToCartResponse AddToCart(AddToCartRequest request);
        public IEnumerable<AddToCartItem> GetCart();
    }
}