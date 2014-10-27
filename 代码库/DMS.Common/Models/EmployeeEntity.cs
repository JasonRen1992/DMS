using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DMS.Common.Utils;

namespace DMS.Common.Models
{
    public class EmployeeEntity
    {
        
        [Display(Name = "Emp_Id")]
        public string Emp_Id { get; set; }

        [Display(Name = "Emp_Code")]
        public string Emp_Code { get; set; }

        [Display(Name = "Emp_Name")]
        public string Emp_Name { get; set; }

        [Display(Name = "Emp_Account")]
        public string Emp_Account { get; set; }

        [Display(Name = "Emp_PWD")]
        public string Emp_PWD { get; set; }

        [Display(Name = "Emp_LangCode")]
        public string Emp_LangCode { get; set; }

        [MaxWordsExpression(200)]
        [Display(Name = "Emp_Email")]
        public string Emp_Email { get; set; }

        [MaxWordsExpression(100)]
        [Display(Name = "Emp_Telephone")]
        public string Emp_Telephone { get; set; }

        [MaxWordsExpression(64)]
        [Display(Name = "Emp_Sex")]
        public string Emp_Sex { get; set; }

        [MaxWordsExpression(64)]
        [Display(Name = "Emp_Status")]
        public string Emp_Status { get; set; }

        [Display(Name = "IsEnable")]
        public bool IsEnable { get; set; }

    }
}
