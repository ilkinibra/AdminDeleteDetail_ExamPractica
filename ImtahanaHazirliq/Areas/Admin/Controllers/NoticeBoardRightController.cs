using ImtahanaHazirliq.DAL;
using ImtahanaHazirliq.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImtahanaHazirliq.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NoticeBoardRightController : Controller
    {
        private AppDbContext _context;
        public NoticeBoardRightController(AppDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            List<NoticeBoardRight> noticeBoardRights = _context.NoticeBoardRights.ToList();
            return View(noticeBoardRights);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null) return NotFound();
            NoticeBoardRight dbNoticeBoardRight = await _context.NoticeBoardRights.FindAsync(id);
            if(dbNoticeBoardRight == null) return NotFound();
            return View(dbNoticeBoardRight);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            NoticeBoardRight dbNoticeBoardRight = await _context.NoticeBoardRights.FindAsync(id);
            if (dbNoticeBoardRight == null) return NotFound();
            _context.NoticeBoardRights.Remove(dbNoticeBoardRight);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
