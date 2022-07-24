using MyCookbookApp.Models;
using System.Collections.ObjectModel;

namespace MyCookbookApp.ViewModels
{
    public  class RecipesViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; private set; }

        public RecipesViewModel()
        {
            List<Recipe> recipes = new List<Recipe>();

            for (int i = 0; i < 50; i++)
            {
                recipes.Add(new Recipe
                {
                    Name = "Recipe " + (i + 1).ToString(),
                    ImageUrl = "out.png"
                });
            }

            Recipes = new ObservableCollection<Recipe>(recipes);
        }
    }
}
