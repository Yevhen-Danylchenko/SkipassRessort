using SkipassRessort.Model;
using SkipassRessort.ViewModel;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Index()
        {
            var model = GetSkipassList();
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Skipass()
        {
            var model = GetSkipassList();
            return View(model);
        }
    }
}
