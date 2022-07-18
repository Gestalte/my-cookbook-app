using MyCookbookApp.Models;
using MyCookbookApp.ViewModels;
using System.Collections.ObjectModel;

namespace MyCookbookApp.Pages;

public partial class CategoriesPage : ContentPage
{
    public CategoriesPage()
    {
        InitializeComponent();
        BindingContext = new CategoriesViewModel();

        //RecipeButton.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipespage?categoryId=Recipes");
        fab.Clicked += async (s, e) => await Shell.Current.GoToAsync("categoryeditpage");
    }
}