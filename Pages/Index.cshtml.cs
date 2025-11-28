using HomelibRazor.Repositories;
using HomelibRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomelibRazor.Pages
{
  public class IndexModel : PageModel
  {
    private readonly IHomelibRepo _repo;

    public IndexModel(IHomelibRepo repo)
    {
      _repo = repo;
    }

    public List<Book>? BooksList { get; set; }
    public List<Room>? RoomsList { get; set; }
    public List<Bookshelf>? BookshelvesList { get; set; }
    public List<Shelf>? ShelvesList { get; set; }

    public void OnGet()
    {
      BooksList = _repo.GetBooks();
      RoomsList = _repo.GetRooms();
      BookshelvesList = _repo.GetBookshelfs();
      ShelvesList = _repo.GetShelfs();
    }

    public IActionResult OnPostDelete(int Id)
    {
      _repo.DeleteBook(_repo.GetBook(Id));
      return RedirectToPage("/Index");
    }
  }
}
