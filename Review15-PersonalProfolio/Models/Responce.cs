using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Review15PersonalProfolio.Models
{
    [Table("Responces")]
    public class Responce
    {
        [Key]
        public int ResponceId { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        [ForeignKey("PostId")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public string ResponceTitle { get; set; }
        public string ResponceText { get; set; }

        public Responce() { }

        public Responce(string userId, int postId, string responceTitle, string responceText)
        {
            UserId = userId;
            PostId = postId;
            ResponceTitle = responceTitle;
            ResponceText = responceText;
        }

        public override bool Equals(System.Object otherResponce)
        {
            if (!(otherResponce is Responce))
            {
                return false;
            }
            else
            {
                Responce newResponce = (Responce)otherResponce;
                return this.ResponceId.Equals(newResponce.ResponceId);
            }
        }

        public override int GetHashCode()
        {
            return this.ResponceId.GetHashCode();
        }
    }
}
