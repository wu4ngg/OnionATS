using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Data
{
    public class Profile : BaseEntity
    {
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual User User { get; set; }
    }
}
