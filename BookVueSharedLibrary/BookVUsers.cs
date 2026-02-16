using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVueSharedLibrary
{
    public abstract class BookVUsers
    {
        public int userId { get; set; }
        public string email { get; set; }
        private int password { get; set; }

        public BookVUsers(int userId, string email, int password)
        {
            this.userId = userId;
            this.email = email;
            this.password = password;
        }

        public virtual void BuyBook()
        {

        }
        public virtual int GetUserId() 
        {
            return userId;
        }
		public abstract void Display();
	}
}
