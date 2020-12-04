using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppStudentAssessment.Models;

namespace WebAppStudentAssessment.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Display()
        {

            List<Student> listStudent = new List<Student>
            { 
            new Student{SId=1,SName="Raj",SDob=new DateTime(day:10,month:12,year:2012),SContact="9012345678"},
            new Student{SId=2,SName="Aman",SDob=new DateTime(day:11,month:12,year:2012),SContact="9012345672"},
            new Student{SId=3,SName="Ajay",SDob=new DateTime(day:12,month:12,year:2012),SContact="9012345673"},
            new Student{SId=4,SName="Vicky",SDob=new DateTime(day:13,month:12,year:2012),SContact="9012345674"},
            new Student{SId=5,SName="Sourabh",SDob=new DateTime(day:14,month:12,year:2012),SContact="9012345675"}
            };
            int x = listStudent.Count();
            ViewBag.Total = x;
            return View(listStudent);
        }
    }
}
