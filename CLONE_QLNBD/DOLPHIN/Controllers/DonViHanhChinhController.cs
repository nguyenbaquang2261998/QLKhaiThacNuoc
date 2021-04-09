using DOLPHIN.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Controllers
{
    public class DonViHanhChinhController : Controller
    {
        private readonly ILogger<DonViHanhChinhController> _logger;
        private readonly ApplicationDBContext _context;
        public DonViHanhChinhController(ILogger<DonViHanhChinhController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var donViHanhChinh = this._context.DonViHanhChinh.ToList();
            return View(donViHanhChinh);
        }
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DonViHanhChinh requestData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requestData);
                await _context.SaveChangesAsync();
                return Redirect("/DonViHanhChinh/Index");
            }
            return View(requestData);
        }
    }
}
