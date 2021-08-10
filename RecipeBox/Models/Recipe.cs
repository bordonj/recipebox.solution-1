using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<CategoryRecipe>();
    }

    public int RecipeId { get; set; }
    public string Name { get; set; }
    public string Ingredient { get; set; }
    public string Instruction { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<CategoryRecipe> JoinEntities { get;}
  }
}