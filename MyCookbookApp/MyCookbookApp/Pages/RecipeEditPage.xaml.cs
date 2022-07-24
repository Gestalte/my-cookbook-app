namespace MyCookbookApp.Pages;

[QueryProperty(nameof(RecipeId), "recipeId")]
public partial class RecipeEditPage : ContentPage
{
	public RecipeEditPage()
	{
		InitializeComponent();
	}

    private string recipeId;
    public string RecipeId
    {
        get => recipeId;
        set
        {
            recipeId = value;

            lblRecipeName.Text = RecipeId;
        }
    }
}