using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            dataGridView1["productNameColumn1", 0].Value = "Cheetos";
            dataGridView1["priceProductColumn3", 0].Value = 3;
            dataGridView1["quantityProductColumn2", 0].Value = 2;

        }
    }
}
