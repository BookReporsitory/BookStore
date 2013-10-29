using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BooksManagement.DBOpreation;
using BooksManagement.Properties;
using BooksManagement.classes;
using Book = BooksManagement.Controls.Book;

namespace BooksManagement.Forms
{
    public partial class MainForm : Form
    {
        private List<Book> books = new List<Book>();
        private CategoryManagement categoryManagement = new CategoryManagement();
        private BookManagement bookManagement = new BookManagement();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            showRecentlyReadBooks();
        }

        private void showRecentlyReadBooks()
        {
            Thread getBooks = new Thread(findbooks);
            getBooks.Start();

        }

        private void findbooks()
        {
            int margin = 5;
            int bookCount = 24;
            int bookWide = 100;
            int bookHight = 140;
            double lines = Math.Ceiling((double)bookCount * (bookWide + margin) / Width) + 1;
            double lineBooks = Math.Floor((double)(Width - 30) / (bookWide + margin));

            books.Clear();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lineBooks; j++)
                {
                    if (books.Count >= bookCount)
                    {
                        break;
                    }
                    Book book = new Book();
                    book.Location = new Point(bookWide * j + margin, bookHight * i);
                    books.Add(book);
                }
            }
            BeginInvoke((MethodInvoker)fieledPanel);
        }

        private void fieledPanel()
        {
            pBookList.Controls.Clear();
            foreach (var book in books)
            {
                pBookList.Controls.Add(book);
            }
        }

        private void tsmiShowBook_Click(object sender, EventArgs e)
        {
            dgvBooks.Visible = false;
            pBookList.Visible = true;
        }

        private void tsmiShowList_Click(object sender, EventArgs e)
        {
            dgvBooks.DataSource = DBInteraction.FindBooksByName(Resources.MainForm_tsmiShowList_Click_testBookName);
            dgvBooks.Location = new Point(0, 0);
            dgvBooks.Visible = true;
            pBookList.Visible = false;
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            showRecentlyReadBooks();
        }

        private void tsmiSelectFiles_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = Resources.MainForm_tsmiSelectFiles_Click_addBooks;
            openFileDialog.Filter = "All File(*.*)|*.*";
            openFileDialog.ValidateNames = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = true;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] bookFiles = openFileDialog.FileNames;
                    CategoryForm categoryForm = new CategoryForm();
                    if (categoryForm.ShowDialog() == DialogResult.OK)
                    {
                        bookManagement.ImportBooks(bookFiles, (string)categoryForm.Tag);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.MainForm_tsmiSelectFiles_Click_ErrorAddBooks + ex.Message);
            }

        }

        private void tsmiSelectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = Resources.MainForm_tsmiSelectFolder_Click_addBooksFolderPlease;
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowserDialog.ShowNewFolderButton = false;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    CategoryForm categoryForm = new CategoryForm();
                    if (categoryForm.ShowDialog() == DialogResult.OK)
                    {
                        categoryManagement.importBookDirectory(folderPath, (string) categoryForm.Tag);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.MainForm_tsmiSelectFolder_Click_addBooksFolderError + ex.Message);
            }
        }

        private void tsmiAddCategory_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.ShowDialog();
        }

        private void tsmiDeleteCategory_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.ShowDialog();
        }

    }
}
