using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using BooksManagement.Controls;
using BooksManagement.DBOpreation;
using BooksManagement.Properties;
using BooksManagement.classes;

namespace BooksManagement.Forms
{
    public enum ShowType { Book, Category };

    public partial class MainForm : Form
    {
        #region Fields

        private int _pageNum = 1;
        private int _totalItemNUm = 0;
        private int _totalPageNum = 1;
        private int _pageBookNum = 27;
        private int _showBookNum = 0;

        private const int ItemWide = 120;
        private const int ItemHeight = 200;

        private double _lines;
        private double _lineItems;

        private ShowType _showType;
        static private Category _currentCategory;
        static private Stack<Category> _categoryStack = new Stack<Category>();

        private ItemControl[] _itemControls;
        private readonly CategoryManagement categoryManagement = new CategoryManagement();
        private readonly BookManagement bookManagement = new BookManagement();

        public delegate void DelegeteInitBookUI(bool separatePage);
        static public DelegeteInitBookUI DelegeteInitializeUI;

        #endregion

        #region Life Time

        public MainForm()
        {
            InitializeComponent();
            DelegeteInitializeUI = showUI;
        }

        static public Category CurrentCategory
        {
            //get { return _currentCategory; }
            set
            {
                _categoryStack.Push(_currentCategory);
                _currentCategory = value;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblPageMessage.Text = string.Empty;
            lblCategoryMessage.Text = string.Empty;
            _currentCategory = categoryManagement.GetCurrentRootCategory();
            separatePageNum();
        }

        #endregion

        #region Event Action

        private void tsmiCategoryManage_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.ShowDialog();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            separatePageNum();
        }

        #region Control Pages

        private void llblPageUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblPageMessage.Text = string.Empty;
            if (cbPageNumber.SelectedIndex < 1)
            {
                lblPageMessage.Text = "已经是第一页！";
                return;
            }
            cbPageNumber.SelectedIndex--;
        }

        private void llblPageDown_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblPageMessage.Text = string.Empty;
            if (cbPageNumber.SelectedIndex >= (_totalPageNum - 1))
            {
                lblPageMessage.Text = "已经是最后一页！";
                return;
            }
            cbPageNumber.SelectedIndex++;
        }

        private void cbPageNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pageNum = cbPageNumber.SelectedIndex + 1;
            showUI(false);
        }

        private void btnReturnCategory_Click(object sender, EventArgs e)
        {
            if (_categoryStack.Count > 0)
            {
                _currentCategory = _categoryStack.Pop();
                showUI(true);
            }
            else
            {
                lblCategoryMessage.Text = "已到达跟目录！";
            }
        }

        #endregion

        #region Import Books

        private void tsmiImportFiles_Click(object sender, EventArgs e)
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
            showUI(true);
        }

        private void tsmiImportFolder_Click(object sender, EventArgs e)
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
            showUI(true);
        }

        #endregion

        #region Show Style

        private void tsmiRecentlyRead_Click(object sender, EventArgs e)
        {
            if (_showType != ShowType.Book)
            {
                showCategoryBookStyle(ShowType.Book);
                showUI(false);
            }
        }

        private void tsmiCategoryBook_Click(object sender, EventArgs e)
        {
            if (_showType != ShowType.Category)
            {
                showCategoryBookStyle(ShowType.Category);
                showUI(false);
            }
        }

        private void tsmiShowControl_Click(object sender, EventArgs e)
        {
            dgvBooks.Visible = false;
            panelItemList.Visible = true;
        }

        private void tsmiShowList_Click(object sender, EventArgs e)
        {
            dgvBooks.DataSource = DBInteraction.FindBooksByName(Resources.MainForm_tsmiShowList_Click_testBookName);
            dgvBooks.Location = new Point(0, 0);
            dgvBooks.Visible = true;
            panelItemList.Visible = false;
        }

        #endregion

        #endregion

        private void showCategoryBookStyle(ShowType type)
        {
            separatePageNum();
            _showType = type;
            dgvBooks.Visible = false;
            panelItemList.Visible = true;
        }

        private void showControls()
        {
            if (_showType == ShowType.Book)
            {
                _itemControls = bookManagement.GetPageBooks(_pageNum, _pageBookNum);
            }
            else if (_showType == ShowType.Category)
            {
                _itemControls = categoryManagement.GetSubCategories(_currentCategory);
            }

            _showBookNum = _itemControls.Count();

            BeginInvoke(new MethodInvoker(showItems));
        }

        private void showUI(bool separatePage)
        {
            if (separatePage)
            {
                separatePageNum();
            }
            // Show Items
            new Thread(showControls).Start();
        }

        private void showItems()
        {
            if (_showType == ShowType.Book)
            {
                panelCategoryControl.Hide();
                panelPageControl.Show();
            }
            else if (_showType == ShowType.Category)
            {
                lblCategoryMessage.Text = string.Empty;
                panelCategoryControl.Show();
                panelPageControl.Hide();
            }

            panelItemList.Controls.Clear();

            int index = 0;
            for (int i = 0; i < _lines; i++)
            {
                for (int j = 0; j < _lineItems; j++)
                {
                    if (panelItemList.Controls.Count >= _showBookNum)
                    {
                        break;
                    }
                    _itemControls[index].Location = new Point(ItemWide * j, ItemHeight * i);
                    panelItemList.Controls.Add(_itemControls[index]);

                    index++;
                }
            }
        }

        private void separatePageNum()
        {
            _lineItems = Math.Floor((double)panelItemList.Width / ItemWide);

            if (_showType == ShowType.Book)
            {
                _totalItemNUm = bookManagement.GetTotalPageNumber();

                _lines = Math.Floor((double)panelItemList.Height / ItemHeight);

                _pageBookNum = (int)(_lines * _lineItems);

                _totalPageNum = (int)Math.Ceiling((double)_totalItemNUm / _pageBookNum);
                lblTotalPageNumber.Text = string.Format("共 {0} 页", _totalPageNum);

                List<string> selectPageNums = new List<string>();
                for (int i = 1; i <= _totalPageNum; i++)
                {
                    selectPageNums.Add(i.ToString());
                }
                cbPageNumber.DataSource = selectPageNums;
            }
            else if (_showType == ShowType.Category)
            {
                _totalItemNUm = categoryManagement.GetLevelSubCategoryNumber(_currentCategory) + _currentCategory.Books.Length;
                _lines = Math.Ceiling(_totalItemNUm / _lineItems);
            }
        }

    }
}
