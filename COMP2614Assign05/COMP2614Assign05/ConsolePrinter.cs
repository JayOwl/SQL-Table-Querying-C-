using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
    class ConsolePrinter
    {
        public static void PrintCustomerCollection(CustomerCollection customers)
        {
            string divider = new string('-', 70);

            foreach (Customer customer in customers)
            {
                PrintCustomer(customer);
            }
        }

        public static void PrintCustomer(Customer customer)
        {
            Console.WriteLine($"{customer.CompanyName,-30}{customer.City,-30}{customer.Province,-30}{customer.PostalCode,-30}{customer.CreditHold,-30}");
        }

        public static void PrintProvincesCollection(ProvincesCollection provinces)
        {
            string divider = new string('-', 70);
            int count = 0;

            foreach (Provinces province in provinces)
            {
                count++;
                Console.Write($"        {count}{":"}"); 
                PrintProvinces(province);              
            }   
        }

        public static void PrintProvinces(Provinces province)
        {         
            Console.WriteLine($" {province.Province,-30}");                       
        }
    }
}
