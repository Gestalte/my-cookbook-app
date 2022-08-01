using System.Collections.ObjectModel;

namespace MyCookbookApp.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Serves { get; set; }
        public string PreparationTime { get; set; }
        public string CookingTime { get; set; }
    }
}
