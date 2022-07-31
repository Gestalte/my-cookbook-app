using MyCookbookApp.Models;
using System.Collections.ObjectModel;

namespace MyCookbookApp.ViewModels
{
    public class RecipesViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; private set; }

        public RecipesViewModel()
        {
            List<Recipe> recipes = new List<Recipe>();

            var random = new Random();

            for (int i = 0; i < 50; i++)
            {
                recipes.Add(new Recipe
                {
                    Name = "Recipe " + (i + 1).ToString(),
                    ImageUrl = "i" + random.Next(6, 9) + ".jpg"
                });
            }

            Recipes = new ObservableCollection<Recipe>(recipes);
        }
    }
}
