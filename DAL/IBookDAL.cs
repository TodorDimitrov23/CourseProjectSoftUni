using BookModelLibrary;
using BookVueSharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IBookDAL
    {
        List<Book> GetBooks();
        Book GetBookById(int id);
        //get bookbyname
    }
}
