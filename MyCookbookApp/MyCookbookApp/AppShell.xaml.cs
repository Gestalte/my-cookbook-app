using MyCookbookApp.Pages;

namespace MyCookbookApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(CategoriesPage), typeof(CategoriesPage));
        Routing.RegisterRoute(nameof(RecipesPage), typeof(RecipesPage));
        Routing.RegisterRoute(nameof(RecipePage), typeof(RecipePage));

        Routing.RegisterRoute(nameof(CategoryEditPage), typeof(CategoryEditPage));
        Routing.RegisterRoute(nameof(RecipeEditPage), typeof(RecipeEditPage));
    }
}
