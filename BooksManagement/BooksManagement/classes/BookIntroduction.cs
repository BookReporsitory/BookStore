using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksManagement.classes
{
    public class BookIntroduction
    {
        private string bookId;

        private string introduction;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string Introduction
        {
            get { return introduction; }
            set { introduction = value; }
        }
    }
}
