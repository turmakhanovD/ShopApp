using System;
using System.Collections.Generic;

namespace ShopApp
{
    public class Card : Entity
    {
        public Guid UserId { get; set; }
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
