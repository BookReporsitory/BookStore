using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using BooksManagement.Controls;
using BooksManagement.DBOpreation;
using BooksManagement.Forms;
using BooksManagement.Properties;

namespace BooksManagement.classes
{
    public class BookManagement
    {
        #region Field

        public const string URI = "http://book.douban.com/subject_search?search_text={0}";

        #endregion

        public List<ItemControl> GetPageBooks(int pageNum, int pageBookNum)
        {
            List<ItemControl> bookControls = new List<ItemControl>();

            List<Book> books = DBInteraction.GetPageBooks(pageBookNum, pageNum);

            foreach (Book book in books)
            {
                ItemControl bookControl = new ItemControl(ShowType.Book);
                bookControl.Book = book;
                bookControls.Add(bookControl);
            }

            return bookControls;
        }

        public int GetTotalPageNumber()
        {
            return Convert.ToInt32(DBInteraction.GetTotalBookNumbers());
        }

        public void ImportBooks(string[] books, TreeNode node)
        {
            if (books.Length == 0)
            {
                return;
            }
            string categoryPath = node.Name;
            Category category = (Category)node.Tag;
            // First copy the book files into goal-folder
            foreach (string bookFullName in books)
            {
                string[] b = bookFullName.Split('\\');
                string bookName = b[b.Length - 1];
                File.Copy(bookFullName, (categoryPath + "\\" + bookName));
                AddaBook(bookName, categoryPath, category);
            }
            new Thread(GetBookPicutres).Start();
        }

        public void ImportBookDirectory(string sPath, TreeNode categoryNode)
        {
            CategoryManagement.CopyFolder(sPath, categoryNode.Name, ((Category)categoryNode.Tag).Id);

            new Thread(GetBookPicutres).Start();
        }

        /// <summary>
        /// get the default book picture
        /// </summary>
        private void GetBookPicutres()
        {
            List<Book> allBooks = DBInteraction.GetAllBooks();
            WebClient wc = new WebClient();

            foreach (Book book in allBooks)
            {
                if (!string.IsNullOrEmpty(book.Picutre))
                {
                    continue;
                }
                byte[] pageSourceBytes = wc.DownloadData(new Uri(string.Format(URI, book.BookName.Substring(0, book.BookName.LastIndexOf('.')))));
                string pageSource = Encoding.GetEncoding("utf-8").GetString(pageSourceBytes);

                MatchCollection mc = Regex.Matches(pageSource, @"<\s?img[^>]+src=""([^""]+)""");
                List<string> pic = new List<string>();
                foreach (Match m in mc)
                {
                    if (m.Success)
                    {
                        pic.Add(m.Groups[1].Value.Trim());
                    }

                }
                if (pic.Count > 0 && pic[0].Substring(pic[0].LastIndexOf('.')) == ".jpg")
                {
                    string bookName = @"D:\BookRepository\Pictures\" + book.Id + book.BookName + ".jpg";
                    DownloadFile(pic[0], bookName, null);
                    book.Picutre = bookName;
                    UpdateaBook(book);
                }
            }
            MainForm.DelInitializeUI(true);
        }

        /// <summary>
        /// Download a file
        /// </summary>
        /// <param name="URL">The url of resource file</param>
        /// <param name="Filename">The location of download file</param>
        /// <param name="Prog">progress bar used to show the process of download</param>
        public void DownloadFile(string URL, string filename, ProgressBar prog)
        {
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;

                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }

                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    System.Windows.Forms.Application.DoEvents();
                    so.Write(by, 0, osize);

                    if (prog != null)
                    {
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, by.Length);
                }
                so.Close();
                st.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DownloadFile error: " + ex.Message);
            }
        }

        static public void CopyDirectoryBooks(string sPath, string dPath, Category category)
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
            book.URI = string.Format(URI, fileName);
            DBInteraction.AddOneBook(book);

            book.BookDetail.BookId = book.Id;
        }
        
        public void UpdateaBook(Book book)
        {
            DBInteraction.UpdateBook(book);
        }
    }
}
