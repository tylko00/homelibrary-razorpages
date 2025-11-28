using HomelibRazor.Model;

namespace HomelibRazor.Repositories;

public interface IHomelibRepo
{
  bool CreateRoom(Room entity);
  bool CreateBookshelf(Bookshelf entity);
  bool CreateShelf(Shelf entity);
  bool CreateBook(Book entity);


  List<Room> GetRooms();
  List<Bookshelf> GetBookshelfs();
  List<Shelf> GetShelfs();
  List<Book> GetBooks();

  Room GetRoom(int id);
  Bookshelf GetBookshelf(int id);
  Shelf GetShelf(int id);
  Book GetBook(int id);

  bool UpdateBook(Book entity);

  bool DeleteRoom(Room entity);
  bool DeleteBookshelf(Bookshelf entity);
  bool DeleteShelf(Shelf entity);
  bool DeleteBook(Book entity);

}
