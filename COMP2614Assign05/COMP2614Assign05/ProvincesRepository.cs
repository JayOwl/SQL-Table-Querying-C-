using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
    class ProvincesRepository
    {
        private static readonly string connString = @"Server=tcp:skeena.database.windows.net,1433; 
                                                      Initial Catalog=comp2614;
                                                      User ID=student;
                                                      Password=93nu5/nrCKX;
                                                      Encrypt=True;
                                                      TrustServerCertificate=False;
                                                      Connection Timeout=30;";

        public static ProvincesCollection GetAllProvincesFromCustomers()
        {
            ProvincesCollection provinces;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT DISTINCT Province
                                From Customer";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();
                    provinces = new ProvincesCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
            
                        string province = null;
            

                        while (reader.Read())
                        {


                            if (!reader.IsDBNull(0))
                            {
                                province = reader["Province"] as string;
                            }

                           

                            provinces.Add(new Provinces(province));


                            province = null;


                        }
                    }

                }
                return provinces;

            }

        }
    }
}
