using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseDemo.LibraryHelper;
using DataBaseHelper;



namespace DataBaseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] GetProductData()
        {
            string[] productInfo = new string[] { productNameTextBox.Text, quantityProductTextBox.Text, priceProductTextBox.Text };
            return productInfo;
        }

        public object[] GetCustomerData()
        {
            object[] customerData = new object[] { firstNameTextBox.Text, lastNameTextBox.Text, birthDateDateTimePicker.Value.Date.ToShortDateString() };
            return customerData;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            //string[] productInfo = new string[] { productNameTextBox.Text, quantityProductTextBox.Text, priceProductTextBox.Text };
            //DataManager.AddProduct(dataGridView1, productInfo);
            DataManager.AddProductToList(GetProductData());
            DataManager.UpdateDataGridView(GetCustomerData(), dataGridView1);
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            DataManager.DeleteSelectedProduct(dataGridView1);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataManager.SetIndex(e.RowIndex);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataManager.SetIndex(e.RowIndex);
        }

        private void changeProductButton_Click(object sender, EventArgs e)
        {
            //string[] productInfo = new string[] { productNameTextBox.Text, quantityProductTextBox.Text, priceProductTextBox.Text };
            DataManager.ChangeSelectedProduct(dataGridView1, GetProductData());
        }

        private void saveToDatabaseButton_Click(object sender, EventArgs e)
        {
            //object[] customerData = new object[] { firstNameTextBox.Text, lastNameTextBox.Text, Convert.ToString(birthDateDateTimePicker.Value.Date) };
            DataBaseService.AddingContentToDataBase(GetCustomerData(), dataGridView1);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerCollection.UpdateCollections(DataBaseService.GetCollectionOfCustomers(), DataBaseService.GetCollectionOfOrders());
            CustomerCollection.UpdateListBox(customerListBox1);
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SameCustomerCheck();  
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SameCustomerCheck();
        }

        private void birthDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SameCustomerCheck();
        }

        public void SameCustomerCheck()
        {
            //object[] customerData = new object[] { firstNameTextBox.Text, lastNameTextBox.Text, birthDateDateTimePicker.Value.Date.ToShortDateString() };
            if(CustomerCollection.CheckForSameCustomer(GetCustomerData()))
            {
                DataManager.UpdateDataGridView(GetCustomerData(), dataGridView1);
            }
        }
    }
}
