using System;

namespace Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new Book instance
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            // In previous example, this would fail, but will now
            // work since the field name is declared as public
            // b1._name = "Cat in the Hat";
            // Console.WriteLine(b1.GetDescription());

            // TODO: set data using functions instead of accessing fields directly
            Book b2 = new Book("The Hobbit", "J.R.R. Tolkien", 295);
            b2.SetName("The Lord of the Rings");
            b2.SetAuthor("J.R.R. Tolkien");
            b2.SetPageCount(1216);
            Console.WriteLine(b1.GetDescription());
        }
    }
}
