namespace ShopApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ShopContext : DbContext
    {
        public ShopContext()
            : base("name=ShopContext")
        {
        }

         public virtual DbSet<User> Users { get; set; }
         public virtual DbSet<Item> Items { get; set; }
         public virtual DbSet<Card> Cards { get; set; }
    }
}