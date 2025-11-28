using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomelibRazor.Model;
using HomelibRazor.Repositories;

namespace HomelibRazor.Pages
{
  public class EditLibLayoutModel : PageModel
  {
    private readonly IHomelibRepo _repo;

    public EditLibLayoutModel(IHomelibRepo repo)
    {
      _repo = repo;
    }

    public List<Room>? RoomsList { get; set; }
    public List<Bookshelf>? BookshelvesList { get; set; }
    public List<Shelf>? ShelvesList { get; set; }
    public List<Book>? BooksList { get; set; }

    [BindProperty]
    public Shelf? Shelf { get; set; }

    [BindProperty]
    public Bookshelf? Bookshelf { get; set; }

    [BindProperty]
    public Room? Room { get; set; }

    public void OnGet()
    {
      RoomsList = _repo.GetRooms();
      BookshelvesList = _repo.GetBookshelfs();
      ShelvesList = _repo.GetShelfs();
      BooksList = _repo.GetBooks();
    }

    public IActionResult OnPostAddr()
    {
      _repo.CreateRoom(Room);
      return RedirectToPage("/EditLibLayout");
    }

    public IActionResult OnPostAddbs(int Id)
    {
      Bookshelf.Room_id = Id;
      _repo.CreateBookshelf(Bookshelf);
      return RedirectToPage("/EditLibLayout");
    }

    public IActionResult OnPostAdds(int Id)
    {
      Shelf.Bookshelf_id = Id;
      _repo.CreateShelf(Shelf);
      return RedirectToPage("/EditLibLayout");
    }

    public IActionResult OnPostDeleteRoom(int Id)
    {
      _repo.DeleteRoom(_repo.GetRoom(Id));
      return RedirectToPage("/EditLibLayout");
    }

    public IActionResult OnPostDeleteBookshelf(int Id)
    {
      _repo.DeleteBookshelf(_repo.GetBookshelf(Id));
      return RedirectToPage("/EditLibLayout");
    }

    public IActionResult OnPostDeleteShelf(int Id)
    {
      _repo.DeleteShelf(_repo.GetShelf(Id));
      return RedirectToPage("/EditLibLayout");
    }
  }
}
