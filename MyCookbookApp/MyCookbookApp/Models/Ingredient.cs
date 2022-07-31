using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookbookApp.Models
{
    public class Ingredient
    {
        public Ingredient(string amount, string name)
        {
            Amount = amount;
            Name = name;
        }

        public string Amount { get; set; }
        public string Name { get; set; }
    }
}
