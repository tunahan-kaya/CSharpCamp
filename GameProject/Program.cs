using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                CustomerId = 1,
                NatioanalityId = "17591203222", //fake id
                FirstName = "Tunahan",
                LastName = "Kaya",
                DateOfBirth = new DateTime(2004,04,23),
                CreditCard= "12345678901"
            };
            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.Add(customer1);

            Game game1 = new Game()
            {
                Id = 1,
                Name="Call Of Duty",
                Price=600
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Campaign campaign = new Campaign()
            {
                CampaignName= "Christmas Sale",
                Discount=20
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);


            SalesManager salesManager = new SalesManager();
            salesManager.AddSales(customer1, game1, campaign);

            
            Console.Read();
        }
    }


}
