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
        public int UserId { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public string ResponceText { get; set; }

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
