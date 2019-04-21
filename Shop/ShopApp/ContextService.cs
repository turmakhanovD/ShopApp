using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class ContextService
    {
        public void AddItem(ShopContext context)
        {
            Item item = new Item();
            int price = 0;
            Console.WriteLine("Write item name: ");
            item.Name = Console.ReadLine();

            Console.WriteLine("Write item price");
            while(!int.TryParse(Console.ReadLine(),out price))
            {
                Console.WriteLine("Write price correctly");
            }

            item.Price = price;

            item.CardId = context.Cards.FirstOrDefault().Id;

        }
    }
}
