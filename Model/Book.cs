using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HomelibRazor.Model;

public class Book
{
  [Key]
  public int Id { get; set; }
  [Display(Name = "Tytuł")]
  public string? Title { get; set; }
  [Display(Name = "Imię")]
  public string? First_name { get; set; }
  [Display(Name = "Nazwisko")]
  public string? Last_name { get; set; }
  [Display(Name = "Opis")]
  public string? Description { get; set; }
  [Display(Name = "Zdjęcie okładki")]
  public byte[]? Cover { get; set; }
  [ForeignKey("Shelf")]
  public int Shelf_id { get; set; }

  public Shelf? Shelf { get; set; }
}
