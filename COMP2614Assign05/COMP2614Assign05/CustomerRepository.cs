using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
    class CustomerRepository
    {

        private static readonly string connString = @"Server=tcp:skeena.database.windows.net,1433; 
                                                      Initial Catalog=comp2614;
                                                      User ID=student;
                                                      Password=93nu5/nrCKX;
                                                      Encrypt=True;
                                                      TrustServerCertificate=False;
                                                      Connection Timeout=30;";

        public static CustomerCollection GetAllCustomers(string byProvince)
        {
            
            CustomerCollection customers;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $"SELECT CustomerCode, CompanyName, Address, City, Province, PostalCode, CreditHold From Customer {byProvince}";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();
                    customers = new CustomerCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string customerCode = null;
                        string companyName = null;
                        string address = null;
                        string city = null;
                        string province = null;
                        string postalCode = null;
                        bool creditHold = false;

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                customerCode = reader["CustomerCode"] as string;
                            }

                            if (!reader.IsDBNull(1))
                            {
                                companyName = reader["CompanyName"] as string;
                            }

                            if (!reader.IsDBNull(2))
                            {
                                address = reader["Address"] as string;
                            }

                            if (!reader.IsDBNull(3))
                            {
                                city = reader["City"] as string;
                            }

                            if (!reader.IsDBNull(4))
                            {
                                province = reader["Province"] as string;
                            }

                            if (!reader.IsDBNull(5))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }

                            if (!reader.IsDBNull(6))
                            {
                                creditHold = (bool)reader["CreditHold"];
                            }                         

                            customers.Add(new Customer(customerCode, companyName, address, city, province, postalCode, creditHold));

                            customerCode = null;
                            companyName = null;
                            address = null;
                            city = null;
                            province = null;
                            postalCode = null;
                            creditHold = false;

                        }
                    }

                }
                return customers;
            }
        }

    }
}



