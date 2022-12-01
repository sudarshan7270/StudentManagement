using Microsoft.AspNetCore.Mvc.Rendering;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;




namespace StudentManagement.ViewModel
{
    public class StudentMasterViewModel
    {
        [Display(Name = "Roll Number")]
        public string? RollNumber { get; set; }

        [Display(Name = "Student Name")]

        public string Name { get; set; }

        [Display(Name = "Class Name")]

        public string Class{ get; set;}





        [Display(Name = "Exam")]
        public int ExamId { get; set; }
        [Display(Name = "ListOfExam")]

        public int SubjectId { get; set; }

        public IEnumerable<SelectListItem>? ListofExams { get; set; }
        public IEnumerable<SelectListItem>? ListofSubject { get; set; }

        public int TotalMarks { get; set; }


        public decimal MarksObtained { get; set; }

        public decimal percentage { get; set; }



         
    }
}
