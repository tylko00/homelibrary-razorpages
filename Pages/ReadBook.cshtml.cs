using HomelibRazor.Repositories;
using HomelibRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomelibRazor.Pages
{
  public class ReadBookModel : PageModel
  {
    private readonly IHomelibRepo _repo;

    public ReadBookModel(IHomelibRepo repo)
    {
      _repo = repo;
    }

    public Book? Book { get; set; }

    public void OnGet(int id)
    {
      Book = _repo.GetBook(id);
    }
  }
}
