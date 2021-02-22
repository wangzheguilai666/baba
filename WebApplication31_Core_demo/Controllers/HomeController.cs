using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IBLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebApplication31_Core_demo.Models;

namespace WebApplication31_Core_demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //IConfiguration _Configuration;

        //构造函数注入
        //1.写接口
        IStudent _IStudent;
        //2,写构造函数.参数为学生接口
        public HomeController(ILogger<HomeController> logger, IStudent iStudent)
        {
            _logger = logger;
            _IStudent = iStudent;
        }

        public IActionResult Index()
        {
            //var strconn = _Configuration.GetConnectionString("DefaultConnection") ;

            var list = _IStudent.GetStudents();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
