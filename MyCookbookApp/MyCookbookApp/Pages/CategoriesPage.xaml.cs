using MyCookbookApp.Models;
using MyCookbookApp.ViewModels;

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
        => Shell.Current.GoToAsync(nameof(RecipesPage) + "?categoryId=" + (e.CurrentSelection.FirstOrDefault() as Category).Name);
    
}