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


        private void addProductButton_Click(object sender, EventArgs e)
        {
            string[] productInfo = new string[] { productNameTextBox.Text, quantityProductTextBox.Text, priceProductTextBox.Text };
            DataManager.AddProduct(dataGridView1, productInfo);
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
            string[] productInfo = new string[] { productNameTextBox.Text, quantityProductTextBox.Text, priceProductTextBox.Text };
            DataManager.ChangeSelectedProduct(dataGridView1, productInfo);
        }

        private void saveToDatabaseButton_Click(object sender, EventArgs e)
        {
            object[] customerData = new object[] { firstNameTextBox.Text, lastNameTextBox.Text, birthDateDateTimePicker.Text };
            DataBaseService.AddingContentToDataBase(customerData, dataGridView1);
            
        }
    }
}
