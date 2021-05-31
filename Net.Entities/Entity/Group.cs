using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Entities.Entity
{
   public class Group : BaseClass<int>
    {
        public Group()
        {
            ID = new int();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;

            this.SubGroups = new HashSet<SubGroup>();
            this.Codings = new HashSet<Coding>();
        }

        [Required]
        public int CompanyID_FK { get; set; }
        [ForeignKey("CompanyID_FK")]
        public Company Company { get; set; }


        [Required]        
        public byte GroupIndex { get; set; }

        [Required]
        [MaxLength(150)]
        public string GroupTitle { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }



        public virtual ICollection<SubGroup> SubGroups { get; set; }
        public virtual ICollection<Coding> Codings { get; set; }
    }
}
