using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace studentManagementSystems.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}