using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void AddSales(Customer customer, Game game, Campaign campaign)
        {
            int bill = (game.Price * campaign.Discount) / 100;
            bill= game.Price -bill;
            Console.WriteLine("---Sale Completed---");
            Console.WriteLine("Gamer: " + customer.FirstName+" Payment total: "+bill);
        }
    }
}
