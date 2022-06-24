using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ViewModelDemo.Models;
using ViewModelDemo.Services;

namespace ViewModelDemo.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {
            StudentViewModel model = new StudentViewModel();
            model.Student= StudentServices.GetAllStudent();
            model.Messages = MessageServices.GetAllMessages();
            return View(model);
        }
    }
}
