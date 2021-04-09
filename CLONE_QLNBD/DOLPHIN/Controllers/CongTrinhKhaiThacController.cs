using DOLPHIN.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Controllers
{
    public class CongTrinhKhaiThacController : Controller
    {
        private readonly ILogger<CongTrinhKhaiThacController> _logger;
        private readonly ApplicationDBContext _context;
        public CongTrinhKhaiThacController(ILogger<CongTrinhKhaiThacController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var congTrinh = this._context.CongTrinhKhaiThac.ToList();
            return View(congTrinh);
        }
    }
}
