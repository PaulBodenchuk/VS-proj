using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrots carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Mackay's", 0.77));
            carrots.Attach(new Restaurant("Johnny's Sports Bar", 0.74));
            carrots.Attach(new Restaurant("Salad Kingdom", 0.75));

            // Fluctuating carrot prices will notify subscribing restaurants.
            var responce = Console.ReadLine();
            while (double.TryParse(responce, out double price))
            {
                carrots.PricePerPound = price;
                responce = Console.ReadLine();
            }
        }
    }
}
