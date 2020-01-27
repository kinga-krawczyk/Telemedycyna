using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DaltoQuiz.Models;

namespace DaltoQuiz.Controllers
{
    public class QuizController : Controller
    {
       // [Route("Questions")]
       // private LogowanieContext log = new LogowanieContext();
       // na razie niepotrzebne
  
        public IActionResult Index()
        {
            
           // newdbEntities db = new newdbEntities;
            return View();
        }
    }
}