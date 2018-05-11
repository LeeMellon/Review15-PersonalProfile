using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Review15PersonalProfolio.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Blurb { get; set; }
        public string Img { get; set; }
        public string Alt { get; set; }
        public virtual ICollection<Responce> BlogResponces { get; set; }

        public override bool Equals(System.Object otherPost)
        {
            if (!(otherPost is Post))
            {
                return false;
            }
            else
            {
                Post newPost = (Post)otherPost;
                return this.PostId.Equals(newPost.PostId);
            }
        }

        public override int GetHashCode()
        {
            return this.PostId.GetHashCode();
        }

        public void GetBlurb()
        {
            this.Blurb = this.Text.Substring(0, 200) + "...";
        }

      
    }
}
