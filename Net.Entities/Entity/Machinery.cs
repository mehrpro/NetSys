using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Entities.Entity
{

    /// <summary>
    /// لیست ماشین آلات
    /// </summary>
    public class Machinery : BaseClass<int>
    {
        public Machinery()
        {
            ID = new int();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;

            RequestRepairs = new HashSet<RequestRepair>();
        }

        [Required]
        public int CodeID_FK { get; set; }
        [ForeignKey("CodeID_FK")]
        public Coding Coding { get; set; }

        [Required]
        [MaxLength(200)]
        public string MachineryTitle { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }



        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }

    }
}
