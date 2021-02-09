using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson29
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDAO custDAO = new CustomerDAO();

            List<Customer> customers = custDAO.GetCustomers();

            Customer c = new Customer
            {
                Id = 1,
                FirstName = "Marina",
                LastName = "Pavlova",
                Age = 18,
                AddressCity = "Beer Sheva",
                AddressStreet = "Meer Grossman",
                PhNumber = "052000000"
            };

            custDAO.InsertCustomer(c);

        }
    }
}
