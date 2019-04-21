using System;

namespace ShopApp
{
    public class Item : Entity
    {
        public Guid CardId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}