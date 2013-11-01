using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BooksManagement.Controls;
using BooksManagement.DBOpreation;
using BooksManagement.Properties;
using BooksManagement.classes;

namespace BooksManagement.Forms
{
    public partial class MainForm : Form
    {
        #region Fields

        private int pageNum = 1;
        private int totalItemNUm = 0;
        private int totalPageNum = 1;
        private int pageBookNum = 27;
        private int showBookNum = 0;
        private int showCategoryNum = 0;

        private int bookWide = 120;
        private int bookHeight = 200;

        private double lines;
        private double lineBooks;

        private bool ShowCategory = false;
        private Category CurrentCategory;

        private List<BookControl> bookControls = new List<BookControl>();
        private List<CategoryControl> categoryControls = new List<CategoryControl>();
        private CategoryManagement categoryManagement = new CategoryManagement();
        private BookManagement bookManagement = new BookManagement();

        public delegate void DelegeteInitBookUI(bool initHoleUI);
        static public DelegeteInitBookUI DelInitializeBooksUI;
        public delegate void DelegeteInitCategoryUI(Category category, bool initHoleUI);
        static public DelegeteInitCategoryUI DelInitializeCategorysUI;

        #endregion

        #region Life Time

        public MainForm()
        {
            InitializeComponent();
            DelInitializeBooksUI = (InitializeBooksUI);
            DelInitializeCategorysUI = (InitializeCategorysUI);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            InitializeBooksUI(true);
        }

        #endregion

        #region Event Action

        private void tsmiBookCategory_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.ShowDialog();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            ShowCurrentUI();
        }

        #region Control Pages

        private void llblPageUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblMessage.Text = string.Empty;
            if (cbPageNumber.SelectedIndex < 1)
            {
                lblMessage.Text = "已经是第一页！";
                return;
            }
            cbPageNumber.SelectedIndex--;
        }

        private void llblPageDown_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblMessage.Text = string.Empty;
            if (cbPageNumber.SelectedIndex >= (totalPageNum - 1))
            {
                lblMessage.Text = "已经是最后一页！";
                return;
            }
            cbPageNumber.SelectedIndex++;
        }

        private void cbPageNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageNum = cbPageNumber.SelectedIndex + 1;
            InitializeBooksUI(false);
        }

        #endregion

        #region Import Books

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
                        bookManagement.ImportBooks(bookFiles, (TreeNode)categoryForm.Tag);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.MainForm_tsmiSelectFiles_Click_ErrorAddBooks + ex.Message);
            }
            InitializeBooksUI(true);
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
                        bookManagement.ImportBookDirectory(folderPath, (TreeNode)categoryForm.Tag);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.MainForm_tsmiSelectFolder_Click_addBooksFolderError + ex.Message);
            }
            InitializeBooksUI(true);
        }

        #endregion

        #region Show Style

        private void tsmiRecentlyRead_Click(object sender, EventArgs e)
        {
            ShowCategory = false;
            InitializeBooksUI(false);
        }

        private void tsmiCategoryBook_Click(object sender, EventArgs e)
        {
            ShowCategory = true;
            InitializeCategorysUI(null, true);
        }

        private void tsmiShowControl_Click(object sender, EventArgs e)
        {
            dgvBooks.Visible = false;
            panelBookList.Visible = true;
            ShowCurrentUI();
        }

        private void tsmiShowList_Click(object sender, EventArgs e)
        {
            dgvBooks.DataSource = DBInteraction.FindBooksByName(Resources.MainForm_tsmiShowList_Click_testBookName);
            dgvBooks.Location = new Point(0, 0);
            dgvBooks.Visible = true;
            panelBookList.Visible = false;
        }

        #endregion

        #endregion

        public void ShowRecentlyReadBooks()
        {
            bookControls = bookManagement.GetPageBooks(pageNum, pageBookNum);

            showBookNum = bookControls.Count;

            ShowBooks();
        }

        public void ShowCurrentLevelCategories()
        {
            categoryControls = categoryManagement.GetPageCategories(pageNum, pageBookNum, CurrentCategory);

            showCategoryNum = categoryControls.Count;

            ShowCategories();
        }

        private void InitializeBooksUI(bool initHoleUI)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new DelegeteInitBookUI(InitializeBooksUI), new object[] { initHoleUI });
                return;
            }

            if (initHoleUI)
            {
                // Get book number
                totalItemNUm = bookManagement.GetTotalPageNumber();
                if (totalItemNUm == 0)
                {
                    return;
                }
                ManagePageNum();
            }
            // Show books
            new Thread(ShowRecentlyReadBooks).Start();
        }

        private void InitializeCategorysUI(Category category, bool initHoleUI)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new DelegeteInitCategoryUI(InitializeCategorysUI), new object[] { category, initHoleUI });
                return;
            }

            if (initHoleUI)
            {
                // Get book number
                if (category == null)
                {
                    category = new Category();
                    category.Id = DBInteraction.GetBookStoreCategoryId();
                }
                totalItemNUm = categoryManagement.GetLevelTotalCategoryNumber(category);
                CurrentCategory = category;
                if (totalItemNUm == 0)
                {
                    return;
                }
                ManagePageNum();
            }
            // Show books
            new Thread(ShowCurrentLevelCategories).Start();
        }

        private void ShowBooks()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(ShowBooks));
                return;
            }
            panelBookList.Controls.Clear();

            int index = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lineBooks; j++)
                {
                    if (panelBookList.Controls.Count >= showBookNum)
                    {
                        break;
                    }
                    bookControls[index].Location = new Point(bookWide * j, bookHeight * i);
                    panelBookList.Controls.Add(bookControls[index]);

                    index++;
                }
            }
        }

        private void ShowCategories()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(ShowCategories));
                return;
            }
            panelBookList.Controls.Clear();

            int index = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lineBooks; j++)
                {
                    if (panelBookList.Controls.Count >= showCategoryNum)
                    {
                        break;
                    }
                   categoryControls[index].Location = new Point(bookWide * j, bookHeight * i);
                   panelBookList.Controls.Add(categoryControls[index]);

                    index++;
                }
            }
        }

        private void ManagePageNum()
        {
            lineBooks = Math.Floor((double)panelBookList.Width / bookWide);
            lines = Math.Floor((double)panelBookList.Height / bookHeight);
            pageBookNum = (int)(lines * lineBooks);

            totalPageNum = (int)Math.Ceiling((double)totalItemNUm / pageBookNum);
            lblTotalPageNumber.Text = string.Format("共 {0} 页", totalPageNum);

            List<string> selectPageNums = new List<string>();
            for (int i = 1; i <= totalPageNum; i++)
            {
                selectPageNums.Add(i.ToString());
            }
            cbPageNumber.DataSource = selectPageNums;
            cbPageNumber.SelectedIndex = 0;
        }

        private void ShowCurrentUI()
        {
            if (ShowCategory)
            {
                InitializeCategorysUI(null, true);
            }
            else
            {
                InitializeBooksUI(false);
            }
        }
    }
}
