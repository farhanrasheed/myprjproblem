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
        public int EMPId { get; set; }
        public double? EMP_NO { get; set; }
        public string NAME { get; set; }
       
        public string SEX { get; set; }
        public string MARITAL_ST { get; set; }
        public DateTime DT_OF_BRTH { get; set; }
       
        public int? STOP_ID { get; set; }
        public string REASON { get; set; }

        public int RANKId { get; set; }

        public Rank Rank { get; set; }

        public int DEPId { get; set; }

        public PYDEPT PYDEPTs { get; set; }
        public int NATId { get; set; }

        public NATIONALITY NATIONALITYs { get; set; }
        public int SECId { get; set; }

        public SECTION SECTIONs { get; set; }

        public int ALWId { get; set; }

        public PYALW PYALWs { get; set; }



        public int SCHId { get; set; }

        public SCH_CODE SCH_CODEs { get; set; }

        public int SCMId { get; set; }

        public PYSCM PYSCM { get; set; }

        public int SALCHANGEId { get; set; }

        public SALARY_CHANGE SALARY_CHANGE { get; set; }

    }
}
