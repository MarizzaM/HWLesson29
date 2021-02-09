using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson29
{
    public interface ICustomerDAO
    {
        List<Customer> GetCustomers();
        void InsertCustomer(Customer c);
    }
}
