using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalEmployee.Models
{
    public class EmployeeSearchArg
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string TitleId { get; set; }
        public string HireDateFrom { get; set; }
        public string HireDateTo { get; set; }
        public string DeleteEmployeeID { get; set; }
    }
}