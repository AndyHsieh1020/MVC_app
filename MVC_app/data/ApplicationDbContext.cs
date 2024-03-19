using Microsoft.EntityFrameworkCore;

namespace MVC_app.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }
    }
}
