using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Models
{
    public class MYPRJContext : DbContext
    {
        public MYPRJContext(DbContextOptions<MYPRJContext> options) : base(options)
        {

        }
        public DbSet<PYEmployee> PYEmployee { get; set; }
        public DbSet<PYALW> PYALWs { get; set; }
        public DbSet<PYDEPT> PYDEPT { get; set; }
        public DbSet<SECTION> SECTION { get; set; }
        public DbSet<Rank> Rank { get; set; }
        public DbSet<NATIONALITY> NATIONALITY { get; set; }
        public DbSet<PYSCM> PYSCM { get; set; }
        public DbSet<SCH_CODE> SCH_CODE { get; set; }
        public DbSet<SALARY_CHANGE> SALARY_CHANGE { get; set; }

    }
}
