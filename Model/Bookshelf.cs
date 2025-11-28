using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomelibRazor.Model;

public class Bookshelf
{
  [Key]
  public int Id { get; set; }
  [Display(Name = "Nazwa")]
  public string? Name { get; set; }
  [ForeignKey("Room")]
  public int Room_id { get; set; }

  public ICollection<Shelf>? Shelves { get; set; }
  public Room? Room { get; set; }
}
