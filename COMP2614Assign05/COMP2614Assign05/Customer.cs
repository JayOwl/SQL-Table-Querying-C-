using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
    class Customer
    {
        public string CustomerCode { get; set; }

        public string CompanyName { get;  }

        public string Address { get; }

        public string City { get; }
        
        public string Province { get; }

        public string PostalCode { get; }

        public bool CreditHold { get; }

        public Customer(string customerCode, string companyName, string address, string city, string province, string postalCode, bool creditHold)
        {
            CustomerCode = customerCode;
            CompanyName = companyName;
            Address = address;
            City = city;
            Province = province;
            PostalCode = postalCode;
            CreditHold = creditHold;
        }

    }
}
