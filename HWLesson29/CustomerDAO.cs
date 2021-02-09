using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson29
{
    public class CustomerDAO : ICustomerDAO
    {
        List<Customer> customers = new List<Customer>();
        public List<Customer> GetCustomers()
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\User\\Desktop\\SQLite\\29.db; Version = 3;"))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * from Customer", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer c = new Customer
                            {
                                Id = (int)reader["ID"],
                                FirstName = (string)reader["FIRST_NAME"],
                                LastName = (string)reader["LAST_NAME"],
                                Age = (int)reader["AGE"],
                                AddressCity = (string)reader["ADDRESS_CITY"],
                                AddressStreet = (string)reader["ADDRESS_STREET"],
                                PhNumber = (string)reader["PN_NUMBER"]
                            };

                            customers.Add(c);
                            // ID	NAME	AGE	ADDRESS	SALARY
                            // Console.WriteLine($"{reader["ID"]} \t{reader["FIRST_NAME"]} \t{reader["LAST_NAME"]} \t{reader["AGE"]}" +
                            //  $"  \t{reader["ADDRESS_CITY"]} \t{reader["ADDRESS_STREET"]} \t{reader["PN_NUMBER"]}");
                        }
                    }
                }
            }
            return customers;
        }
        public void InsertCustomer(Customer c)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\User\\Desktop\\SQLite\\29.db; Version = 3;"))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO Customer VALUES ({c.Id}, '{c.FirstName}', '{c.LastName}', {c.Age}, '{c.AddressCity}', '{c.AddressStreet}', '{c.PhNumber}' )", con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
