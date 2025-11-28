using HomelibRazor.Model;

namespace HomelibRazor.Repositories;

public class HomelibRepo : IHomelibRepo
{
  private readonly AppDbContext appDbContext = new AppDbContext();

  public HomelibRepo()
  {
    appDbContext.Database.EnsureCreated();
  }


  public bool CreateRoom(Room entity)
  {
    appDbContext.Rooms.Add(entity);
    return appDbContext.SaveChanges() == 1;
  }

  public bool CreateBookshelf(Bookshelf entity)
  {
    appDbContext.Bookshelfs.Add(entity);
    return appDbContext.SaveChanges() == 1;
  }

  public bool CreateShelf(Shelf entity)
  {
    appDbContext.Shelfs.Add(entity);
    return appDbContext.SaveChanges() == 1;
  }

  public bool CreateBook(Book entity)
  {
    appDbContext.Books.Add(entity);
    return appDbContext.SaveChanges() == 1;
  }

  public List<Room> GetRooms()
  {
    return appDbContext.Rooms.ToList();
  }

  public List<Bookshelf> GetBookshelfs()
  {
    return appDbContext.Bookshelfs.ToList();
  }


  public List<Shelf> GetShelfs()
  {
    return appDbContext.Shelfs.ToList();
  }

  public List<Book> GetBooks()
  {
    return appDbContext.Books.ToList();
  }

  public Room GetRoom(int id)
  {
    return appDbContext.Rooms.Where(n => n.Id == id).Single();
  }

  public Bookshelf GetBookshelf(int id)
  {
    return appDbContext.Bookshelfs.Where(n => n.Id == id).Single();
  }

  public Shelf GetShelf(int id)
  {
    return appDbContext.Shelfs.Where(n => n.Id == id).Single();
  }

  public Book GetBook(int id)
  {
    return appDbContext.Books.Where(n => n.Id == id).Single();
  }

  public bool UpdateBook(Book entity)
  {
    appDbContext.Books.Update(entity);
    return appDbContext.SaveChanges() == 1;
  }

  public bool DeleteRoom(Room entity)
  {
    appDbContext.Rooms.Remove(entity);
    return appDbContext.SaveChanges() == 1;
  }

  public bool DeleteBookshelf(Bookshelf entity)
  {
    appDbContext.Bookshelfs.Remove(entity);
    return appDbContext.SaveChanges() == 1;
  }

  public bool DeleteShelf(Shelf entity)
  {
    appDbContext.Shelfs.Remove(entity);
    return appDbContext.SaveChanges() == 1;
  }

  public bool DeleteBook(Book entity)
  {
    appDbContext.Books.Remove(entity);
    return appDbContext.SaveChanges() == 1;
  }
}
