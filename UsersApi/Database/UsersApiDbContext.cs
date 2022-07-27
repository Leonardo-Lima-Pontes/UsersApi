using Microsoft.EntityFrameworkCore;
using UsersApi.Models;

namespace UsersApi.Database;

public class UsersApiDbContext : DbContext
{
    public UsersApiDbContext(DbContextOptions<UsersApiDbContext> options) : base(options)
    {
    }
    
    public DbSet<User>? Users { get; set; }
}