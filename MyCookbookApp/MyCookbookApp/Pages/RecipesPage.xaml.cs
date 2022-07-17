namespace MyCookbookApp.Pages;

[QueryProperty(nameof(CategoryId), "categoryId")]
public partial class RecipesPage : ContentPage
{

    public RecipesPage()
    {
        InitializeComponent();

        RecipeButton.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipepage?recipeId=Recipe");
    }

    private string categoryId;
    public string CategoryId
    {
        get => categoryId;
        set
        {
            categoryId = value;
            lblDisplay.Text = categoryId;
        }
    }
}