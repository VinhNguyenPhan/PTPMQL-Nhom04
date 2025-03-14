using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; } 
        public DbSet<DaiLy> DaiLy { get; set; }
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set; }
    }
}