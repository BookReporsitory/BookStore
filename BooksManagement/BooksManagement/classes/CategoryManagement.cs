﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BooksManagement.DBOpreation;
using BooksManagement.Properties;

namespace BooksManagement.classes
{
    public class CategoryManagement
    {
        #region Fileds

        private readonly string BaseBookRepositoryPath = @"D:\BookRepository";
        public const string NoCategory = "未分类";
        private const string Pictures = "Pictures";
        public const string BookStoreFolder = @"D:\BookRepository\BookStore";

        #endregion

        #region Life Time
        /// <summary>
        /// Contruction Method 
        /// </summary>
        public CategoryManagement()
        {
            // initialize category folder path.
            string path = DBInteraction.GetBookRepository();
            if (!string.IsNullOrEmpty(path))
            {
                BaseBookRepositoryPath = path;
            }
        }

        #endregion

        #region Static Implement

        static public string GetCategoryName(string path)
        {
            string cn = string.Empty;
            try
            {
                cn = path == BookStoreFolder ? path : path.Remove(0, (BookStoreFolder + "\\").Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cn;
        }

        #endregion

        #region Public Implement

        public void importBookDirectory(string sPath, string categoryPath)
        {
            CopyFolder(sPath, categoryPath);
        }

        /// <summary>
        /// get all tree nodes
        /// </summary>
        /// <returns>the node tree</returns>
        public TreeNode GetTreeNodes()
        {
            if (!Directory.Exists(BookStoreFolder))
            {
                Directory.CreateDirectory(BookStoreFolder);
            }
            if (!Directory.Exists(BookStoreFolder + "\\" + NoCategory))
            {
                Directory.CreateDirectory(BookStoreFolder + "\\" + NoCategory);
            }
            if (!Directory.Exists(BaseBookRepositoryPath + "\\" + Pictures))
            {
                Directory.CreateDirectory(BaseBookRepositoryPath + "\\" + Pictures);
            }

            Category category = DBInteraction.GetNodeCategory("BookStore");

            TreeNode baseNode = new TreeNode();
            baseNode.Tag = category;
            baseNode.Name = BookStoreFolder;
            baseNode.Text = Resources.CategoryForm_InitializeUI_bookLibrary;
            baseNode.ImageIndex = 0;
            baseNode.SelectedImageIndex = 0;

            GetAllDirNode(baseNode);

            return baseNode;
        }
        /// <summary>
        /// create a new tree node
        /// </summary>
        /// <param name="nodeName">node's name</param>
        /// <param name="path">node's parnet's path</param>
        /// <returns></returns>
        public TreeNode CreateTreeNode(string nodeName, string path)
        {
            Category category = DBInteraction.GetNodeCategory(GetCategoryName(path));
            TreeNode newNode = new TreeNode();
            newNode.Text = nodeName;
            newNode.Name = path;
            newNode.Tag = category;
            newNode.ImageIndex = 1;
            newNode.SelectedImageIndex = 1;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return newNode;
        }

        public void ChangeTreeNode(TreeNode delNode, string newName)
        {
            if (!Directory.Exists(delNode.Name))
            {
                return;
            }
            // change folder name
            string newPath = delNode.Name.Remove(delNode.Name.LastIndexOf('\\')) + newName;
            Directory.Move(delNode.Name, newPath);
            // change database category
            string categoryName = ((Category) delNode.Tag).CategoryName;
            ((Category)delNode.Tag).CategoryName = categoryName.Remove(categoryName.LastIndexOf('\\')) + newName;
            DBInteraction.UpdateCategory((Category) delNode.Tag);
        }

        /// <summary>
        /// delete one selected node, before that we need move all fills in it to "noCategory" folder.
        /// </summary>
        /// <param name="delNode"></param>
        public void DeleteTreeNode(TreeNode delNode)
        {
            CopyFolder(delNode.Name, BookStoreFolder + "\\" + NoCategory);

            DeleteCagegoryandBooks(delNode);
            
            Directory.Delete(delNode.Name, true);
            delNode.Remove();
        }

        #endregion

        #region Private Implement
        /// <summary>
        /// recursion method, to get node tree.
        /// </summary>
        /// <param name="parentNode">node tree</param>
        private void GetAllDirNode(TreeNode parentNode)
        {
            parentNode.Expand();
            DirectoryInfo currentDirectoryInfo = new DirectoryInfo(parentNode.Name);
            DirectoryInfo[] subDirectories = currentDirectoryInfo.GetDirectories();

            foreach (DirectoryInfo directory in subDirectories)
            {
                TreeNode childNode = CreateTreeNode(directory.Name, directory.FullName);

                parentNode.Nodes.Add(childNode);

                GetAllDirNode(childNode);
            }
        }

        /// <summary>
        /// delete categories and books using recursion.
        /// </summary>
        /// <param name="delNode"></param>
        private void DeleteCagegoryandBooks(TreeNode delNode)
        {
            //books will be deleted by database Foreign Key
            DBInteraction.DeleteCategory((Category)delNode.Tag);

            foreach (TreeNode node in delNode.Nodes)
            {
                DeleteCagegoryandBooks(node);
            }
        }

        #endregion

        #region Copy Folders

        static public void CopyFolder(string sPath, string dPath)
        {
            Category category = DBInteraction.GetNodeCategory(GetCategoryName(dPath));

            // if need create folder
            if (!Directory.Exists(dPath))
            {
                Directory.CreateDirectory(dPath);
            }

            // copy fields
            BookManagement.CopyDirectoryBooks(sPath, dPath, category);

            // loop the sub folder
            DirectoryInfo sDir = new DirectoryInfo(sPath);
            DirectoryInfo[] subDirArray = sDir.GetDirectories();
            foreach (DirectoryInfo subDir in subDirArray)
            {
                CopyFolder(subDir.FullName, dPath + "\\" + subDir.Name);
            }
        }
        #endregion
    }
}
