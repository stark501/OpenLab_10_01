using System;

namespace OpenLab_10_01
{
    class Program
    {

        static void Main(string[] args)
        {
            Book Lotr = new Book();
            Lotr.Title = ("Janko Kral");
            Lotr.Pages = ("352");
            Lotr.Category = ("Romantic");
            Lotr.Autor = ("Marina");
            Lotr.ReleaseDate = ("32.7.2004");
        }
        class Book
        {
            private string title;
            private int pages;
            private string category;
            private string author;
            private int releaseDate;

            public void Title(string newTitle) { title = newTitle; }
            public void Pages(int newPages) { pages = newPages; }
            public void Category(string newCategory) { category = newCategory; }
            public void Autor(string newAutor) { autor = newAuthor; }
            public void ReleaseDate(int newReleaseDate) { releaseDate = newReleaseDate; }
            private int pages;
        }
        public void Write()
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }

    }
}
