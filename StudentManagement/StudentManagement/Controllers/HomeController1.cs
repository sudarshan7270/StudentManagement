using Microsoft.AspNetCore.Mvc;
using StudentManagement.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentManagement.Controllers
{
    public class HomeController1 : Controller
    {
        StudentDBEntities objStudentDBEntities;
        public HomeController1()
        {
            objStudentDBEntities = new StudentDBEntities();

        }
        
        public IActionResult Index()
        {

            StudentMasterViewModel objMasterViewModel = new StudentMasterViewModel();
            objMasterViewModel.ListofExams = (from obj in objStudentDBEntities.Exams
                                              select new SelectListItem()
                                              {
                                                  Text = obj.ExamName,
                                                  Value = obj.ExamId.ToString()
                                              }).ToList();
            objMasterViewModel.ListofExams = (from obj in objStudentDBEntities.Subjects
                                              select new SelectListItem()
                                              {
                                                  Text = obj.SubjectName,
                                                  Value = obj.SubjectId.ToString()
                                              }).ToList();

            return View(objMasterViewModel);
        }
    }
}
