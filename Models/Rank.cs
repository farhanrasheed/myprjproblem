using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class Rank
    {
        [Key]
        public int RANKId { get; set; }
        public double? RNK_CODE { get; set; }
        public string RNK_DESC { get; set; }


        public int EMPId { get; set; }
        public virtual PYEmployee PYEmployee { get; set; }
    }
}
