using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseDemo.LibraryHelper
{
    public class MyCustomerClass
    {
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime? birthDate { get; set; }
    }
}
