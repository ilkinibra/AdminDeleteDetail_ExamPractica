using ImtahanaHazirliq.DAL;
using ImtahanaHazirliq.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImtahanaHazirliq.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NoticeBoardController : Controller
    {
        private AppDbContext _context;
        public NoticeBoardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<NoticeBoard> noticeBoards = _context.NoticeBoards.ToList();
            return View(noticeBoards);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null) return NotFound();
            NoticeBoard dbNoticeBoard =await  _context.NoticeBoards.FindAsync(id);
            if(dbNoticeBoard == null) return NotFound();
            return View(dbNoticeBoard);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            NoticeBoard dbNoticeBoard = await _context.NoticeBoards.FindAsync(id);
            if (dbNoticeBoard == null) return NotFound();
            _context.NoticeBoards.Remove(dbNoticeBoard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NoticeBoard noticeBoard)
        {
            if (!ModelState.IsValid)
			{
                return View();
			}

            NoticeBoard newNoticeBoard=new NoticeBoard();
            newNoticeBoard.DateTime = noticeBoard.DateTime;
            newNoticeBoard.Description= noticeBoard.Description;
           await _context.NoticeBoards.AddAsync(newNoticeBoard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult>Update(int? id)
        {
            if (id == null) return NotFound();
            NoticeBoard dbnoticeBoard = await _context.NoticeBoards.FindAsync(id);
            if(dbnoticeBoard == null) return NotFound();
            return View(dbnoticeBoard);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id,NoticeBoard noticeBoard)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            NoticeBoard dbnoticeBoard = await _context.NoticeBoards.FindAsync(id);
            if (dbnoticeBoard == null) return NotFound();
            dbnoticeBoard.DateTime = noticeBoard.DateTime;
            dbnoticeBoard.Description=noticeBoard.Description;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
