using ImtahanaHazirliq.Models;
using Microsoft.EntityFrameworkCore;

namespace ImtahanaHazirliq.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<PageIntro> PageIntros { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<NoticeBoardRight> NoticeBoardRights { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Event>Events { get; set; } 
        public DbSet<Blog>Blogs { get; set; }  
    }
}
