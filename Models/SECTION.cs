using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class SECTION
    {
        [Key]
        public int SECId { get; set; }
        public double? SEC_CODE { get; set; }
        public string DESC { get; set; }



    }
}
