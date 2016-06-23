using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace finalEmployee.Models
{
    public class Employee
    {
        /*/// <summary>
        /// 建構式
        /// </summary>
        public Employee()
        {
            var ods = new List<Models.EmployeeDetails>();
            ods.Add(new EmployeeDetails() { ProductId = 58 });
            this.EmployeeDetails = ods;

        }*/


        /// <summary>
        /// 員工編號
        /// </summary>
        //
        [DisplayName("員工編號")]
        [Required()]
        public int EmployeeID { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        /// 
        [DisplayName("姓")]
        public string LastName { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        /// 
        [DisplayName("名")]
        public string FirstName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        /// 
        [DisplayName("姓名")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 職稱編號
        /// </summary>
        /// 
        [DisplayName("職稱編號")]
        public string Title { get; set; }

        /// <summary>
        /// 稱謂
        /// </summary>
        /// 
        [DisplayName("稱謂")]
        public string TitleOfCourtesy { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        /// 
        [DisplayName("生日")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// 任職日期
        /// </summary>
        /// 
        [DisplayName("任職日期")]
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        /// 
        [DisplayName("地址")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        /// 
        [DisplayName("城市")]
        public string City { get; set; }

        /// <summary>
        /// 地區
        /// </summary>
        [DisplayName("地區")]
        public string Region { get; set; }

        /// <summary>
        /// 國家
        /// </summary>
        /// 
        [DisplayName("國家")]
        public string Country { get; set; }

        /// <summary>
        /// 電話
        /// </summary>
        /// 
        [DisplayName("電話")]
        public string Phone { get; set; }

        /// <summary>
        /// 直屬主管編號
        /// </summary>
        /// 
        [DisplayName("直屬主管編號")]
        public int ManagerID { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        [DisplayName("性別")]
        public string Gender { get; set; }

        /// <summary>
        /// 月薪
        /// </summary>
        [DisplayName("月薪")]
        [Required()]
        public int MonthlyPayment { get; set; }

        /// <summary>
        /// 年薪
        /// </summary>
        [DisplayName("年薪")]
        [Required()]
        public int YearlyPayment { get; set; }

        /*// <summary>
        /// 訂單明細
        /// </summary>
        public List<OrderDetails> OrderDetails { get; set; }*/

    }
}