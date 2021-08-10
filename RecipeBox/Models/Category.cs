using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeBox.Models
{
  public class Category
  {
    public Category()
    {
      this.JoinEntities = new HashSet<CategoryRecipe>();
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<CategoryRecipe> JoinEntities { get; set; }
  }
}