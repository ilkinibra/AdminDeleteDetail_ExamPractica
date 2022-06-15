using ImtahanaHazirliq.Models;
using System.Collections;
using System.Collections.Generic;

namespace ImtahanaHazirliq.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider>sliders  { get; set; }
        public PageIntro pageIntro { get; set; }    
        public IEnumerable<NoticeBoard> noticeBoard { get; set; }
        public IEnumerable<NoticeBoardRight> noticeBoardRights { get; set; }
        public IEnumerable<Course> course { get; set; }
        public IEnumerable<Event> events { get; set; }
        public IEnumerable<Blog> blogs { get; set; }
    }
}
