using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HelloApp
{
  class ApplicationContext : DbContext
  {
    // public DbSet<User> Users { get; set; }
    public DbSet<Order> OrderList { get; set; }
    // public DbSet<OrderType> OrderTypes { get; set; }
    // public DbSet<OrderVeriety> OrderVerieties { get; set; }
    // public DbSet<Currency> Currencies { get; set; }
    public ApplicationContext()
    {
      Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var builder = new ConfigurationBuilder();
      // установка пути к текущему каталогу
      builder.SetBasePath(Directory.GetCurrentDirectory());
      // получаем конфигурацию из файла appsettings.json
      builder.AddJsonFile("appsettings.json");
      // создаем конфигурацию
      var config = builder.Build();
      optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
    }
  }
}