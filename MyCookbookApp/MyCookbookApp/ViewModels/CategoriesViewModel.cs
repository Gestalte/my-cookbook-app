using MyCookbookApp.Models;
using System.Collections.ObjectModel;

namespace MyCookbookApp.ViewModels
{
    public class CategoriesViewModel
    {
        public ObservableCollection<Category> Categories { get; private set; }

        public CategoriesViewModel()
        {
            List<Category> categories = new List<Category>();

            var random = new Random();

            for (int i = 0; i < 50; i++)
            {
                categories.Add(new Category
                {
                    Name = "Category " + (i + 1).ToString(),
                    ImageUrl = "i"+random.Next(1, 6) + ".jpg"
                });
            }

            Categories = new ObservableCollection<Category>(categories);
        }
    }
}
