using NVH_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NVH_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpCommingCourses { get; set; }   
        public bool ShowAction { get; set; }
    }
}