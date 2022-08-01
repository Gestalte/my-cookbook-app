using MyCookbookApp.ViewModels;

namespace MyCookbookApp.Pages;

[QueryProperty(nameof(RecipeId), "recipeId")]
public partial class RecipePage : ContentPage
{
    public string RecipeId { get; set; }

    public RecipePage()
    {
        InitializeComponent();

        this.BindingContext = new RecipeViewModel();

        var recipeViewModel = this.BindingContext as RecipeViewModel;

        this.Title = recipeViewModel.Recipe.Name;

        // TODO: Some kind of display adapter for adding numbers before the steps e.g. 1. <Step description>
    }
}