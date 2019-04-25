using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DockerLearn.Models;
using DockerLearn.Context;

namespace DockerLearn.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Articles()
        {
            var model = new ArticlesViewModel();
            model.Articles = new ArticleRepository().GetLatest();

            return View(model);
        }
    }
}
