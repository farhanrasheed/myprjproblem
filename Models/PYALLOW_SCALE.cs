using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class PYALLOW_SCALE
    {
        [Key]
        public int ALLOWSCHId { get; set; }
        public double? ALW_CODE { get; set; }
        public string ALW_TYPE { get; set; }
        public decimal AMOUNT { get; set; }
        public int? STOP_ID { get; set; }


        public int? RANKId { get; set; }
        [ForeignKey(nameof(RANKId))]
        public Rank Rank { get; set; }

    }
}
