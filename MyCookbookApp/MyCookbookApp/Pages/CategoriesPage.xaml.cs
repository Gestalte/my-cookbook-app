using MyCookbookApp.Models;
using MyCookbookApp.ViewModels;
using System.Collections.ObjectModel;

namespace MyCookbookApp.Pages;

public partial class CategoriesPage : ContentPage
{
    // TODO: Add a way to edit an existing Category

    public CategoriesPage()
    {
        InitializeComponent();
        BindingContext = new CategoriesViewModel();

        fab.Clicked += async (s, e) => await Shell.Current.GoToAsync(nameof(CategoryEditPage));
    }

    void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var current = (e.CurrentSelection.FirstOrDefault() as Category).Name;

        var page  = nameof(RecipesPage)+ "?categoryId="+ current;

        Shell.Current.GoToAsync(page);
    }
}