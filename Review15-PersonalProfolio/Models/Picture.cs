using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Review15PersonalProfolio.Models
{
    [Table("Pictures")]
    public class Picture
    {
        [Key]
        public int PictureId { get; set; }
        public string Url { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string Location { get; set; }

        public Picture() { }

        public Picture(string url, string alt, string title = "Untitled", string caption ="No Caption", string location = "Unknown")
        {
            Url = url;
            Alt = alt;
            Title = title;
            Caption = caption;
            Location = location;
        }

       


        public override bool Equals(System.Object otherPicture)
        {
            if (!(otherPicture is Picture))
            {
                return false;
            }
            else
            {
                Picture newPicture = (Picture)otherPicture;
                return this.PictureId.Equals(newPicture.PictureId);
            }
        }

        public override int GetHashCode()
        {
            return this.PictureId.GetHashCode();
        }
    }
}
