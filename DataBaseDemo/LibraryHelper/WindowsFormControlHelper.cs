using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseDemo.LibraryHelper
{
    public static class WindowsFormControlHelper
    {


        public static void UpdateListBox(ListBox listBox)
        {
            listBox.Items.Clear();

            if (CustomerCollection.customersCollection != null)
            {
                foreach (var customer in CustomerCollection.customersCollection)
                {
                    string temp = customer.firstName.ToString() + " " + customer.lastName.ToString() + " " + Convert.ToDateTime(customer.birthDate).ToShortDateString();
                    listBox.Items.Add(temp);
                }
            }

        }

        public static void UpdateTextBoxes(TextBox[] textboxes, DateTimePicker birthDateDateTimePicker, ListBox listBox)
        {
            var ValuesFromListBox = listBox.Items[listBox.SelectedIndex].ToString();

            string[] customerData = ValuesFromListBox.Split(new char[] { ' ' });

            textboxes[0].Text = customerData[0];
            textboxes[1].Text = customerData[1];
            birthDateDateTimePicker.Value = Convert.ToDateTime(customerData[2]);
        }
    }
}
