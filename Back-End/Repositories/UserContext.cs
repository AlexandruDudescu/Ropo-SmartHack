using Microsoft.EntityFrameworkCore;

class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {

    }

    public DbSet<Message> Messages {get; set;}
}