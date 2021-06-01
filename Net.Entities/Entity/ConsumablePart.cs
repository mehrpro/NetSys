using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net.Entities.Entity
{
    /// <summary>
    /// قعطعات مصرفی درخواست تعمیرات
    /// </summary>
    public  class ConsumablePart 
    {
        [Key]
        public long ID { get; set; }



        [Required]
        public int RequestID_FK { get; set; }
        [ForeignKey("RequestID_FK")]
        public RequestRepair RequestRepair { get; set; }







    }
}
