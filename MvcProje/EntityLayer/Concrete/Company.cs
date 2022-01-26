using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Company
    {
        [Key]
        public int CompanyID { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(100)]
        public string CompanyImage { get; set; }

        [StringLength(250)]
        public string CompanyAbout { get; set; }

        [StringLength(50)]

        public string CompanyTitle { get; set; }

        [StringLength(100)]

        public string AboutShort { get; set; }

        [StringLength(50)]

        public string Mail { get; set; }

        [StringLength(50)]

        public string Password { get; set; }

        [StringLength(20)]

        public string PhoneNumber { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
