using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Entities.Entity
{
public    class BaseClass<T>
    {
        [Key]
        public T ID { get; set; }
        [Required]
        public System.DateTime Registered { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public bool IsDelete { get; set; }

    }
}
