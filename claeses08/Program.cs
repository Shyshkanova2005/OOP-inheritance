using System;

namespace claeses08

{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        protected int ISBN { get; set; }

        public Book(string title, string author, int isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"Заголовок: {Title}, Автор {Author}, номер {ISBN}");
        }

    }

    class EBook : Book
    {
        public int FileSize { get; set; }

        public EBook(string title, string author, int isbn, int filesize) 
            : base (title, author, isbn)
        {
            FileSize = filesize;
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Розмір файлу: {FileSize}");
        }

    }

    class PrintedBook : Book
    {
        public int PageCount { get; set; }

        public PrintedBook(string title, string author, int isbn, int pagecount)
    : base(title, author, isbn)
        {
            PageCount = pagecount;
        }

        public new void ShowInfo()
        {
            base.ShowInfo(); 
            Console.WriteLine($"Кількість сторінок: {PageCount}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            EBook ebook = new EBook("Гарі Поттер", "Роулінг", 123, 34);
            ebook.ShowInfo();

            PrintedBook printedbook = new PrintedBook("Гра престолів", "Мартін", 456, 600);
            printedbook.ShowInfo();
        }
    }
}
