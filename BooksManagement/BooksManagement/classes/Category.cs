using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksManagement.classes
{
    public class Category
    {
        private string id;

        private string categoryName;

        private List<Book> books = new List<Book>();

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
    }
}
