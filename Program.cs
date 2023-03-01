using System;
namespace bookRecord
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);
        public static void Main(string[] args)
        {
            Bookstore book1 = new(1, "The Stinking Shore", "Arnold Orbish", 24.35);
            Bookstore book2 = new(2, "The Unforgiving Stone", "Arnold Orbish", 24.35);
            Bookstore book3 = new(3, "The Wrathful Stick", "Arnold Orbish", 24.35);

            Console.WriteLine($"Book One -\nID: {book1.ID}\nTitle: {book1.Title}\nAuthor: {book1.Author}\nPrice: {book1.Price}\n");
            Console.WriteLine($"Book Two -\nID: {book2.ID}\nTitle: {book2.Title}\nAuthor: {book2.Author}\nPrice: {book2.Price}\n");
            Console.WriteLine($"Book Three -\nID: {book3.ID}\nTitle: {book3.Title}\nAuthor: {book3.Author}\nPrice: {book3.Price}");
        }
    }
}