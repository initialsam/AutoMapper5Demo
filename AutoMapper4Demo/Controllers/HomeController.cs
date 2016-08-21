using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoMapper4Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserViewModel>();
            });
            var mapper = config.CreateMapper();

            User sam = new User()
            {
                UserID = 1,
                Name = "sam"
            };

            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                UserViewModel model = mapper.Map<UserViewModel>(sam);
            }
            watch.Stop();
            ViewBag.Milliseconds = watch.ElapsedMilliseconds;
            return View();
        }
    }

    public class UserViewModel
    {
        public int UserID { get; set; }
        public string Name { get; set; }
    }

    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
    }
}