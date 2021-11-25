using System;

namespace OpenLab_10_01
{
    class Program
    {

        static void Main()
        {
            Book Lotr = new Book();
            Lotr.title = "LOTR";
            Console.WriteLine(Lotr.title);
        }
        class Book
        {
            public string title;
            private int pages;
        }


    }
}
