using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class NATIONALITY
    {
        [Key]
        public int NATId { get; set; }
        public double? NAT_CODE { get; set; }
        public string DESC { get; set; }



    }
}
