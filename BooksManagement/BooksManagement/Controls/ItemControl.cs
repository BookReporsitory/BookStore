using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BooksManagement.Forms;
using BooksManagement.classes;

namespace BooksManagement.Controls
{
    public partial class ItemControl : UserControl
    {
        private BookManagement bookManagement = new BookManagement();

        private ShowType showType;

        public ItemControl(ShowType type)
        {
            InitializeComponent();
            showType = type;
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

        private void Book_MouseMove(object sender, MouseEventArgs e)
        {
            if (showType == ShowType.Book)
            {
                BackColor = Color.GreenYellow;
            }
            else if (showType == ShowType.Category)
            {
                BackColor = Color.LightBlue;
            }
            else
            {
                BackColor = Color.LightCyan;
            }
        }

        private void Item_MouseLeave(object sender, System.EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void pbItem_Click(object sender, System.EventArgs e)
        {
            if (showType == ShowType.Book)
            {
                try
                {
                    System.Diagnostics.Process.Start(book.Location);
                    book.ReadTimes++;
                    bookManagement.UpdateaBook(book);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Open book error: " + ex.Message);
                }
            }
            else if (showType == ShowType.Category)
            {
                MainForm.CurrentCategory = category;
                MainForm.DelInitializeUI(true);
            }
            else
            {
                return;
            }
        }

        private void lblItemName_Click(object sender, System.EventArgs e)
        {
            if (showType == ShowType.Book)
            {
                System.Diagnostics.Process.Start(string.Format(BookManagement.URI, book.BookName.Substring(0, book.BookName.LastIndexOf('.'))));
            }
            else if (showType == ShowType.Category)
            {
                MainForm.CurrentCategory = category;
                MainForm.DelInitializeUI(true);
            }
            else
            {
                return;
            }
        }

        private void ItemControl_Load(object sender, System.EventArgs e)
        {
            if (showType == ShowType.Book)
            {
                pbItem.Image = Properties.Resources.book__2_;
                lblItmeName.Text = book.BookName;
                if (!string.IsNullOrEmpty(book.Picutre) && book.Picutre.Contains(".") && File.Exists(book.Picutre))
                {
                    pbItem.Image = new Bitmap(book.Picutre);
                }
            }
            else if (showType == ShowType.Category)
            {
                pbItem.Image = Properties.Resources._803;
                lblItmeName.Text = category.CategoryName;
            }
            else
            {
                return;
            }
        }
    }
}
