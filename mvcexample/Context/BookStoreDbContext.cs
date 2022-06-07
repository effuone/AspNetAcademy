using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvcexample.Context;
using mvcexample.Models;

public class BookStoreDbContext : IdentityDbContext<BookStoreUser>
{
    public BookStoreDbContext()
    {
        
    }
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
    {
    }
    public DbSet<Book> Books {get; set;}
    public DbSet<Author> Authors { get; set; }
    public DbSet<Customer> Customers {get; set;}
    public DbSet<Order> Orders { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=tcp:localhost;Database=BookStore;User Id=hbuser;Password=hbuser1029");
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
    
}