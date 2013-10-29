using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BooksManagement.Properties;
using BooksManagement.classes;

namespace BooksManagement.Forms
{
    public partial class CategoryForm : Form
    {
        #region Fields

        private CategoryManagement categoryManagement = new CategoryManagement();

        #endregion

        #region Life Time

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            InitializeUI();
        }

        #endregion

        #region Private Implement

        private void InitializeUI()
        {
            TreeNode baseNode = categoryManagement.GetTreeNodes();

            tvCategoryTree.Nodes.Add(baseNode);
        }

        #endregion


        #region Event Method

        private void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            CreateCategoryForm frm = new CreateCategoryForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TreeNode newNode = categoryManagement.CreateTreeNode((string)frm.Tag, tvCategoryTree.SelectedNode.Name + "\\" + (string)frm.Tag);

                tvCategoryTree.SelectedNode.Nodes.Add(newNode);
                tvCategoryTree.SelectedNode.Expand();
                tvCategoryTree.SelectedNode = newNode;
            }
        }

        private void btnChangeNode_Click(object sender, EventArgs e)
        {
            CreateCategoryForm frm = new CreateCategoryForm(tvCategoryTree.SelectedNode.Text);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                categoryManagement.ChangeTreeNode(tvCategoryTree.SelectedNode, (string)frm.Tag);
                InitializeUI();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (tvCategoryTree.SelectedNode.Text == Resources.CategoryForm_InitializeUI_bookLibrary || tvCategoryTree.SelectedNode.Text == CategoryManagement.NoCategory)
            {
                MessageBox.Show(Resources.CategoryManagement_DeleteTreeNode_couldNotDeleteCategory, Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(Resources.CategoryForm_btnDeleteCategory_Click_deleteCategoryText, Resources.CategoryForm_btnDeleteCategory_Click_deleteCategoryTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                categoryManagement.DeleteTreeNode(tvCategoryTree.SelectedNode);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Tag = tvCategoryTree.SelectedNode.Name;
            Close();
        }

        #endregion

    }
}
