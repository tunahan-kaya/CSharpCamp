using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class IndividualCustomer:Customer //Gerçek Müşteri
    {
        public string İdenfinityNumber { get; set; } //eğer bir veri üzerinde matematiksel işlem yapmıyorsak metinsel olarak tanımlamamamız daha mantıklı olur
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
