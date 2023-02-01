using GameProject.Abstract;
using GameProject.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CustomerManager : ICustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
            Console.WriteLine("Gamer Added: "+customer.FirstName);
            }
            else
            {
                throw new Exception("Not a real Person.");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Gamer Deleted: " + customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Gamer Upadated: " + customer.FirstName);
        }
    }
}
