using System.ComponentModel.DataAnnotations;

namespace HomelibRazor.Model;

public class Room
{
  [Key]
  public int Id { get; set; }
  [Display(Name = "Nazwa")]
  public string? Name { get; set; }

  public ICollection<Bookshelf>? Bookshelves { get; set; }
}
