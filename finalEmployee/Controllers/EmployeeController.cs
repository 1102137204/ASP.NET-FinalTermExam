using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using finalEmployee.Models;

namespace finalEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        Models.CodeService codeService = new Models.CodeService();
        private Models.Employee order;

        /// <summary>
        /// 員工管理首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.EmpCodeData = this.codeService.GetEmp();
            return View();
        }
    }
}