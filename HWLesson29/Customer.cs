using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson29
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string PhNumber { get; set; }

        public override string ToString()
        {
            return $"\nCustomer {Id} {FirstName} {LastName} {Age} years old\n{AddressCity}, {AddressStreet}\n" +
                $"tel: {PhNumber}";
        }
    }
}
