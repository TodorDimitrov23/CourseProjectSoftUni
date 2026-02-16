using BookModelLibrary;
using BookVueSharedLibrary;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DAL
{
    public class BookDAL: IBookDAL
    {
        private List<Book> _books;

        public BookDAL()
        {
            _books = new List<Book>()
            {
                new Book(1, "Harry Potter","Order of the Phoenix","Order of the Phoenix is a fantasy novel and the fifth novel in the Harry Potter series","J. K. Rowling",15),
                new Book(2, "The Reason","The Reason","In Isabelle's novel, she takes the reader through the daily struggles of growing up of the main characters, with whom you will discover the meaning of everything that happens to each of us together.","Isabel Ovcharova",15),
            };


            

        }
        public Book GetBookById(int id) 
        {
            foreach (var book in _books)
            {
                if (book.id == id)
                {
                    return book;
                }
            }
            throw new Exception($"Book with id: {id} couldn't be found");
        }
        public List<Book> GetBooks()
        {
            try
            {
                string connectionString = "SqlConnection(\"Data source =LAPTOP-OP95VDKS\\\\SQLEXPRESS; Database=BookShop; integrated security=true\");";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM books";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book bookInfo = new Book(
                                    reader.GetInt32(reader.GetOrdinal("id")),
                                    reader.GetString(reader.GetOrdinal("bookName")),
                                    reader.GetString(reader.GetOrdinal("title")),
                                    reader.GetString(reader.GetOrdinal("description")),
                                    reader.GetString(reader.GetOrdinal("author")),
                                    reader.GetDecimal(reader.GetOrdinal("price"))
                                );
                                _books.Add(bookInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: " + ex.ToString());
            }
            return _books;
        }
    }
}