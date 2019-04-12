﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetCw.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        [Required(ErrorMessage = "Please enter your subject name")]
        public string Name { get; set; }
    }
}