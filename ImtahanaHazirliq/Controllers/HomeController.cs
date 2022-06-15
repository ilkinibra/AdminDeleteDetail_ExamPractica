using ImtahanaHazirliq.DAL;
using ImtahanaHazirliq.Models;
using ImtahanaHazirliq.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ImtahanaHazirliq.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM=new HomeVM();
            homeVM.sliders= _context.Sliders.ToList();
            homeVM.pageIntro= _context.PageIntros.FirstOrDefault();
            homeVM.noticeBoard = _context.NoticeBoards.ToList();
            homeVM.noticeBoardRights=_context.NoticeBoardRights.ToList();
            homeVM.course = _context.Courses.ToList();
            homeVM.events=_context.Events.ToList();
            homeVM.blogs = _context.Blogs.ToList();
            return View(homeVM);
        }
    }
}
