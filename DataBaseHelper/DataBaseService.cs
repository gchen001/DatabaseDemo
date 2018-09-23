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
            using (var context = new CustomerOrdersEntities())
            {
                context.Customer.Add(new Customer()
                {
                    FirstName = (string)clientData[0],
                    LastName = (string)clientData[1],
                    BirthDate = Convert.ToDateTime(clientData[2])
                });

                context.SaveChanges();
            }

            using (var context = new CustomerOrdersEntities())
            {
                string firstName = (string)clientData[0];
                string lastName = (string)clientData[1];
                DateTime birthDate = Convert.ToDateTime(clientData[2]);

                var clientID = context.Customer.
                    Where(x => x.FirstName == firstName && x.LastName == lastName && x.BirthDate == birthDate).
                    Select(y => y.CustomerID).
                    First();
             
                foreach (DataGridViewRow item in productParameters.Rows)
                {
                    object Cell1 = item.Cells[0].Value;
                    object Cell2 = item.Cells[1].Value;
                    object Cell3 = item.Cells[2].Value;


                    context.Orders.Add(new Orders()
                    {
                        ProductName = Cell1.ToString(),
                        Quantity = Convert.ToInt32(Cell2),
                        Price = Convert.ToSingle(Cell3),
                        ClientID = clientID
                    });
                }

                context.SaveChanges();
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
