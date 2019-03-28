using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Course
    {
        public int id { get; set; }
        public ApplicationUser Lecturer { get; set; }

    }
}