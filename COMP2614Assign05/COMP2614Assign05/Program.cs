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

            try
            {
                // CustomerCollection customers = CustomerRepository.GetAllCustomers();
                CustomerCollection customers = CustomerRepository.GetAllProvincesFromCustomers();

                ConsolePrinter.PrintCustomerCollection(customers);

            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Data Access Error\n\n{ex.Message}\n\n{ex.StackTrace}");

            }
        }
    }
}
