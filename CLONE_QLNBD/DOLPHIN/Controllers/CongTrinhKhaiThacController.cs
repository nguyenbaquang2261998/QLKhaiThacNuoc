using DOLPHIN.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            var congTrinh = this._context.CongTrinhKhaiThac
                .Include(x => x.ToTrinh)
                .Include(cb => cb.CanBo)
                .ToList();
            return View();
        }
        public IActionResult Create()
        {
            var canBos = this._context.CanBo.ToList();
            ViewBag.DMCanBo = new SelectList(canBos, "Id", "TenCanBo", null);

            var giayPheps = this._context.ToTrinh.ToList();
            ViewBag.DMGiayPhep = new SelectList(giayPheps, "Id", "Id", null);

            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CongTrinhKhaiThac requestData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requestData);
                await _context.SaveChangesAsync();
                return Redirect("/CongTrinhKhaiThac/Index");
            }
            return View(requestData);
        }

        // GET: Admin/Categories/Edit/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id > 0)
            {
                var toTrinh = this._context.ToTrinh.Where(x => x.Id == id).FirstOrDefault();
                // Status : Da duyet.
                toTrinh.TrangThai = 1;
                _context.Update(toTrinh);
                await _context.SaveChangesAsync();
                return Redirect("/ToTrinh/Index");
            }
            return View();
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ToTrinh requestData)
        {
            if (id != requestData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requestData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToTrinhExists(requestData.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(requestData);
        }

        // GET: Admin/Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var og = await _context.ToTrinh
                .FirstOrDefaultAsync(m => m.Id == id);
            if (og == null)
            {
                return NotFound();
            }

            return View(og);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var og = await _context.ToTrinh.FindAsync(id);
            _context.ToTrinh.Remove(og);
            await _context.SaveChangesAsync();
            return Redirect("/ToTrinh/Index");
        }

        private bool ToTrinhExists(int id)
        {
            return _context.ToTrinh.Any(e => e.Id == id);
        }
    }
}
