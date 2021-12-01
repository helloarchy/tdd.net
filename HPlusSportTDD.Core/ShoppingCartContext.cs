using Microsoft.EntityFrameworkCore;

namespace HPlusSportTDD.Core
{
    public class ShoppingCartContext : DbContext
    {
        public virtual DbSet<AddToCartItem> Items { get; set; }
        public virtual DbSet<ShoppingCart> Carts { get; set; }

        public ShoppingCartContext() : base() {}
        public ShoppingCartContext(DbContextOptions options) : base(options) {}
    }
}