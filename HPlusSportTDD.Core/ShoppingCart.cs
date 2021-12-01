using System.Collections.Generic;

namespace HPlusSportTDD.Core
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public virtual List<AddToCartItem> Items { get; set; }
    }
}