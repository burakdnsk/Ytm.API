﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ymtProje1.Entity.Entities;

namespace ymtProje.DTO.DTOs.CourseCategoryDtos
{
    public class ResultCourseCategoryDto
    {
        public int CourseCategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Icon { get; set; }

        public string Description { get; set; }

        public bool IsShown { get; set; }

        public List<Course> Courses { get; set; }
    }
}
