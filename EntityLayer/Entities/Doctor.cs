using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Doctor
    {
        [Key]
        public int  Id { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string section { get; set; }
        public string ozet { get; set; }
        public string educations { get; set; }
        public string facebookUrl { get; set; }
        public string twitterUrl { get; set;}
        public string linkedinUrl { get; set;}
    }
}
