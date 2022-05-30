using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _20220530.Models
{
    public class Student: IBaseData
    {
        /// <summary>
        /// 學號
        /// </summary>
        [Key]
        [Display(Name = "學號")]
        public string studentNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Required(ErrorMessage = "姓名不可空白")]
        [Display(Name = "學生姓名")]
        public string studentName { get; set; }

        /// <summary>
        /// Github連結
        /// </summary>
        [MinLength(10, ErrorMessage = "長度不可小於10")]
        [Display(Name = "GitHub連結")]
        public string githubLink { get; set; }

        public bool isDelete { get; set; }
        
        public DateTime creDateTime { get; set; }

        public DateTime updateDateTime { get; set; }

        public Student(string studentNo, string studentName, string githubLink)
        {
            this.studentNo = studentNo;
            this.studentName = studentName;
            this.githubLink = githubLink;
        }

        public Student()
        {

        }
    }
}
