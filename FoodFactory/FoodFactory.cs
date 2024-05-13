using FoodFactory.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory
{
    public static class FoodFactory
    {
        public static IFood NewFood(string type) => type switch
        {
            "fruit" => new Fruit(),
            "meat" => new Meat(),
            "vegetables" => new Vegetable(),
            _ => throw new FoodTypeNotFoundException(type)
        };
    }
}
