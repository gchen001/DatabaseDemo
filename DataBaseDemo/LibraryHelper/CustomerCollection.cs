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
        //public static IList<DataBaseHelper.Customer> customersCollection { get; set; } = new List<Customer>();
        //public static IList<DataBaseHelper.Orders> ordersCollection { get; set; } = new List<Orders>();
        public static List<MyCustomerClass> customersCollection { get; set; } = new List<MyCustomerClass>();
        public static List<MyOrdersClass> ordersCollection { get; set; } = new List<MyOrdersClass>();

        public static void UpdateCollections(List<Customer> customersList, List<Orders> ordersList)
        {
            foreach (var customer in customersList)
            {
                customersCollection.Add(new MyCustomerClass()
                {
                    firstName = customer.FirstName,
                    lastName = customer.LastName,
                    birthDate = customer.BirthDate
                });
            }
            foreach (var order in ordersList)
            {
                ordersCollection.Add(new MyOrdersClass()
                {
                    productName = order.ProductName,
                    quantity = order.Quantity,
                    price = order.Price,
                    ClientID = order.ClientID
                });
            }

        }

        public static void UpdateListBox(ListBox listBox)
        {
            listBox.Items.Clear();

            if (customersCollection != null)
            {
                foreach (var customer in customersCollection)
                {
                    string temp = customer.FirstName.ToString() + " " + customer.LastName.ToString();
                    listBox.Items.Add(temp);
                }
            }

        }

        public static bool CheckForSameCustomer(object[] customerData)
        {
            var data = Convert.ToDateTime(customerData[2]);
            if (customerData.All(x => x.ToString().Length != 0) && ordersCollection != null)
            {
                var areThereSameCustomer = customersCollection.
                    Any
                    (
                    client => client.FirstName == (string)customerData[0]
                    && client.LastName == (string)customerData[1]
                    && client.BirthDate == Convert.ToDateTime(customerData[2])
                    );

                return areThereSameCustomer;
            }

            return false;

        }
    }
}
