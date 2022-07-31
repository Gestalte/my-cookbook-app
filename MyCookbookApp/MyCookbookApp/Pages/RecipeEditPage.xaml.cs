using MyCookbookApp.ViewModels;
using CommunityToolkit.Maui.Alerts;

namespace MyCookbookApp.Pages;

[QueryProperty(nameof(RecipeId), "recipeId")]
public partial class RecipeEditPage : ContentPage
{
    public string RecipeId { get; set; }

    public RecipeEditPage()
    {
        InitializeComponent();

        BindingContext = new RecipeViewModel();

        btnIngredientAdd.Clicked += (s, e) => AddIngredient();
        btnStepAdd.Clicked += (s, e) => AddStep();
    }

    private void AddIngredient()
    {
        (this.BindingContext as RecipeViewModel).Ingredients.Add(new Models.Ingredient(txtIngredientAmount.Text, txtIngredient.Text));

        txtIngredientAmount.Text = "";
        txtIngredient.Text = "";

        Toast.Make("Added new ingredient").Show();
    }

    private void AddStep()
    {
        (this.BindingContext as RecipeViewModel).Steps.Add(new Models.Step(txtStep.Text));

        txtStep.Text = "";

        Toast.Make("Added new step").Show();
    }
}