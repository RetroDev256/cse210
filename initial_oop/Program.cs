// It is common that member variable are prefixed with an underscore
// this is a common visual hint that the variable belongs to the instance,
// when it is used in member functions.

class Book
{
    public string? title;
    public string? author;
    public int pageCount;

    public string GetSummary()
    {
        return $"{title} by {author} has {pageCount} pages";
    }
}

class Program
{
    static void Main()
    {
        Book bookOne = new Book();
        bookOne.title = "The Way of Kings";
        bookOne.author = "Brandon Sanderson";
        bookOne.pageCount = 1001;

        Book bookTwo = new Book();
        bookTwo.title = "Words of Radiance";
        bookTwo.author = "Brandon Sanderson";
        bookTwo.pageCount = 1080;

        Book bookThree = new Book();
        bookThree.title = "Oathbringer";
        bookThree.author = "Brandon Sanderson";
        bookThree.pageCount = 1233;

        Book bookFour = new Book();
        bookFour.title = "Rhythm of War";
        bookFour.author = "Brandon Sanderson";
        bookFour.pageCount = 1232;

        Book bookFive = new Book();
        bookFive.title = "Wind and Truth";
        bookFive.author = "Brandon Sanderson";
        bookFive.pageCount = 1344;

        List<Book> books = new List<Book>();
        books.Add(bookOne);
        books.Add(bookTwo);
        books.Add(bookThree);
        books.Add(bookFour);
        books.Add(bookFive);

        foreach (Book book in books)
        {
            string summary = book.GetSummary();
            Console.WriteLine(summary);
        }

    }
}