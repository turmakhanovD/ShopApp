using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextService contextService = new ContextService();

            User user = new User
            {
                Login = "admin",
                Password = "admin"
            };

            Card card = new Card
            {
                UserId = user.Id
            };

            Item item = new Item
            {
                Name = "Coat Gucci",
                Price = 40000,
                CardId = card.Id
            };

            List<Item> items = new List<Item>();
            items.Add(item);

            card.Items = items;

            using (var context = new ShopContext())
            {
                context.Users.Add(user);
                context.Cards.Add(card);
                context.Items.Add(item);

                contextService.AddItem(context);


                context.SaveChanges();
            }

        }
    }
}
