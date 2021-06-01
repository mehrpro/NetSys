using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net.Entities.Entity
{
    /// <summary>
    /// درخواست تعمیر
    /// </summary>
    public class RequestRepair : BaseClass<long>
    {
        public RequestRepair()
        {
            ID = new long();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;

        }

        /// <summary>
        /// دستگاه
        /// </summary>
        [Required]
        public int MachineryID_FK { get; set; }
        [ForeignKey("MachineryID_FK")]
        public Machinery Machinery { get; set; }

        /// <summary>
        /// کاربر
        /// </summary>
        [Required]
        public int UserID_FK { get; set; }
        [ForeignKey("UserID_FK")]
        public ApplicationUser ApplicationUser { get; set; }



        [Required]
        public DateTime RequestDataTime { get; set; }

        /// <summary>
        /// نوع درخواست
        /// </summary>
        [Required]
        public int TypeofRepairID_FK { get; set; }
        [ForeignKey("TypeofRepairID_FK")]
        public TypeofRepair TypeofRepair { get; set; }



        /// <summary>
        /// واحد درخواست کننده
        /// </summary>
        [Required]
        public int ApplicantID_FK { get; set; }
        [ForeignKey("ApplicantID_FK")]
        public Applicant Applicant { get; set; }



        [Required]
        [MaxLength(500)]
        public string RequestTitle { get; set; }



    


    }
}