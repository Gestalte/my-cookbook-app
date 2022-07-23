using MyCookbookApp.Models;
using MyCookbookApp.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookbookApp.ViewModels
{
    public class CategoriesViewModel
    {
        public ObservableCollection<Category> Categories { get; private set; }

        public CategoriesViewModel()
        {
            List<Category> categories = new List<Category>();

            for (int i = 0; i < 50; i++)
            {
                categories.Add(new Category
                {
                    Name = "Category " + (i + 1).ToString(),
                    ImageUrl = "out.png"
                });
            }

            Categories = new ObservableCollection<Category>(categories);
        }
    }
}
