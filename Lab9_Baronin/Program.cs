namespace Lab9_Baronin
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Library library = new Library();

            library.AddBook(new Book(
                "Кобзар", "Тарас Шевченко", 1840, "Поезiя", 250));

            library.AddBook(new Book(
                "Дюна", "Френк Герберт", 1965, "Фантастика", 500));

            library.AddBook(new Book(
               "Гаррi Поттер", "Джоан Роулiнг", 1997, "Фентезi", 320));

            library.AddBook(new Book(
               "Код да Вiнчi", "Ден Браун", 2003, "Трилер", 450));

            library.AddBook(new Book(
               "1984", "Джордж Орвелл", 1949, "Антиутопiя", 328));

            library.AddBook(new Book(
               "Голоднi Iгри", "Сюзанна Коллiнз", 2008, "Антиутопiя", 374));

            Console.WriteLine("======= All Books =======");
            foreach (var book in library.Books)
            {
                book.PrintInfo();
            }

            Console.WriteLine("\n======= Books by Genre =======");

            var booksByGenre = library.Books
                .Where(book => book.Genre == "Антиутопiя");

            foreach (var book in booksByGenre)
            {
                book.PrintInfo();
            }

            Console.WriteLine("\n======= Books Published After 2000 =======");

            var booksAfter2000 = library.Books
                .Where(book => book.YearOfPublication > 2000);

            foreach (var book in booksAfter2000)
            {
                book.PrintInfo();
            }

            Console.WriteLine("\n======= Books Sorted by Number of Pages =======");

            var booksSortedByPages = library.Books
                .OrderBy(book => book.NumberOfPages);

            foreach (var book in booksSortedByPages)
            {
                book.PrintInfo();
            }

            Console.WriteLine("\n======= Average Number of Pages =======");

            var averagePages = library.Books
                .Average(book => book.NumberOfPages);

            Console.WriteLine($"Average number of pages: {averagePages}");
        }
    }
}


