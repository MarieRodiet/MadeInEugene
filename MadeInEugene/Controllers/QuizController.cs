using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadeInEugene.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MadeInEugene.Controllers
{
    public class QuizController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(QuizModel quiz)
        {
            quiz.CheckAnswers();
            return View(quiz);
        }
    }
}
