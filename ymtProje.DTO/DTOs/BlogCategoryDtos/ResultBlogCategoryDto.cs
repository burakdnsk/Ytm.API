﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ymtProje.DTO.DTOs.BlogDtos;
using ymtProje1.Entity.Entities;

namespace ymtProje.DTO.DTOs.BlogCategoryDtos
{
    public class ResultBlogCategoryDto
    {
        public int BlogCategoryId { get; set; }

        public string Name { get; set; }

        public List<ResultBlogDto> Blogs { get; set; }
    }
}
