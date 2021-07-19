using Employeeprj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeprj.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MYPRJContext db;
        public EmployeeController(MYPRJContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var EmployeeList = db.PYEmployee.ToList();
            ViewBag.RankList = new SelectList(db.Rank, "RANKId", "RNK_CODE").ToList();

            return View(EmployeeList);
        }

        public IActionResult GetRankName(int Id)
        {
            var RankName = db.Rank.Where(x=>x.RNK_CODE == Id).Select(x=>x.RNK_DESC).FirstOrDefault();
            return Json(RankName);
        }
    }
}
