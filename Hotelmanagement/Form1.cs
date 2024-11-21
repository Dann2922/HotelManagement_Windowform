using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelmanagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void book_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(gb101.Text);
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtName101.Text });
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtPhone101.Text });
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dtpCheckIn101.Text });
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dtpCheckOut101.Text });

            listView1.Items.Add(newItem);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void book201_Click(object sender, EventArgs e)
        {

            ListViewItem newItem = new ListViewItem(gb201.Text);
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtName201.Text });
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtPhone201.Text });
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dtpCheckIn201.Text });
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dtpCheckOut201.Text });

            listView1.Items.Add(newItem);
        }

        private void book202_Click(object sender, EventArgs e)
        {

        }

        private void book102_Click(object sender, EventArgs e)
        {

        }

        private void dtpCheckOut101_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
