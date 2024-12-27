using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ymtProje.DTO.DTOs.BlogCategoryDtos;
using ymtProje1.Entity.Entities;

namespace ymtProje.DTO.DTOs.BlogDtos
{
    public class CreateBlogDto
    {
        

        public string Title { get; set; }

        public string Comment { get; set; }

        public string ImageUrl { get; set; }

        public DateTime BlogDate { get; set; }

        public int BlogCategorId { get; set; }

      
    }
}
