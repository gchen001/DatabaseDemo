using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseHelper;

namespace DataBaseDemo.LibraryHelper
{
    public static class CustomerCollection
    {
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
                    birthDate = customer.BirthDate,
                    customerID = customer.CustomerID
                    
                });
            }
            foreach (var order in ordersList)
            {
                ordersCollection.Add(new MyOrdersClass()
                {
                    orderID = order.OrderID,
                    productName = order.ProductName,
                    quantity = order.Quantity,
                    price = order.Price,
                    ClientID = order.ClientID
                });
            }

        }

    }
}
