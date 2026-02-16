using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookVueSharedLibrary;


namespace BookVueSharedLibrary
{
	internal class Author : BookVUsers
	{
		public string authorName { get; set; }
		public int authorId { get; set; }
		public Author(string authorName, int authorId, int userId, string email, int password) : base(userId, email, password)
		{
			this.authorName = authorName;
			this.authorId = authorId;
		}

		public override void BuyBook()
		{
			base.BuyBook();
		}
		public override void Display()
		{
			
		}
		public void PublishBook()
		{
			
		}
		public string GetAuthorInfo()
		{
			return authorName + " " + authorId;
		}
	}
}
