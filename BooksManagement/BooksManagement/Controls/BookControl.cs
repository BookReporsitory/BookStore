using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BooksManagement.classes;

namespace BooksManagement.Controls
{
    public partial class BookControl : UserControl
    {
        private BookManagement bookManagement = new BookManagement();

        public BookControl()
        {
            InitializeComponent();
        }

        private Book book = new Book();

        public Book Book
        {
            get { return book; }
            set { book = value; }
        }

        private void Book_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.GreenYellow;
        }

        private void Book_MouseLeave(object sender, System.EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void pbBook_Click(object sender, System.EventArgs e)
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

        private void lblBookName_Click(object sender, System.EventArgs e)
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

        private void BookControl_Load(object sender, System.EventArgs e)
        {
            lblBookName.Text = book.BookName;
            if (!string.IsNullOrEmpty(book.Picutre) && book.Picutre.Contains(".") && File.Exists(book.Picutre))
            {
                pbBook.Image = new Bitmap(book.Picutre);
            }
        }
    }
}
