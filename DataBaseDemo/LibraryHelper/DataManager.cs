using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
