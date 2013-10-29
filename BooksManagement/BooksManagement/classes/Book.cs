using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksManagement.classes
{
    public class Book
    {
        #region Files

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string categoryId;

        public string CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        private string picutre;

        public string Picutre
        {
            get { return picutre; }
            set { picutre = value; }
        }

        private string uRI;

        public string URI
        {
            get { return uRI; }
            set { uRI = value; }
        }

        private int readTimes;

        public int ReadTimes
        {
            get { return readTimes; }
            set { readTimes = value; }
        }

        private BookCatalog bookCatalog = new BookCatalog();

        public BookCatalog BookCatalog
        {
            get { return bookCatalog; }
            set { bookCatalog = value; }
        }

        private BookDetail bookDetail = new BookDetail();

        public BookDetail BookDetail
        {
            get { return bookDetail; }
            set { bookDetail = value; }
        }

        private BookIntroduction bookIntroduction = new BookIntroduction();

        public BookIntroduction BookIntroduction
        {
            get { return bookIntroduction; }
            set { bookIntroduction = value; }
        }

        #endregion

    }
}
