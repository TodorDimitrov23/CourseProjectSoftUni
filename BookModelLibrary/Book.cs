using BookVueSharedLibrary;
namespace BookModelLibrary
{
    public class Book
    {
        //public string image { get; set; }
        public int id { get; set; }
        public string bookName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public decimal price { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int id, string bookName, string title, string description, string author, decimal price)
        {
            //this.image = image;
            this.id = id;
            this.bookName = bookName;
            this.title = title;
            this.description = description;
            this.author = author;
            this.price = price;
        }
    }
}