using Api.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Algorithms> Algorithms { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CoursesAuthor> CoursesAuthor { get; set; }
        public DbSet<LearningSteps> LearningSteps { get; set; }
    }
}
