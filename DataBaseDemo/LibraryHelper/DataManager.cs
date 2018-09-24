using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseHelper;

namespace DataBaseDemo.LibraryHelper
{
    public static class DataManager
    {
        static int index;

        public static void SetIndex(int value)
        {
            index = value;
        }

        public static void AddProduct(DataGridView dataGridView, string[] texts)
        {
            //Func<string, bool> predicate = (text) => text.Length != 0;
            var checker = texts.All(x => x.Length != 0);
            if (checker)
                dataGridView.Rows.Add(texts);
            else
                MessageBox.Show("Uzupełnij wszystkie dane produktu");
        }

        public static void AddProductToList(string[] productData, object[] customerData)
        {
            var areProductDataComplete = productData.All(x => x.Length != 0);
            var areCustomerDataComplete = customerData.All(x => x.ToString().Length != 0);

            if (areProductDataComplete && areCustomerDataComplete)
            {
                //sprawdz czy taki klient juz istnieje
                var areThereSameCustomer = CustomerCollection.customersCollection.
                    Any
                    (
                    client => client.firstName == (string)customerData[0]
                    && client.lastName == (string)customerData[1]
                    && client.birthDate == Convert.ToDateTime(customerData[2])
                    );
                //jezeli tak, to zdobadz jego index i dodaj nowy produkt
                if (areThereSameCustomer)
                {
                    var indexInList = CustomerCollection.customersCollection.IndexOf
                        (
                        CustomerCollection.customersCollection.
                        Single(client => client.firstName == (string)customerData[0]
                    && client.lastName == (string)customerData[1]
                    && client.birthDate == Convert.ToDateTime(customerData[2]))
                        );
                    CustomerCollection.ordersCollection.Add(
                   new MyOrdersClass()
                   {
                       productName = productData[0],
                       quantity = Convert.ToInt32(productData[1]),
                       price = Convert.ToSingle(productData[2]),
                       customer = CustomerCollection.customersCollection[indexInList]
                   });

                }
                //jezeli nie, to stworz nowego i dodaj nowy produkt
                else
                {
                    CustomerCollection.customersCollection.Add(new MyCustomerClass()
                    {
                        firstName = (string)customerData[0],
                        lastName = (string)customerData[1],
                        birthDate = Convert.ToDateTime(customerData[2])
                    });

                    CustomerCollection.ordersCollection.Add(
                   new MyOrdersClass()
                   {
                       productName = productData[0],
                       quantity = Convert.ToInt32(productData[1]),
                       price = Convert.ToSingle(productData[2]),
                       customer = CustomerCollection.customersCollection[CustomerCollection.customersCollection.Count - 1]
                   });
                }
            }

            else
                MessageBox.Show("Uzupełnij wszystkie pola");
        }

        public static void DeleteSelectedProductFromList(DataGridView dataGridView)
        {
            var productName = (string)dataGridView.Rows[index].Cells[0].Value;
            var quantity = (int)dataGridView.Rows[index].Cells[1].Value;
            var price = (float)dataGridView.Rows[index].Cells[1].Value;

            //var indexInList = CustomerCollection.ordersCollection.IndexOf
            //    (
            //    CustomerCollection.ordersCollection.Single(x => x.ProductName == productName && x.Quantity == quantity && x.Price == price)
            //    );
            //if (CustomerCollection.ordersCollection.Count() > 0)
            //{
            //    //CustomerCollection.ordersCollection.Remove();
            //    CustomerCollection.ordersCollection.RemoveAt(indexInList);
            //}
        }

        public static void ChangeSelectedProductFromList(DataGridView dataGridView, string[] texts)
        {
            //CustomerCollection.ordersCollection[index].
        }

        public static void DeleteSelectedProduct(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count != 0)
                dataGridView.Rows.Remove(dataGridView.Rows[index]);
        }

        public static void ChangeSelectedProduct(DataGridView dataGridView, string[] texts)
        {
            if (dataGridView.Rows.Count != 0)
                dataGridView.Rows[index].SetValues(texts);
        }

        public static void UpdateDataGridView(object[] customerData, DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            var getClientID = (from client in CustomerCollection.customersCollection
                               where (client.firstName == (string)customerData[0] &&
                               client.lastName == (string)customerData[1] &&
                               client.birthDate == Convert.ToDateTime(customerData[2]))
                               select client.customerID).Single();


            var listOfOrders = CustomerCollection.ordersCollection.
                Where(
                x =>
                (!(x.customer.firstName == (string)customerData[0] && x.customer.lastName == (string)customerData[1] && x.customer.birthDate == Convert.ToDateTime(customerData[2]))
                && (x.ClientID == getClientID && x.ClientID != 0))
                ||
                ((x.customer.firstName == (string)customerData[0] && x.customer.lastName == (string)customerData[1] && x.customer.birthDate == Convert.ToDateTime(customerData[2]))
                && x.ClientID == 0)
                ).ToList();
            //var listOfOrders = DataBaseService.listOfOrders.
            //    Where(
            //    x => x.Customer.FirstName == (string)customerData[0] && x.Customer.LastName == (string)customerData[1]
            //    && x.Customer.BirthDate == Convert.ToDateTime(customerData[2])
            //    ).ToList();
            foreach (var order in listOfOrders)
            {
                string[] parameters = new string[] { order.productName, order.quantity.ToString(), order.price.ToString() };
                dataGridView1.Rows.Add(parameters);
            }
        }
    }
}
