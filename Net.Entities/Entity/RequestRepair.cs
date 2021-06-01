using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net.Entities.Entity
{
    public class RequestRepair : BaseClass<long>
    {
        public RequestRepair()
        {
            ID = new long();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;

        }

        [Required]
        public int MachineryID_FK { get; set; }
        [ForeignKey("MachineryID_FK")]
        public Machinery Machinery { get; set; }


        [Required]
        public int UserID_FK { get; set; }
        [ForeignKey("UserID_FK")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public DateTime RequestDataTime { get; set; }



        [Required]
        public int TypeofRepairID_FK { get; set; }
        [ForeignKey("TypeofRepairID_FK")]
        public TypeofRepair TypeofRepair { get; set; }



        [Required]
        public int ApplicantID_FK { get; set; }
        [ForeignKey("ApplicantID_FK")]
        public Applicant Applicant { get; set; }



        [Required]
        [MaxLength(500)]
        public string RequestTitle { get; set; }

    }
}