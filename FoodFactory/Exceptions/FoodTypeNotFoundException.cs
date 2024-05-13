using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory.Exceptions
{
    public class FoodTypeNotFoundException : Exception
    {
        public string type { get; set; }

        public FoodTypeNotFoundException(string type)
        {
            this.type = type;
        }
    }
}
