using System;

namespace Modifiers
{
    // access modifiers control how properties and methods are accessed
    class Book
    {
        // TODO: "public" members and methods can be accessed by any other code
        // Note: this is *NOT* the right way to expose internal data
        public string _name;

        // TODO: "protected" members can only be accessed by the class or a 
        // derived class from this one
        protected string _author;

        // TODO: "private" is the default and can only be accessed by code 
        // within the class itself
        private int _pagecount;

        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string GetDescription() {
            return $"{_name} by {_author}, {_pagecount} pages";
        }

        // TODO: Member variables can be accessed via methods
        public string GetName() {
            return _name;
        }

        public void SetName(string name) {
            _name = name;
        }

        public string GetAuthor() {
            return _author;
        }

        public void SetAuthor(string author) {
            _author = author;
        }

        public int GetPageCount() {
            return _pagecount;
        }

        public void SetPageCount(int pages) {
            _pagecount = pages;
        }

    }
}
