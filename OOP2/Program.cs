using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
       IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Tunahan";
            customer1.LastName = "Kaya";
            customer1.İdenfinityNumber = "1234567890";


            CoorporateCustomer customer2=new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            Customer customer3=new IndividualCustomer(); //gerçek müşteri
            Customer customer4=new CoorporateCustomer(); //tüzel müşteri
        }
    }
}
