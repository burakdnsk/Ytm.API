using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ymtProje1.Entity.Entities
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public int CourseCategoryId { get; set; }

        public string ImageUrl { get; set; }

        public CourseCategory category { get; set; }

        public decimal price { get; set; }

        public bool isShown { get; set; }

        public List<Course> Courses { get; set; }

       
    }
}
