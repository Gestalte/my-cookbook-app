namespace MyCookbookApp.Pages;

[QueryProperty(nameof(RecipeId), "recipeId")]
public partial class RecipePage : ContentPage
{
	public RecipePage()
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
            lblDisplay.Text = recipeId;
        } 
	}
}