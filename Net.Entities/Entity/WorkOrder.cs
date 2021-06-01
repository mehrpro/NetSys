using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net.Entities.Entity
{
    public  class WorkOrder : BaseClass<long>
    {
        public WorkOrder()
        {
            ID = new long();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;
        }

        [Required]
        public int RequestID_FK { get; set; }
        [ForeignKey("RequestID_FK")]
        public RequestRepair RequestRepair { get; set; }


        /// <summary>
        /// نوع کار برقی
        /// </summary>
        [Required]
        public bool Electrical { get; set; }

        /// <summary>
        /// نوع کار مکانیکی
        /// </summary>
        [Required]
        public bool Mecanical { get; set; }

        /// <summary>
        ///  نوع کار تاسیسات
        /// </summary>
        [Required]
        public bool Piping { get; set; }

        /// <summary>
        /// نوع کار ساخت
        /// </summary>
        [Required]
        public bool  Creating { get; set; }


        /// <summary>
        /// نوع کار تجهیز
        /// </summary>
        [Required]
        public bool Equip { get; set; }


        /// <summary>
        /// تعمیر خارج از شرکت
        /// </summary>
        [Required]
        public bool RepairOutside { get; set; }
        public int RepairOutSideReportID_FK { get; set; }



        [Required]
        public DateTime StartWorking { get; set; }

        /// <summary>
        /// فرسودگی 
        /// </summary>
        [Required]
        public bool Cause_Exhaustion { get; set; }
        /// <summary>
        ///  سهل انگاری اپراتور
        /// </summary>
        [Required]
        public bool Cause_OperatorNegligence { get; set; }

        /// <summary>
        /// عدم کیفیت قطعات یدکی
        /// </summary>
        [Required]
        public bool Cause_QualityofSpareParts { get; set; }

        /// <summary>
        /// سهل انگاری تعمیرکار 
        /// </summary>
        [Required]
        public bool Cause_RepairmanError { get; set; }

        /// <summary>
        ///  سایر
        /// </summary>
        [Required]
        public bool OtherError { get; set; }     
        [MaxLength(500)]
        public string OtherErrorDescription { get; set; }


        public string ReportRepair { get; set; }

        /// <summary>
        /// کمبود نفرساعت
        /// </summary>
        public bool PersonHours { get; set; }
        public short PersonHoursTime { get; set; }
        public string PersonHoursDescription { get; set; }




        /// <summary>
        /// برنامه ریزی تولید
        /// </summary>
        public bool ProductionPlanning { get; set; }
        public short ProductionPlanningTime { get; set; }
        public string ProductionPlanningDescription { get; set; }


        /// <summary>
        /// نبود قطعات یدکی
        /// </summary>
        public bool NoSpareParts { get; set; }
        public short NoSparePartsTime { get; set; }
        public string NoSparePartsDescription { get; set; }


        /// <summary>
        /// سایر
        /// </summary>
        public bool Other { get; set; }
        public short OtherTime { get; set; }
        public string OtherDescription { get; set; }


        /// <summary>
        /// اتمام کار
        /// </summary>
        public bool CloseRequest { get; set; }
        public DateTime DateTimeClosing { get; set; }







    }
}
