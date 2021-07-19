using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class PYALW
    {
        [Key]
        public int ALWId { get; set; }
        public double? EMP_NO { get; set; }
        public int? ALW_CODE { get; set; }
        public string  ALW_TYPE { get; set; }
        public decimal? AMOUNT { get; set; }
        public int? STOP_ID { get; set; }


        public int EMPId { get; set; }
        public virtual PYEmployee PYEmployee { get; set; }
    }
}
