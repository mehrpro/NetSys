using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Net.Entities.Entity
{
    public class TypeofRepair 
    {
        public TypeofRepair()
        {
            RequestRepairs = new HashSet<RequestRepair>();
        }

        [Key]
        public byte ID { get; set; }
        [Required]
        [MaxLength(150)]
        public string TypeTitle { get; set; }


        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
    }
}
