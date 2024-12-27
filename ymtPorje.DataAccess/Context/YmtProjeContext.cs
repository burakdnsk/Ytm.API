﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ymtProje1.Entity.Entities;

namespace ymtPorje.DataAccess.Context
{
    

    public class YmtProjeContext : DbContext
    {
        public YmtProjeContext(DbContextOptions<YmtProjeContext> options) : base(options)
        {
        }


        public DbSet<About> Abouts { get; set; }
        

        public DbSet<Banner> Banners { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogCategory> BlogsCategories { get; set; }

        public DbSet<Contact> Contacts { get; set; }


        public DbSet<Course> Courses { get; set; }


        public DbSet<CourseCategory> CourseCategories { get; set; }


        public DbSet<Message> Messages { get; set; }


        public DbSet<SocialMedia> SocialMedias { get; set; }


        public DbSet<Subscriber> Subscribers { get; set; }


        public DbSet<Testimonial> Testimonials { get; set; }


        


    }
}
