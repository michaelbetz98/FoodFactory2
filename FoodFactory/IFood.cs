using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory
{
    public interface IFood
    {
        string Name { get; set; }
        float Price { get; set; }
        DateTime ExpirationDate { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Nome: {this.Name} Scadenza: {this.ExpirationDate} Prezzo: {this.Price}");
        }
    }
}
