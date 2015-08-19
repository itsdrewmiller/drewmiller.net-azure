using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Internal;

namespace Model.Public
{
    // TODO: Move mapping to Automapper
    public class PostService
    {

        private Blog Model { get; set; }

        public PostService()
        {
            Model = new Blog();
        }


        public IEnumerable<Post> GetAll()
        {
            return Model.Posts.ToList().Select(p => p.Map());
        }

        public Post Get(int id)
        {
            return Model.Posts.Where(p => p.Id == id).FirstOrDefault().Map();
        }

        public void Save(Post post)
        {
            if (post == null) { throw new Exception("Don't save null posts you goofball - you must be doing something wrong"); }
            Model.Posts.Add(post.Unmap());
        }
    }

}
