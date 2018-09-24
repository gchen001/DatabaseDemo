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

        public static void AddProductToList(string[] productData, object[] customerData, DataGridView datagridView)
        {
            var areProductDataComplete = productData.All(x => x.Length != 0);
            var areCustomerDataComplete = customerData.All(x => x.ToString().Length != 0);

            bool areSameOrdersInDataGridAlready = CheckForSameOrdersInDataGrid(productData, datagridView);
            if (!areSameOrdersInDataGridAlready)
            {
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

                        //aktualizowanie danych w tabeli
                        UpdateDataGridView(customerData, datagridView);

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

                        //aktualizowanie danych w tabeli
                        UpdateDataGridView(customerData, datagridView);
                    }
                }

                else
                    MessageBox.Show("Uzupełnij wszystkie pola");
            }
            else
            {
                MessageBox.Show("Zamowienie o takich parametrach juz istnieje");
            }

        }

        private static bool CheckForSameOrdersInDataGrid(string[] productData, DataGridView datagridView)
        {
            if (datagridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in datagridView.Rows)
                {
                    string nameproduct = row.Cells[0].Value.ToString();
                    string quantity = row.Cells[1].Value.ToString();
                    string price = row.Cells[2].Value.ToString();

                    if (nameproduct == productData[0] && quantity == productData[1] && price == productData[2])
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
            return false;
        }

        public static void DeleteSelectedProductFromList(DataGridView dataGridView, object[] customerData)
        {
            if (dataGridView.Rows.Count > 0)
            {
                var productName = (string)dataGridView.Rows[index].Cells[0].Value;
                var quantity = Convert.ToInt32(dataGridView.Rows[index].Cells[1].Value);
                var price = Convert.ToSingle(dataGridView.Rows[index].Cells[2].Value);

                string firstName = (string)customerData[0];
                string lastName = (string)customerData[1];
                DateTime birthDate = Convert.ToDateTime(customerData[2]);

                //TODO: usuwanie zamowien z listy zamowien dla klientow z bazy danych
                var getIndexFromList = CustomerCollection.ordersCollection.IndexOf
                    (CustomerCollection.ordersCollection.Single
                    (x => x.productName == productName && x.quantity == quantity && x.price == price
                   && x.customer.firstName == firstName && x.customer.lastName == lastName && x.customer.birthDate == birthDate));

                CustomerCollection.ordersCollection.RemoveAt(getIndexFromList);
                UpdateDataGridView(customerData, dataGridView);
            }
        }

        public static void ChangeSelectedProductFromList(DataGridView dataGridView, string[] productData, object[] customerData)
        {
            if (dataGridView.Rows.Count > 0)
            {
                var productName = (string)dataGridView.Rows[index].Cells[0].Value;
                var quantity = Convert.ToInt32(dataGridView.Rows[index].Cells[1].Value);
                var price = Convert.ToSingle(dataGridView.Rows[index].Cells[2].Value);

                string firstName = (string)customerData[0];
                string lastName = (string)customerData[1];
                DateTime birthDate = Convert.ToDateTime(customerData[2]);

                //TODO: usuwanie zamowien z listy zamowien dla klientow z bazy danych
                var getIndexFromList = CustomerCollection.ordersCollection.IndexOf
                    (CustomerCollection.ordersCollection.Single
                    (x => x.productName == productName && x.quantity == quantity && x.price == price
                   && x.customer.firstName == firstName && x.customer.lastName == lastName && x.customer.birthDate == birthDate));

                CustomerCollection.ordersCollection[getIndexFromList].productName = productData[0];
                CustomerCollection.ordersCollection[getIndexFromList].quantity = Convert.ToInt32(productData[1]);
                CustomerCollection.ordersCollection[getIndexFromList].price = Convert.ToSingle(productData[2]);

                UpdateDataGridView(customerData, dataGridView);
            }
        }
        //public static void DeleteSelectedProduct(DataGridView dataGridView, object[] v)
        //{
        //    if (dataGridView.Rows.Count != 0)
        //        dataGridView.Rows.Remove(dataGridView.Rows[index]);
        //}

        //public static void ChangeSelectedProduct(DataGridView dataGridView, string[] texts)
        //{
        //    if (dataGridView.Rows.Count != 0)
        //        dataGridView.Rows[index].SetValues(texts);
        //}

        public static void UpdateDataGridView(object[] customerData, DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            var getClientID = (from client in CustomerCollection.customersCollection
                               where (client.firstName == (string)customerData[0] &&
                               client.lastName == (string)customerData[1] &&
                               client.birthDate == Convert.ToDateTime(customerData[2]))
                               select client.customerID).Single();

            //creating lists of order for certain client (clients taken from database has valid clientID property and clients made
            // during runtime has only customer (first,last and birthday) valid value and clientID equals to 0)
            var listOfOrders = CustomerCollection.ordersCollection.
                Where(
                x =>
                (!(x.customer.firstName == (string)customerData[0] && x.customer.lastName == (string)customerData[1] && x.customer.birthDate == Convert.ToDateTime(customerData[2]))
                && (x.ClientID == getClientID && x.ClientID != 0))
                ||
                ((x.customer.firstName == (string)customerData[0] && x.customer.lastName == (string)customerData[1] && x.customer.birthDate == Convert.ToDateTime(customerData[2]))
                && x.ClientID == 0)
                ).ToList();

            foreach (var order in listOfOrders)
            {
                string[] parameters = new string[] { order.productName, order.quantity.ToString(), order.price.ToString() };
                dataGridView1.Rows.Add(parameters);
            }
        }
    }
}
