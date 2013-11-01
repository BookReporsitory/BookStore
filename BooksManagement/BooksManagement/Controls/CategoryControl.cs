using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BooksManagement.classes;

namespace BooksManagement.Controls
{
    public partial class CategoryControl : UserControl
    {
        private BookManagement bookManagement = new BookManagement();

        public CategoryControl()
        {
            InitializeComponent();
        }

        private Book book = new Book();

        public Book Book
        {
            get { return book; }
            set { book = value; }
        }

        private Category category = new Category();

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        private void Category_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightSkyBlue;
        }

        private void Category_MouseLeave(object sender, System.EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void pbCategory_Click(object sender, System.EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start( book.Location);
                book.ReadTimes++;
                bookManagement.UpdateaBook(book);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open book error: " + ex.Message);
            }
        }

        private void lblCategoryName_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format(BookManagement.URI, book.BookName.Substring(0, book.BookName.LastIndexOf('.'))));
            WebBrowser webBrowser = new WebBrowser();
            //webBrowser.Location = new Point(0, 0);
            //webBrowser.Size = Size;
            //Controls.Add(webBrowser);
            //webBrowser.BringToFront();

            webBrowser.Navigate(string.Format(BookManagement.URI, book.BookName.Substring(0, book.BookName.LastIndexOf('.'))), false);
            //HtmlDocument a = new HtmlDocument();

            //MessageBox.Show(webBrowser.Document,"HtmlInfo");
        }

        private void CategoryControl_Load(object sender, System.EventArgs e)
        {
            lblCategoryName.Text = category.CategoryName;
            if (!string.IsNullOrEmpty(book.Picutre) && book.Picutre.Contains(".") && File.Exists(book.Picutre))
            {
                //pbCategory.Image = new Bitmap(book.Picutre);
            }
        }
    }
}
