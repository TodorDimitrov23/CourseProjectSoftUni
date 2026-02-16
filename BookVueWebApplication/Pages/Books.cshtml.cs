using BookModelLibrary;
using BookVueSharedLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DAL;
using Microsoft.AspNetCore.Authorization;

namespace BookVueWebApplication.Pages
{
    [Authorize]
    public class BooksModel : PageModel
    {
        public List<Book> Books;
        public string Message;
        public void OnGet(string? message)
        {
            BookManager bookManager = new BookManager(new BookDAL());
            Books = bookManager.GetBooks();

            if (message != null)
            {
                Message = message;
            }
        }
    }
}
