using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookbookApp.Models
{
    public class Step
    {
        public Step(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}
