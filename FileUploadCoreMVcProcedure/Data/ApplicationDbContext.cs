using FileUploadCoreMVcProcedure.Models;
using Microsoft.EntityFrameworkCore;

namespace FileUploadCoreMVcProcedure.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Model
        public DbSet<Employee> Employee { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
