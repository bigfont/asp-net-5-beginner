using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using App08TagHelpers.ViewModels;

namespace App08TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult TagHelpers() => View();

        public IActionResult HtmlHelpers() => View();

        public IActionResult CustomTagHelper(IndexViewModel indexVm) => View(indexVm);

        public IActionResult Error() => View();
    }
}
