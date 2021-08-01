using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class PYDEPT
    {
        [Key]
        public int DEPId { get; set; }
        public double? DEP_CODE { get; set; }
        public string DESCRIPTION { get; set; }

        public int SECId { get; set; }

        [ForeignKey(nameof(SECId))]
        public SECTION SECTION { get; set; }
        

 

    }
}
 