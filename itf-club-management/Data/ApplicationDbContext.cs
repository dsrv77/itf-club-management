using itf_club_management.Models;
using Microsoft.EntityFrameworkCore;

namespace itf_club_management.Data;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Member> Contacts { get; set; }
    public DbSet<Payment> Payments { get; set; }
}