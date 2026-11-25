namespace Lab9_Baronin
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public string Genre { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string name, string author, int yearofpublication, string genre, int numberofpages)
        {
            Name = name;
            Author = author;
            YearOfPublication = yearofpublication;
            Genre = genre;
            NumberOfPages = numberofpages;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}, {Author}, {YearOfPublication}, {Genre}, {NumberOfPages}");
        }
    }
}

