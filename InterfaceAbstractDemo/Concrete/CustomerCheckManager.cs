using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    //programımızı mernis doğrulamasız test etmek istersek
    internal class CustomerCheckManager : ICustomerCheckService 
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;    
        }
    }
}
