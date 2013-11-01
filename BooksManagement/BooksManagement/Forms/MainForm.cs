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
        private int pageNum = 1;
        private int totalBookNUm = 0;
        private int totalPageNum = 1;
        private int pageBookNum = 27;
        private int showBookNum = 0;

        private int bookWide = 120;
        private int bookHeight = 200;

        private double lines;
        private double lineBooks;

        private List<BookControl> bookControls = new List<BookControl>();
        private CategoryManagement categoryManagement = new CategoryManagement();
        private BookManagement bookManagement = new BookManagement();

        public delegate void DelegeteInitUI(bool initHoleUI);
        static public DelegeteInitUI DelInitializeUI;



        public MainForm()
        {
            InitializeComponent();
            DelInitializeUI = (InitializeUI);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            InitializeUI(true);
        }

        private void InitializeUI(bool initHoleUI)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new DelegeteInitUI(InitializeUI), new object[] { initHoleUI });
                return;
            }

            if (initHoleUI)
            {
                // Get book number
                totalBookNUm = bookManagement.GetTotalPageNumber();
                if (totalBookNUm == 0)
                {
                    return;
                } 
                ManagePageNum();
            }
            // Show books
            new Thread(ShowRecentlyReadBooks).Start();
        }

        public void ShowRecentlyReadBooks()
        {
            bookControls = bookManagement.GetPageBooks(pageNum, pageBookNum);

            showBookNum = bookControls.Count;

            ShowBooks();
        }


        private void ShowBooks()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(ShowBooks));
                return;
            }
            pBookList.Controls.Clear();

            int index = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lineBooks; j++)
                {
                    if (pBookList.Controls.Count >= showBookNum)
                    {
                        break;
                    }
                    bookControls[index].Location = new Point(bookWide * j, bookHeight * i);

                    pBookList.Controls.Add(bookControls[index]);
                    index++;
                }
            }
        }

        private void ManagePageNum()
        {
            lineBooks = Math.Floor((double)pBookList.Width / bookWide);
            lines = Math.Floor((double)pBookList.Height / bookHeight);
            pageBookNum = (int)(lines * lineBooks);

            totalPageNum = (int)Math.Ceiling((double)totalBookNUm / pageBookNum);
            lblTotalPageNumber.Text = string.Format("共 {0} 页", totalPageNum);

            List<string> selectPageNums = new List<string>();
            for (int i = 1; i <= totalPageNum; i++)
            {
                selectPageNums.Add(i.ToString());
            }
            cbPageNumber.DataSource = selectPageNums;
            cbPageNumber.SelectedIndex = 0;
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
            InitializeUI(true);
        }

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
            InitializeUI(true);
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
            InitializeUI(true);
        }

        #endregion

        #region Book Category

        private void tsmiBookCategory_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.ShowDialog();
        }

        #endregion

        #region Show Style

        private void tsmiRecentlyRead_Click(object sender, EventArgs e)
        {
            ManagePageNum();
            InitializeUI(false);
        }

        private void tsmiCategoryBook_Click(object sender, EventArgs e)
        {

        }

        #endregion

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
            InitializeUI(false);
        }

    }
}
