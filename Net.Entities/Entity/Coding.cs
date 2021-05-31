using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Entities.Entity
{
   public class Coding : BaseClass<long>
    {
        public Coding()
        {
            ID = new long();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;
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
        public int SubGroupID_FK { get; set; }
        [ForeignKey("SubGroupID_FK")]
        public SubGroup SubGroup { get; set; }



        [Required]
        public short CodeIndex { get; set; }

        [Required]        
        public int Code { get; set; }

        [Required]
        [MaxLength(150)]
        public string CodeTitle { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }


    }
}
