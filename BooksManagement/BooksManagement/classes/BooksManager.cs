using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BooksManagement.DBOpreation;
using BooksManagement.Properties;

namespace BooksManagement.classes
{
    public class BooksManager
    {
        #region Field

        public const string BaseURI = "http://read.douban.com/search?q=";

        #endregion

        public bool ImportBooks(string[] books)
        {
            if (books.Length == 0)
            {
                return false;
            }
            // First copy the book files into goal-folder
            foreach (string bookPath in books)
            {

            }

            return false;
        }

        public void ImportFolder(string sourceDirectory, Category category)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirectory);
            FileInfo[] fileInfo = directoryInfo.GetFiles();

            if (!sourceDirectory.Contains(CategoryManagement.BookStoreFolder))
            {
                foreach (FileInfo file in fileInfo)
                {
                    file.CopyTo(CategoryManagement.BookStoreFolder + "\\" + category.CategoryName + "\\" + file.Name);
                }
            }
            foreach (FileInfo file in fileInfo)
            {
                AddaBook(file.Name, sourceDirectory, category);
            }

            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo dir in directories)
            {
                ImportFolder(dir.ToString(), category);
            }
        }

        static public void CopyBooks(string sPath, string dPath, Category category)
        {
            DirectoryInfo sDir = new DirectoryInfo(sPath);
            FileInfo[] fileArray = sDir.GetFiles();
            foreach (FileInfo file in fileArray)
            {
                try
                {
                    file.CopyTo(dPath + "\\" + file.Name);
                    AddaBook(file.Name, dPath, category);
                }
                catch (IOException)
                {
                    //The destination file already exists, let user choose which one will be saved.
                    string[] folder = dPath.Split('\\');
                    DialogResult dialogResult =
                        MessageBox.Show(String.Format(Resources.CategoryManagement_DeleteTreeNode_fileAlreadyExistText,
                                                      file.Name, folder[folder.Length - 1]), Resources.CategoryManagement_DeleteTreeNode_fileAlreadyExistTitle,
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        file.CopyTo(dPath + "\\" + file.Name, true);
                        AddaBook(file.Name, dPath, category);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format(Resources.CategoryManagement_DeleteTreeNode_moveFileError, file, ex.Message), Resources.Error_Title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        static private void AddaBook(string fileName, string dPath, Category category)
        {
            Book book = new Book();
            book.Id = Guid.NewGuid().ToString();
            book.BookName = fileName;
            book.CategoryId = category.Id;
            book.Location = dPath + "\\" + fileName;
            book.URI = BaseURI + fileName;
            DBInteraction.AddOneBook(book);

            book.BookDetail.BookId = book.Id;
        }
    }
}
