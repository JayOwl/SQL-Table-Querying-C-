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
            string divider = new string('-', 74);
            Console.WriteLine($"{"CompanyName",-40}{"City",-15}{"Prov",-5}{"Postal",-10}{"Hold",-5}");
            Console.WriteLine(divider);
            foreach (Customer customer in customers)
            {
                PrintCustomer(customer);
            }
        }

        public static void PrintCustomer(Customer customer)
        {         
            string credHold;
            credHold = Convert.ToString(customer.CreditHold);
            if (customer.CreditHold == false)
            {
                credHold = "N";
            }
            else if (customer.CreditHold == true)
            {
                credHold = "Y";
            }
            else
            {
                credHold = "";
            }
            
            Console.WriteLine($"{customer.CompanyName,-40}{customer.City,-15}{customer.Province,-5}{customer.PostalCode,-10}{credHold,2}");
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
                Console.WriteLine("        5: All");
        }

        public static void PrintProvinces(Provinces province)
        {         
            Console.WriteLine($" {province.Province,-30}");                       
        }
    }
}
