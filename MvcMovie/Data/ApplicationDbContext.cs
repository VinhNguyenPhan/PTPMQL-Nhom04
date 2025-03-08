using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace MvcMovie.Data
{
    public class ApplicatonDbContext : DbContext
    {
        public ApplicatonDbContext(DbContextOptions<ApplicatonDbContext> options) : base(options)
        {}
        public DbSet<Person> Person {get; set;}
    }
}