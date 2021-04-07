//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using DOLPHIN.Models;
//using DOLPHIN.Model;

//namespace DOLPHIN.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly ILogger<HomeController> _logger;
//        private readonly ApplicationDBContext _context;
//        public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
//        {
//            _logger = logger;
//            _context = context;
//        }

//        public IActionResult Index()
//        {
//            var listProductHot = _context.Products.Take(6).ToList();
//            return View(listProductHot);
//        }

//        public IActionResult Details(Guid id)
//        {
//            var product = _context.Products.Where(x => x.Id == id).FirstOrDefault();
//            return View(product);
//        }
//        public IActionResult Shop(string keyword)
//        {
//            var results = _context.Products.Where(p => string.IsNullOrEmpty(p.ProductName) == false &&
//                                                    p.ProductName.ToLower().Contains(keyword))
//                                                    .ToList();
//            return View(results);
//        }
//        public IActionResult Contact()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}
