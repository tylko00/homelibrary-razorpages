using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomelibRazor.Model;

public class Shelf
{
  [Key]
  public int Id { get; set; }
  [Display(Name = "Nazwa")]
  public string? Name { get; set; }
  [ForeignKey("Bookshelf")]
  public int Bookshelf_id { get; set; }

  public Bookshelf? Bookshelf { get; set; }
  public ICollection<Book>? Books { get; set; }
}
