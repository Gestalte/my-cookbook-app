using MyCookbookApp.Models;
using MyCookbookApp.ViewModels;

namespace MyCookbookApp.Pages;

[QueryProperty(nameof(CategoryId), "categoryId")]
public partial class RecipesPage : ContentPage
{

    public RecipesPage()
    {
        InitializeComponent();
        BindingContext = new RecipesViewModel();

        fab.Clicked += async (s, e) => await Shell.Current.GoToAsync(nameof(RecipeEditPage));
    }

    private string categoryId;
    public string CategoryId
    {
        get => categoryId;
        set
        {
            categoryId = value;
        }
    }

    void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var current = (e.CurrentSelection.FirstOrDefault() as Recipe).Name;

        Shell.Current.GoToAsync(nameof(RecipePage) + "?recipeId=" + current);
    }
}