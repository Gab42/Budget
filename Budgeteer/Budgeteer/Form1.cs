using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeteer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();  
                  
            string[] categoryItems = new string[3] { "Food", "Clothes", "Misc" };
            categoryBox.Items.AddRange(categoryItems);
        }

        private void editBudget_Click(object sender, EventArgs e)
        {
            categoryBox.Visible = true;
            dateTimePicker1.Visible = true;
        }

        private void categoryBox_Click(object sender, EventArgs e)
        {
           
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newItem.Visible = true;
            User.TheDate = dateTimePicker1.Value.ToShortDateString();
        }

        private void newItem_Click(object sender, EventArgs e)
        {
            newItem.KeyUp += TextBoxKeyUp;

        }

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {            
                User.NewItemString = newItem.Text;
                User.NewItemCategory = categoryBox.Text;
                e.Handled = true;
            }
        }


    }
}
