using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCw.Models
{
    public class Event
    {
        public int EventID { get; set; }
        [Required(ErrorMessage = "Please enter the name of event")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the description of the event ")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter the date of the event")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please select a Subject, if left blank, please create a new Subject")]
        public string SubjectName { get; set; }
    }
}