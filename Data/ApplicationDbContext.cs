using AutoMapper.Configuration;
using capstone.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Data
{

    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public IConfiguration Configuration { get; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite("Data Source=app.db").Options,null)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FirstName = "Jon", LastName = "Smith" },
                new Student { Id = 2, FirstName = "Bobby", LastName = "Miller" },
                new Student { Id = 3, FirstName = "Sarah", LastName = "Brooks" }
            );


            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, FirstName = "Sam", LastName = "Smith" },
                new Teacher { Id = 2, FirstName = "Tom", LastName = "Miller" },
                new Teacher { Id = 3, FirstName = "Mary", LastName = "Brooks" }
            );

            modelBuilder.Entity<Schedule>().HasData(
                new Schedule { Id = 1, English = "Abeka", Math = "Math-U-See", Science = "Beautiful Feet", SocialStudies = "Sonlight" },
                new Schedule { Id = 2, English = "Alpha Omega", Math = "Miquon", Science = "Bob Jones", SocialStudies = "Ted-ed" },
                new Schedule { Id = 3, English = "Apologia", Math = "Saxon", Science = "edX", SocialStudies = "Coursera" },
                new Schedule { Id = 4, English = "Free-Ed", Math = "Kahn academy Online", Science = "Udemy", SocialStudies = "Hillsdale College Free Online" },
                new Schedule { Id = 5, English = "Rosetta Stone", Math = "Christian Liberty Press", Science = "Codeacademy", SocialStudies = "Stanford Online" }
            );

        }

    }
}
