using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksManagement.classes
{
    public class BookCatalog
    {
        private string bookId;

        private string catalog;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string Catalog
        {
            get { return catalog; }
            set { catalog = value; }
        }
    }
}
