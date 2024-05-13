using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory
{
    public class ShoppingCart
    {
        public List<(IFood food, int number)> Foods { get; set; }

        public void AddItem(IFood food, int n)
        {
            Foods.Add((food, n));
        }

        public void RemoveItem(IFood food)
        {
            foreach (var item in Foods)
            {
                if (item.Item1 == food)
                    Foods.Remove(item);
            }
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var item in Foods)
            {
                total += item.number * item.food.Price;
            }
            return total;
        }
    }
}
