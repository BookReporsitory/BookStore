using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksManagement.classes
{
    public class Category
    {
        private string id;

        private string parentId;

        private string categoryName;

        private Book[] books = new Book[0];

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

        public Book[] Books
        {
            get { return books; }
            set { books = value; }
        }

        public string ParentId
        {
            get { return parentId; }
            set { parentId = value; }
        }
    }
}
