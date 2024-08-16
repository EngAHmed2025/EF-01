using ConsoleApp1.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Context
{
    internal class ITIDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-5Q5HCPF;DataBase  = ITI;Trusted_Connection = true ; Encrypt = False ");

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet <Instructor> Instructors { get; set; }
        public DbSet <Department> Departments { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Course_Inst> course_Insts { get; set; }

        public DbSet<Stud_Course> Stud_Course { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>()
                .HasKey(c => new { c.inst_id, c.Course_Id });


            modelBuilder.Entity<Stud_Course>()
              .HasKey(sc => new { sc.studID, sc.CourseID });
        }

        
          
        
    }


}
