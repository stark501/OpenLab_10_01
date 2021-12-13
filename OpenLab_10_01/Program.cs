using System;

namespace OpenLab_10_01
{
    class Program
    {

        static void Main(string[] args)
        {
            Book Lotr = new Book();
            Book Lotr2 = new Book();
            Book Lotr3 = new Book("Janko Kral", 352);
            Book HOBIT = new Book("Janko Kral", 352, "Mária Ďuríčková", 2004);
            Lotr.Title = "Janko Kral";
            Lotr.Pages = 352;
            Lotr.Category = "Romantic";
            Lotr.Autor = "Marina";
            Lotr.ReleaseDate = 2004;
            Lotr.WriteParameters();
        }
        class Book
        {
            private string title
            { get; set; }
            private int pages;
            public int Pages
            {
                get
                {
                    return pages;
                }
                set
                {
                    if (value < 0)
                    {
                        pages = 1;
                    }
                    else
                    {
                        pages = value;
                    }
                }
            }
            private string Category
            { get; set; }
        private string Autor
            { get; set; }
            private int releaseDate;
            public int ReleaseDate
            {
                get
                {
                    return releaseDate;
                }
                set
                {
                    if (value < 1450 && value > 2021)
                    {
                        releaseDate = -1;
                    }
                    else
                    {
                        releaseDate = value;
                    }
                }
            }
            public Book()
            {
                Title = "-1";
                Pages = -1;
                Category = "-1";
                Autor = "-1";
                ReleaseDate = -1;
            }

            Book(string title, int pages)
            {
                this.Title = title;
                this.Pages = pages;
                Autor = "-1";
                Category = "-1";
                ReleaseDate = -1;
            }

            public Book(string title, int pages, string category, string author, int releaseDate)
            {
                this.Title = title;
                this.Pages = pages;
                this.Category = category;
                this.Autor = Autor;
                this.ReleaseDate = releaseDate;
            }
            public void WriteParameters()
            {
                Console.WriteLine(title);
                Console.WriteLine(pages);
                Console.WriteLine(Category);
                Console.WriteLine(Autor);
                Console.WriteLine(releaseDate);
            }

        }
       
    }
}
