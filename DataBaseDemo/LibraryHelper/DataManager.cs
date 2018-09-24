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

        public static void AddProductToList(string[] texts)
        {
            var checker = texts.All(x => x.Length != 0);
            if (checker)
                CustomerCollection.ordersCollection.Add
                    (
                    new DataBaseHelper.Orders() { ProductName = texts[0], Quantity = Convert.ToInt32(texts[1]), Price = Convert.ToSingle(texts[2]) }
                    );
            else
                MessageBox.Show("Uzupełnij wszystkie dane produktu");
        }

        public static void DeleteSelectedProductFromList(DataGridView dataGridView)
        {
            var productName = (string)dataGridView.Rows[index].Cells[0].Value;
            var quantity = (int)dataGridView.Rows[index].Cells[1].Value;
            var price = (float)dataGridView.Rows[index].Cells[1].Value;

            var indexInList = CustomerCollection.ordersCollection.IndexOf
                (
                CustomerCollection.ordersCollection.Single(x => x.ProductName == productName && x.Quantity == quantity && x.Price == price)
                );
            if (CustomerCollection.ordersCollection.Count() > 0)
            {
                //CustomerCollection.ordersCollection.Remove();
                CustomerCollection.ordersCollection.RemoveAt(indexInList);
            }
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
            var listOfOrders = CustomerCollection.ordersCollection.
                Where(
                x => x.Customer.FirstName == (string)customerData[0] && x.Customer.LastName == (string)customerData[1]
                && x.Customer.BirthDate == Convert.ToDateTime(customerData[2])
                ).ToList();
            //var listOfOrders = DataBaseService.listOfOrders.
            //    Where(
            //    x => x.Customer.FirstName == (string)customerData[0] && x.Customer.LastName == (string)customerData[1]
            //    && x.Customer.BirthDate == Convert.ToDateTime(customerData[2])
            //    ).ToList();
            foreach (var order in listOfOrders)
            {
                string[] parameters = new string[] { order.ProductName, order.Quantity.ToString(), order.Price.ToString() };
                dataGridView1.Rows.Add(parameters);
            }
        }
    }
}
