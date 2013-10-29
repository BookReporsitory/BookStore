using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BooksManagement.DBOpreation;

namespace BooksManagement.Forms
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = DBInteraction.FindBooksByName("乌合之众");

            label1.Text = dt.Rows.Count.ToString();

            foreach (DataRow item in dt.Rows)
            {
                label1.Text += "   " + item[0] + "   " + item[1] + "   " + item[2] + "   " + item[3] + "   " + item[4];
            }

            dgvBooks.DataSource = DBInteraction.FindBooksByName("乌合之众");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = DBInteraction.UpdateBookName("乌合之众", "2").ToString();
        }
    }
}
