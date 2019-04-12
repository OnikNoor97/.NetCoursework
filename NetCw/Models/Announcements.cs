using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetCw.Models
{
    public class Announcements
    {
        public int AnnouncementsID { get; set; }
        [Required(ErrorMessage = "Please enter the title of the announcement")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the Message of the announcement")]
        public string Message { get; set; }
    }
}