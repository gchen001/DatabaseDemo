using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseHelper;

namespace DataBaseDemo.LibraryHelper
{
    public static class CustomerCollection
    {
        public static List<DataBaseHelper.Customer> customersCollection { get; set; }
        public static List<DataBaseHelper.Orders> ordersCollection { get; set; }

        public static void UpdateCollections(List<Customer> customersList, List<Orders> ordersList)
        {
            foreach (var customer in customersList )
            {
                customersCollection.Add(customer);
            }
            foreach (var order in ordersList)
            {
                ordersCollection.Add(order);
            }

        }



        public static void UpdateListBox(ListBox listBox)
        {
            listBox.Items.Clear();

            if(customersCollection != null)
            {
                foreach (var customer in customersCollection)
                {
                    listBox.Items.Add(customer);
                }
            }
            
        }
    }
}
