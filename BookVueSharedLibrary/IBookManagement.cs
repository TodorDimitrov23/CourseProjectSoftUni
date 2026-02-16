using BookModelLibrary;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVueSharedLibrary
{
	public interface IBookManagement
	{
		void AddBook(Book book);

		void DeleteBook(Book book);

		List<Book> SearchBook(string title);

		void UpdateBook(Book book);
		int GetBookAmount();
	}
}
