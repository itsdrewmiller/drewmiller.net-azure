using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Public
{
    public class Post
    {
        public int Id { get; set; }
        public string HtmlText { get; set; }
        public string Subject { get; set; }
    }

    internal static class PostExtensions
    {

        internal static Post Map(this Internal.Post post)
        {
            if (post == null) return null;
            return new Public.Post { Id = post.Id, HtmlText = post.HtmlText, Subject = post.Subject };
        }

        internal static Internal.Post Unmap(this Post post)
        {
            if (post == null) return null;
            return new Internal.Post { Id = post.Id, HtmlText = post.HtmlText, Subject = post.Subject };
        }
    }
}
