using MyCookbookApp.Models;

namespace MyCookbookApp.Pages;

[QueryProperty(nameof(CategoryId), "categoryId")]
public partial class CategoryEditPage : ContentPage
{
    public CategoryEditPage()
	{
		InitializeComponent();
	}

    private string categoryId;
    public string CategoryId
    {
        get => categoryId;
        set
        {
            categoryId = value;

            lblCategoryName.Text = CategoryId;
        }
    }
}