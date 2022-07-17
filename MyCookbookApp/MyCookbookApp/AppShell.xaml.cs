using MyCookbookApp.Pages;

namespace MyCookbookApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("categoriespage", typeof(CategoriesPage));
        Routing.RegisterRoute("recipespage", typeof(RecipesPage));
        Routing.RegisterRoute("recipepage", typeof(RecipePage));
    }
}
