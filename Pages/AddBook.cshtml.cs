using HomelibRazor.Repositories;
using HomelibRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomelibRazor.Pages
{
  public class AddBookModel : PageModel
  {
    private readonly IHomelibRepo _repo;
    public AddBookModel(IHomelibRepo repo)
    {
      _repo = repo;
    }
    [BindProperty(SupportsGet = true)]
    public int Shelf_id { get; set; }

    [BindProperty]
    public Book Book { get; set; }
    public IFormFile CoverImg { get; set; }

    public void OnGet(int id)
    {
      Shelf_id = id;
    }

    public IActionResult OnPost()
    {

      if (CoverImg != null)
      {
        MemoryStream ms = new MemoryStream();
        CoverImg.CopyTo(ms);
        Book.Cover = ms.ToArray();
      }
      Book.Shelf_id = Shelf_id;

      _repo.CreateBook(Book);

      return RedirectToPage("/Index");
    }
  }
}
