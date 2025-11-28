using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace HomelibRazor.Model;

public class AppDbContext : DbContext
{
  public DbSet<Book> Books { get; set; }
  public DbSet<Bookshelf> Bookshelfs { get; set; }
  public DbSet<Room> Rooms { get; set; }
  public DbSet<Shelf> Shelfs { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite("Data Source = ./homelibDB.db");
  }
}
