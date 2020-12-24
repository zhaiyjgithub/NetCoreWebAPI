using Microsoft.EntityFrameworkCore;
using NetCoreWebAPI.Entities;

namespace NetCoreWebAPI.Data
{
    public class MainDbContext: DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<Clinical> Clinicals { get; set; }
        
    }
    
    
}