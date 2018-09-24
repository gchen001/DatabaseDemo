using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseDemo.LibraryHelper
{
    public class MyOrdersClass
    {
        public string productName { get; set; }
        public int? quantity { get; set; }
        public float? price { get; set; }
        public int ClientID { get; set; }
    }
}
