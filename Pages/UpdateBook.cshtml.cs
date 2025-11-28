using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomelibRazor.Repositories;
using HomelibRazor.Model;


namespace HomelibRazor.Pages
{
  public class UpdateBookModel : PageModel
  {
    private readonly IHomelibRepo _repo;

    public UpdateBookModel(IHomelibRepo repo)
    {
      _repo = repo;
    }

    [BindProperty]
    public Book? Book { get; set; }
    public IFormFile CoverImg { get; set; }

    public void OnGet(int id)
    {
      Book = _repo.GetBook(id);
    }

    public IActionResult OnPost(int Id)
    {
      Book bookToUpdate = _repo.GetBook(Id);
      bookToUpdate.Title = Book.Title;
      bookToUpdate.First_name = Book.First_name;
      bookToUpdate.Last_name = Book.Last_name;
      bookToUpdate.Description = Book.Description;

      if (CoverImg != null)
      {
        MemoryStream ms = new MemoryStream();
        CoverImg.CopyTo(ms);
        bookToUpdate.Cover = ms.ToArray();
      }

      _repo.UpdateBook(bookToUpdate);

      return RedirectToPage("/Index");
    }
  }
}
