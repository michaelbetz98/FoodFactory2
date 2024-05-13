using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory
{
    internal class Vegetable : IFood
    {
        string IFood.Name { get; set; }
        float IFood.Price { get; set; }
        DateTime IFood.ExpirationDate { get; set; }
    }
}
