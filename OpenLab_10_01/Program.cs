using System;

namespace OpenLab_10_01
{
    class Program
    {

        static void Main(string[] args)
        {
            Book Lotr = new Book();
            Lotr.SetTitle ("Janko Kral");
            Lotr.SetPages (352);
            Lotr.SetCategory ("Romantic");
            Lotr.SetAutor ("Marina");
            Lotr.SetReleaseDate (2004);
            Lotr.WriteParameters();
        }
        class Book
        {
            private string title;
            private int pages;
            private string category;
            private string autor;
            private int releaseDate;

            public void SetTitle(string newTitle) { title = newTitle; }
            public void SetPages(int newPages) { pages = newPages; }
            public void SetCategory(string newCategory) { category = newCategory; }
            public void SetAutor(string newAutor) { autor = newAutor; }
            public void SetReleaseDate(int newReleaseDate) { releaseDate = newReleaseDate; }
            public void WriteParameters()
            {
                Console.WriteLine(title);
                Console.WriteLine(pages);
                Console.WriteLine(category);
                Console.WriteLine(autor);
                Console.WriteLine(releaseDate);
            }

        }
       
    }
}
