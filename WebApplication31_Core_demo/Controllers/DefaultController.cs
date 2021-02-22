using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModel;
using IBLL;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication31_Core_demo.Controllers
{
    public class DefaultController : Controller
    {
        //构造函数注入
        //1.写接口
        IStudent _IStudent;
        //2,写构造函数.参数为学生接口
        public DefaultController(IStudent iStudent)
        {
            _IStudent = iStudent;
        }

        //Books book = new Books();
        public IActionResult Index()
        {
            //调用接口的查询功能
            var list = _IStudent.GetStudents();
            return View(list);
        }
    }
}
