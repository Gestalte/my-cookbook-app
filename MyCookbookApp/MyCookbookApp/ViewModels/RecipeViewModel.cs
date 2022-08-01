using MyCookbookApp.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyCookbookApp.ViewModels
{
    public class RecipeViewModel
    {
        public Recipe Recipe { get; set; }=new Recipe();
        public ObservableCollection<Ingredient> Ingredients { get; private set; } = new ObservableCollection<Ingredient>();
        public ObservableCollection<Step> Steps { get; private set; } = new ObservableCollection<Step>();

        public RecipeViewModel()
        {
            Recipe.ImageUrl = "i1.jpg";
            Recipe.Name = "Microwave Mielie pap";
            Recipe.Description = "Mielie pap made in the microwave.";
            Recipe.Serves = "1";
            Recipe.PreparationTime = "12min";

            Ingredients = SetupIngredients();
            Steps = SetupSteps();

            RemoveIngredientCommand = new Command<Ingredient>(ingredient =>
            {
                Ingredients.Remove(ingredient);
            });

            RemoveStepCommand = new Command<Step>(step =>
            {
                Steps.Remove(step);
            });
        }

        private ObservableCollection<Ingredient> SetupIngredients()
        {
            List<Ingredient> ingredient = new List<Ingredient>();

                ingredient.AddRange(new List<Ingredient>
                {
                    new Ingredient("1 cup","Self-raising flour"),
                    new Ingredient("1 tsp","Salt"),
                    new Ingredient("3/4 cup","Boiling water"),
                    new Ingredient("as desired","Sugar"),
                });

            return new ObservableCollection<Ingredient>(ingredient);
        }

        private ObservableCollection<Step> SetupSteps()
        {
            List<Step> steps = new List<Step>();

                steps.AddRange(new List<Step>
                {
                    new Step("Mix self-raising flour and salt in a microwavable glass bowl."),
                    new Step("Microwave for 8 minutes at 50% power, stopping every 2 minutes to stir"),
                    new Step("Pour boiling water into the glass bowl and stir the mixture untill there is no dry material remaining."),
                    new Step("Serve in a breakfast bowl with milk. Sprinkle sugar on top."),
                });

            return new ObservableCollection<Step>(steps);
        }

        public Command<Ingredient> RemoveIngredientCommand { get; private set; }
        public Command<Step> RemoveStepCommand { get; private set; }

    }
}
