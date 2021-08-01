using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class SCH_CODE
    {
        [Key]
        public int SCHId { get; set; }
        public double? SECH_CODE { get; set; }
        public string STEP_CODE { get; set; }
        public string BASIC { get; set; }



       
    }
}
