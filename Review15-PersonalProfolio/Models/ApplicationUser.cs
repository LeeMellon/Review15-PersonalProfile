using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Review15PersonalProfolio.Models
{
    [Table("Users")]
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public string UserId { get; set; }
        public string Role { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string ProfileName { get; set; }
        public virtual ICollection<Responce> Responces { get; set; }

        public override bool Equals(System.Object otherApplicationUser)
        {
            if (!(otherApplicationUser is ApplicationUser))
            {
                return false;
            }
            else
            {
                ApplicationUser newApplicationUser = (ApplicationUser)otherApplicationUser;
                return this.UserId.Equals(newApplicationUser.UserId);
            }
        }

        public override int GetHashCode()
        {
            return this.UserId.GetHashCode();
        }
    }
}

