using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Entities.Entity
{
 public   class Machinery : BaseClass<int>
    {
        public Machinery()
        {
            ID = new int();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;

        }

        public int MachineryCode { get; set; }
        public string MachineryTitle { get; set; }
        public string Description { get; set; }

    }
}
