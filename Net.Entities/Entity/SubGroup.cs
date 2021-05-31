using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Entities.Entity
{
   public class SubGroup : BaseClass<int>
    {
        public SubGroup()
        {
            ID = new int();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;


            this.Codings = new HashSet<Coding>();
        }

        [Required]
        public int CompanyID_FK { get; set; }
        [ForeignKey("CompanyID_FK")]
        public Company Company { get; set; }

        [Required]
        public int GroupID_FK { get; set; }
        [ForeignKey("GroupID_FK")]
        public Group Group { get; set; }


        [Required]
        public byte SubGroupIndex { get; set; }

        [Required]
        [MaxLength(150)]
        public string SubGroupTitle { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }



        public virtual ICollection<Coding> Codings { get; set; }
    }
}
