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
                //var clientID = (from item
                //               in context.Customer
                //               where item.FirstName == (string)clientData[0] && item.LastName == (string)clientData[1] && item.BirthDate == (DateTime)clientData[2]
                //               select item.CustomerID).Single();

                //productParameters.Rows
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
                        //ClientID = Convert.ToInt32(clientID)
                        //ProductName = item.Cells[0].Value.ToString(),
                        //Quantity = (int?)item.Cells[1].Value,
                        //Price = (float?)item.Cells[2].Value,
                        ////ClientID = Convert.ToInt32(clientID)
                    });
                }

                context.SaveChanges();
            }

            //ProductName = Convert.ToString(item.Cells["productNameColumn1"].Value),
            //            Quantity = Convert.ToInt32(item.Cells["quantityProductColumn2"].Value),
            //            Price = Convert.ToSingle(item.Cells["priceProductColumn3"].Value),
            //            ClientID = Convert.ToInt32(clientID)


        }
    }
}
