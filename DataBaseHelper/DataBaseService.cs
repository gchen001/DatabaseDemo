using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseHelper
{
    public static class DataBaseService
    {
        public static void AddingContentToDataBase(object[] clientData, DataGridView productParameters)
        {
            AddCustomer(clientData);

            AddOrders(clientData, productParameters);

        }

        private static void AddOrders(object[] clientData, DataGridView productParameters)
        {
            int customerID = GetCustomerID(clientData);

            using (var context = new CustomerOrdersEntities())
            {
                foreach (DataGridViewRow item in productParameters.Rows)
                {
                    object Cell1 = item.Cells[0].Value;
                    object Cell2 = item.Cells[1].Value;
                    object Cell3 = item.Cells[2].Value;

                    string productName = (string)Cell1;
                    int quantity = Convert.ToInt32(Cell2);
                    float price = Convert.ToSingle(Cell3);

                    //Check for same Orders if there arent, add new order to database
                    var isThereSameOrder = context.Orders
                        .Any(x => x.ProductName == productName &&
                        x.Quantity == quantity &&
                        x.Price == price
                        );

                    if(!isThereSameOrder)
                    {
                        context.Orders.Add(new Orders()
                        {
                            ProductName = Cell1.ToString(),
                            Quantity = Convert.ToInt32(Cell2),
                            Price = Convert.ToSingle(Cell3),
                            ClientID = customerID
                        });
                    }
                    
                }

                context.SaveChanges();
            }
        }

        private static int GetCustomerID(object[] clientData)
        {
            using (var context = new CustomerOrdersEntities())
            {
                string firstName = (string)clientData[0];
                string lastName = (string)clientData[1];
                DateTime birthDate = Convert.ToDateTime(clientData[2]);

                var clientID = context.Customer.
                    Where(x => x.FirstName == firstName && x.LastName == lastName && x.BirthDate == birthDate).
                    Select(y => y.CustomerID).
                    First();
                //var id = (from client in context.Customer
                //          where (client.FirstName == (string)clientData[0] && client.LastName == (string)clientData[1]
                //                && client.BirthDate == Convert.ToDateTime(clientData[2]))
                //          select client.CustomerID).Single();
                return clientID;
            }
        }

        private static void AddCustomer(object[] clientData)
        {
            using (var context = new CustomerOrdersEntities())
            {
                string firstName = (string)clientData[0];
                string lastName = (string)clientData[1];
                DateTime birthDate = Convert.ToDateTime(clientData[2]);

                //check for the same customers
                var isSameCustomerInDataBase = context.Customer
                    .Any(x => x.FirstName == firstName && x.LastName == lastName
                    && x.BirthDate == birthDate);

                if (!isSameCustomerInDataBase)
                {
                    context.Customer.Add(new Customer()
                    {
                        FirstName = (string)clientData[0],
                        LastName = (string)clientData[1],
                        BirthDate = Convert.ToDateTime(clientData[2])
                    });

                    context.SaveChanges();
                }
            }
        }

        public static List<Customer> GetCollectionOfCustomers()
        {
            using (var context = new CustomerOrdersEntities())
            {
                var customerCollection = context.Customer.ToList();
                return customerCollection;
            }
        }

        public static List<Orders> GetCollectionOfOrders()
        {
            using (var context = new CustomerOrdersEntities())
            {
                var ordersCollection = context.Orders.ToList();
                return ordersCollection;
            }
        }
    }
}
