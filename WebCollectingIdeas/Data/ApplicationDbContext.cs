﻿using Microsoft.EntityFrameworkCore;
using WebCollectingIdeas.Models;

namespace WebCollectingIdeas.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
