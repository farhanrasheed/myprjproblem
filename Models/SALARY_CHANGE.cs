using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class SALARY_CHANGE
    {
        [Key]
        public int SALCHANGEId { get; set; }
        public double? EMP_NO { get; set; }
        public String TRN_PERIOD { get; set; }
        public String TRN_DESC { get; set; }
        public double? OLD_BASIC { get; set; }
        public double? NEW_BASIC { get; set; }
        public DateTime TRN_DATE { get; set; }

        public int EMPId { get; set; }
        public virtual PYEmployee PYEmployee { get; set; }

    }
}
