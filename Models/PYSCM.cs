using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class PYSCM
    {
        [Key]
        public int SCMId { get; set; }
        public double? SCM_CODE { get; set; }
        public string DESC { get; set; }
        public int SCHId { get; set; }

        public SCH_CODE SCH_CODE { get; set; }


    
    }
}
