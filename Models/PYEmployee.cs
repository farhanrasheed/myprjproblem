using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class PYEmployee
    {
        [Key] 
        public int EmpId { get; set; }
        public double? EMP_NO { get; set; }
        public string NAME { get; set; }
        public double? RNK_CODE { get; set; }
        public string SEX { get; set; }
        public string MARITAL_ST { get; set; }
        public DateTime DT_OF_BRTH { get; set; }
        public int? STOP_ID { get; set; }
        public double? NAT_CODE { get; set; }
        public double? DEP_CODE { get; set; }
        public double? SEC_CODE { get; set; }
    
        public string REASON { get; set; }
       


    }
}
