using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Entities.Entity
{
  public  class Applicant: BaseClass<int>
    {
        public Applicant()
        {
            ID = new int();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;

            RequestRepairs = new HashSet<RequestRepair>();

        }

        [Required]
        [MaxLength(150)]
        public string ApplicantTitle { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }


        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }




    }
}
