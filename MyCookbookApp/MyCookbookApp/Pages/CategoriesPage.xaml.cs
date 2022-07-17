namespace MyCookbookApp.Pages;

public partial class CategoriesPage : ContentPage
{
	public CategoriesPage()
	{
		InitializeComponent();

		RecipeButton.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipespage?categoryId=Recipes");
    }
}