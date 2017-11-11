
using Microsoft.EntityFrameworkCore;
using testgreenfish.Models;
using System.Linq;


namespace testgreenfish.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Email> Emails { get; set; }
    }
}