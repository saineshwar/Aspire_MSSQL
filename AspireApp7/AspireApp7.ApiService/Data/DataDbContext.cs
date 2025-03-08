using AspireApp7.ApiService.Models;
using Microsoft.EntityFrameworkCore;

namespace AspireApp7.ApiService.Data;

public class DataDbContext : DbContext
{
    // Define your constructor here
    /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
    public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

    // Define your DbSets (tables) here
    public DbSet<Product> Products { get; set; }
}