using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Net.Entities.Entity
{
    /// <summary>
    /// واحد درخواست کننده
    /// </summary>
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
