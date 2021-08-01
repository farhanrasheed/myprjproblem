using Employeeprj.Models;
using Employeeprj.ViewModels;
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
            var RankList = (from c in db.Rank
                            select new SelectListItem
                            {
                                Text = c.RNK_CODE + "      " + c.RNK_DESC,
                                Value = c.RANKId.ToString()
                            }).ToList();
            ViewBag.RankList = RankList;
                //new SelectList(db.Rank, "RANKId", "RNK_CODE").ToList();

            ViewBag.NationalityList = new SelectList(db.NATIONALITY, "NATId", "NAT_CODE").ToList();
            ViewBag.DepartmentList = new SelectList(db.PYDEPT, "DEPId", "DEP_CODE").ToList();
            var PYAmount = (from s in db.SCH_CODE
                            join p in db.PYSCM
                            on s.SCHId equals p.SCHId
                            select new PYCode_Amount
                            {
                                PYCode = p.SCM_CODE,
                                Basic = s.BASIC,
                                SCHId = p.SCHId
                            }).ToList();
            ViewBag.PYAmount = new SelectList(PYAmount, "SCHId", "PYCode").ToList();

            return View(EmployeeList);
        }

        public IActionResult GetRankName(int Id)
        {

            var RankName = db.Rank.Where(x=>x.RNK_CODE == Id).ToList();
            return Json(RankName);
        }

        public IActionResult GetNationalityName(int Id)
        {
            var NationalityName = db.NATIONALITY.Where(x => x.NAT_CODE == Id).Select(x => x.DESCRIPTION).FirstOrDefault();
            return Json(NationalityName);
        }
        public IActionResult GetDepartmentName(int Id)
        {
            var DepartmentName = db.PYDEPT.Where(x => x.DEP_CODE == Id).Select(x => x.DESCRIPTION).FirstOrDefault();
            return Json(DepartmentName);
        }

        public IActionResult PayScaleAmount(double? Id)
        {
            var SchId = db.PYSCM.Where(x=> x.SCM_CODE == Id).Select(x=>x.SCHId).FirstOrDefault();
            var Amount = db.SCH_CODE.Where(x => x.SCHId == SchId).Select(x => x.BASIC).FirstOrDefault();
            return Json(Amount);
        }
        public IActionResult SectionName(PYDEPT Pydep)
        {
            // var SectionId = db.PYDEPT.Where(x => x.DEP_CODE == Pydep.DEP_CODE).FirstOrDefault();
            var SectionName = "";
            var SecCode = db.PYDEPT.Where(x => x.DEP_CODE == Pydep.DEP_CODE).Select(x => x.SECId).FirstOrDefault();
            var SectionList = db.SECTION.Where(x => x.SEC_CODE == SecCode).ToList();
            foreach(var item in SectionList)
            {
                if(item.SEC_CODE == Pydep.SECId)
                {
                    SectionName = db.SECTION.Where(x => x.SEC_CODE == Pydep.SECId).Select(x => x.DESCRIPTION).FirstOrDefault();
                }
                else
                {
                    break;
                }
            }            
            return Json(SectionName);
        }



        [HttpPost]
        public IActionResult Create(PYEmployee emp)
        {
            db.PYEmployee.Add(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult AddorUpdate(int? Id)
        {
            var data = db.PYEmployee.Find(Id);
            return Json(data);
        }
        [HttpPost]
        public IActionResult AddorUpdate(PYEmployee obj)
        {
            if (obj.EmpId == 0)
            {
                db.PYEmployee.Add(obj);
                db.SaveChanges();
            }
            else
            {
                var data = db.PYEmployee.Find(obj.EmpId);
                data.EMP_NO = obj.EMP_NO;
                data.NAME = obj.NAME;
                data.RNK_CODE = obj.RNK_CODE;
                data.SEX = obj.SEX;
                data.MARITAL_ST = obj.MARITAL_ST;
                data.DT_OF_BRTH = obj.DT_OF_BRTH;
                data.STOP_ID = obj.STOP_ID;
                data.NAT_CODE = obj.NAT_CODE;
                data.DEP_CODE = obj.DEP_CODE;
                data.SEC_CODE = obj.SEC_CODE;
                data.REASON = obj.REASON;
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? Id)
        {
            var data = db.PYEmployee.Find(Id);
            db.PYEmployee.Remove(data);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
