using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookVueSharedLibrary;

namespace BookVueSharedLibrary
{
	public class Blog
	{
		public int blogId { get; set; }
		public string title { get; set; }
		public string content { get; set; }
		public string blogAuthor { get; set; }

        public Blog()
        {
            
        }
		public string GetBlogInfo()
		{
			return title + " " + content + " " + blogAuthor;
		}
    }
}
