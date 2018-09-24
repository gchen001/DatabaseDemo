using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataBaseHelper
{
    public static class CreatingXML
    {
        public static void CreateCustomerXML(List<Customer> customerList)
        {
            XElement customerFile = new XElement
                ("Customers",
                    from client in customerList
                    select 
                    new XElement("Customer",
                        new XAttribute("CustomerID", client.CustomerID),
                        new XElement("FirstName", client.FirstName),
                        new XElement("LastName", client.LastName),
                        new XElement("BirthDate", client.BirthDate))
                );
            customerFile.Save("CustomersXML.xml");
        }

        public static void CreateOrdersXML(List<Orders> ordersList)
        {
            XElement ordersFile = new XElement
                ("Orders",
                    from order in ordersList
                    select
                    new XElement("Order",
                        new XAttribute("OrderID", order.OrderID),
                        new XElement("ProductName", order.ProductName),
                        new XElement("Quantity", order.Quantity),
                        new XElement("Price", order.Price))
                  );
            ordersFile.Save("OrdersXML.xml");
        }

    }
}
