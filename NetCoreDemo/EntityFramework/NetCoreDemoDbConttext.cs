using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using NetCoreDemo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDemo.EntityFramework
{
    public class NetCoreDemoDbConttext:DbContext
    {
        public NetCoreDemoDbConttext()
        {

        }

        public NetCoreDemoDbConttext(DbContextOptions<NetCoreDemoDbConttext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Achievement> Achievements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Achievement>().ToTable("Achievement");

            modelBuilder.Entity<Achievement>().HasOne(h => h.Student).WithMany(w => w.Achievements);
            modelBuilder.Entity<Achievement>().HasOne(h => h.Course).WithMany(w => w.Achievements);
            base.OnModelCreating(modelBuilder);
        }
    }
}
