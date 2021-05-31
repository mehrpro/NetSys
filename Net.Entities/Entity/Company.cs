using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Entities.Entity
{
  public  class Company : BaseClass<int>
    {
        public Company()
        {
            ID = new int();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;

            this.Companies = new HashSet<Company>();
            this.Groups = new HashSet<Group>();
            this.Codings = new HashSet<Coding>();

        }


        [Required]
        public byte CompnayIndex { get; set; }
        [Required]
        [MaxLength(150)]
        public string CompanyTiltle { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }



        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Coding> Codings { get; set; }
    }
}
