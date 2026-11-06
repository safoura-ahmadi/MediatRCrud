
using MediatRCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatRCrud.Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}
