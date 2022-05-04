using Microsoft.EntityFrameworkCore;

using TwitchStep02.Models;

namespace TwitchStep02.Data.Context
{
    public class Twitch02DBContext : DbContext
    {
        public Twitch02DBContext(DbContextOptions<Twitch02DBContext> options)
            : base(options)
        {
        }
        public DbSet<Customer>? Customers { get; set; }
    }
}
