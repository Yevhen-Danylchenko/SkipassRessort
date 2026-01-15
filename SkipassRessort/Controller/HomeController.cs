using Microsoft.AspNetCore.Mvc;
using SkipassRessort.Model;
using SkipassRessort.ViewModel;
using System.Globalization;

namespace SkipassRessort.Controllers
{
    public class HomeController : Controller
    {
        private List<SkipassViewModel> GetSkipassList()
        {
            return new List<SkipassViewModel>
            {
                new SkipassViewModel
                {
                    ResortName = "Bukovel",
                    Description = "Найбільший гірськолижний курорт України",
                    Price = 1200,
                    Duration = "3 дні",
                    ImageUrl = "/images/1.webp"
                },
                new SkipassViewModel
                {
                    ResortName = "Dragobrat",
                    Description = "Високогірний курорт для досвідчених лижників",
                    Price = 900,
                    Duration = "2 дні",
                    ImageUrl = "/images/2.jpeg"
                },
                new SkipassViewModel
                {
                    ResortName = "Slavske",
                    Description = "Популярний курорт у Львівській області",
                    Price = 800,
                    Duration = "2 дні",
                    ImageUrl = "/images/3.jpeg"
                },
                new SkipassViewModel
                {
                    ResortName = "Pylypets",
                    Description = "Курорт із мальовничими краєвидами Закарпаття",
                    Price = 700,
                    Duration = "1 день",
                    ImageUrl = "/images/4.jpg"
                },
                new SkipassViewModel
                {
                    ResortName = "Trostyan",
                    Description = "Відомий гірськолижний центр біля Славського",
                    Price = 850,
                    Duration = "2 дні",
                    ImageUrl = "/images/5.webp"
                },
                new SkipassViewModel
                {
                    ResortName = "Izki",
                    Description = "Еко-курорт із сучасною інфраструктурою",
                    Price = 950,
                    Duration = "3 дні",
                    ImageUrl = "/images/6.jpg"
                },
                new SkipassViewModel
                {
                    ResortName = "Plai",
                    Description = "Сучасний курорт із зручним підйомником",
                    Price = 780,
                    Duration = "2 дні",
                    ImageUrl = "/images/7.jpg"
                },
                new SkipassViewModel
                {
                    ResortName = "Krasia",
                    Description = "Найдовший спуск в Україні, ідеальний для досвідчених лижників",
                    Price = 1000,
                    Duration = "3 дні",
                    ImageUrl = "/images/8.jpg"
                }
            };
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = GetSkipassList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string ResortName, decimal Price, string Duration)
        {
            TempData["ResortName"] = ResortName;
            TempData["Price"] = Price.ToString(CultureInfo.InvariantCulture);
            TempData["Duration"] = Duration;
            return RedirectToAction("Buy");
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult About(string name, string email, string message)
        {
            // например, перенаправляем на Message
            return RedirectToAction("Message", new { name, email, message });
        }

        [HttpGet]
        public IActionResult Skipass()
        {
            var model = GetSkipassList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Skipass (string ResortName, decimal Price, string Duration)
        {
            TempData["ResortName"] = ResortName;
            TempData["Price"] = Price.ToString(CultureInfo.InvariantCulture);
            TempData["Duration"] = Duration;
            return RedirectToAction("Buy");
        }

        [HttpGet]
        public IActionResult Buy()
        {
            ViewBag.ResortName = TempData["ResortName"];
            ViewBag.Price = decimal.Parse((string)TempData["Price"], CultureInfo.InvariantCulture);
            ViewBag.Duration = TempData["Duration"];
            return View();
        }


        //[HttpPost]
        //public IActionResult Buy(string ResortName, decimal Price, string Duration)
        //{
        //    ViewBag.ResortName = ResortName;
        //    ViewBag.Price = Price;
        //    ViewBag.Duration = Duration;

        //    return View();
        //}


        [HttpGet]
        public IActionResult Message(string name, string email, string message)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Message = message;
            return View();
        }
    }
}
