using Microsoft.AspNetCore.Mvc;
using Repository;
using Services;
using System.Diagnostics;
using WebApplicationMvc.Models;
using Domain;
using System.Threading.Tasks;

namespace WebApplicationMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var userService = new UserServices(_unitOfWork);
            //var result = userService.Authenticate("retroglider", "password");

            //var user = new User() { FirstName = "Carsten", LastName = "Kampe", SystemId="ck", Password="kampe", Email="2cool4u@gmail.com" };
            //userService.Add(user);
            return View();
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
