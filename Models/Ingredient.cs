using System;
using System.ComponentModel.DataAnnotations;

namespace Allspice.Models
{
public class Indredient
{
  public int Id{ get; set; }
  [Required]
  public int RecipeId { get; set; }
  public string Title{ get; set; }
  public string ImgUrl{ get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
}