using Microsoft.EntityFrameworkCore;

namespace LoginAndAuthAPI.Data
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<UserDto> UserDtos { get; set; }    

  
    }
}
