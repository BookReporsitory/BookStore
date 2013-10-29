using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksManagement.classes
{
    public class BookDetail
    {
        private string bookId;

        private string author;

        private string translator;

        private string sort;

        private string words;

        private string publisher;

        private DateTime publishDate;

        private string iSBN;

        private string provider;

        private string label;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Translator
        {
            get { return translator; }
            set { translator = value; }
        }

        public string Sort
        {
            get { return sort; }
            set { sort = value; }
        }

        public string Words
        {
            get { return words; }
            set { words = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public DateTime PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }

        public string ISbn
        {
            get { return iSBN; }
            set { iSBN = value; }
        }

        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }
    }
}
