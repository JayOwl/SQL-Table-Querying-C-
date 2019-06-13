using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP2614Assign05 A00838629";
            Console.WriteLine("Select province filter:");

            try
            {
                string val;
                string province = "";
                
                ProvincesCollection provinces = ProvincesRepository.GetAllProvincesFromCustomers();
                ConsolePrinter.PrintProvincesCollection(provinces);                

                val = Console.ReadLine();
     
                switch(val)                    
                {                  
                    case "1":
                        province = "WHERE Province = 'AB'";
                        CustomerCollection customers = CustomerRepository.GetAllCustomers(province);
                        Console.WriteLine("Customer listing for AB");
                        Console.WriteLine("\r");
                        ConsolePrinter.PrintCustomerCollection(customers);
                        break;

                    case "2":
                        province = "WHERE Province = 'BC'";
                        CustomerCollection customersBC = CustomerRepository.GetAllCustomers(province);
                        Console.WriteLine("Customer listing for BC");
                        Console.WriteLine("\r");
                        ConsolePrinter.PrintCustomerCollection(customersBC);
                        break;

                    case "3":
                        province = "WHERE Province = 'ON'";
                        CustomerCollection customersON = CustomerRepository.GetAllCustomers(province);
                        Console.WriteLine("Customer listing for ON");
                        Console.WriteLine("\r");
                        ConsolePrinter.PrintCustomerCollection(customersON);
                        break;

                    case "4":
                        province = "WHERE Province = 'SK'";
                        CustomerCollection customersSK = CustomerRepository.GetAllCustomers(province);
                        Console.WriteLine("Customer listing for SK");
                        Console.WriteLine("\r");
                        ConsolePrinter.PrintCustomerCollection(customersSK);
                        break;

                    case "5":
                        province = "";
                        CustomerCollection customersALL = CustomerRepository.GetAllCustomers(province);
                        Console.WriteLine("Customer listing for ALL");
                        Console.WriteLine("\r");
                        ConsolePrinter.PrintCustomerCollection(customersALL);
                        break;
                    default:                 
                        Console.WriteLine("Please try another entry");
                        break;    
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Data Access Error\n\n{ex.Message}\n\n{ex.StackTrace}");

            }
        }
    }
}
