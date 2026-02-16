using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BookModelLibrary;


namespace BookVueSharedLibrary
{
    //class inheritance
    public class BookManager: IBookManagement
	{

		//dependencies injection
		private IBookDAL _booksDAL;
		public int userId { get; set; }

		//private List<Book> books;
		private List<Blog> blogs;  

		public BookManager(IBookDAL bookDAL)
		{
			_booksDAL = bookDAL;
			blogs = new List<Blog>();
		}

		public List<Book> GetBooks()
		{
			return _booksDAL.GetBooks();
		}
		public Book GetBookById(int id)
		{
			return _booksDAL.GetBookById(id);
		}


		public void AddBook(Book book)
		{
			GetBooks().Add(book);
		}

		public void DeleteBook(Book book)
		{
			GetBooks().Remove(book);
		}

		public List<Book> SearchBook(string keyword)
		{
			List<Book> searchResults = new List<Book>();
			foreach (Book book in _booksDAL.GetBooks())
			{
				if (book.title.Contains(keyword) || book.author.Contains(keyword))
				{
					searchResults.Add(book);
				}
			}
			return searchResults;
		}

		public int GetBookAmount()
		{
			return _booksDAL.GetBooks().Count();
		}

		public void UpdateBook(Book book)
		{
			
		}

		public void PermitUserToPostBlog(BookVUsers user)
		{
			
		}

		
	}
}
