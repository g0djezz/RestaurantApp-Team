using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/2");
            List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
            new Restaurant(4, "Huguosi Snacks","Snacks",4.2),
            new Restaurant(5, "Haidilao Hot Pot","Hot Pot",4.8)
        };
            foreach (var item in restaurants)
            {
                Console.WriteLine($"{item.Name} Type:{item.Type} -- {item.Rate}");
            }
            Console.WriteLine($"Total restaurants: {restaurants.Count}");

            double averageRate = restaurants.Average(item => item.Rate);
            Console.WriteLine($"Average rating: {averageRate:F2}");
            Console.WriteLine("samutprakan");

            Console.WriteLine("Jessada,Chanachai,Nattawut");
            Console.WriteLine("Boss");

            Console.WriteLine("Jessada");
            // Menu 5: Add New Restaurant
            Console.WriteLine("\n===== Menu 5: Add Restaurant =====");

            Console.Write("Enter restaurant name: ");
            string name = Console.ReadLine();

            Console.Write("Enter restaurant type: ");
            string type = Console.ReadLine();

            Console.Write("Enter restaurant rating (0-5): ");
            string input = Console.ReadLine();

            double rate;

            // Check rating
            if (double.TryParse(input, out rate) && rate >= 0 && rate <= 5)
            {
                int newId = restaurants.Max(r => r.Id) + 1;

                Restaurant newRestaurant = new Restaurant(
                    newId, name, type, rate
                );

                restaurants.Add(newRestaurant);

                Console.WriteLine("\nRestaurant added successfully!");
            }
            else
            {
                Console.WriteLine("\nInvalid rating! Please enter 0-5.");
            }

            // Display updated restaurant list
            Console.WriteLine("\n===== Updated Restaurant List =====");

            foreach (var item in restaurants)
            {
                Console.WriteLine(
                    $"{item.Id}. {item.Name} Type: {item.Type} -- {item.Rate}"
                );
            } //

            Console.WriteLine($"Total restaurants: {restaurants.Count}");
            Console.WriteLine("Boss");

            // Feature: Good Rate
            Console.WriteLine("\n===== Restaurants with Rate 4.5+ =====");

            var goodRestaurants = restaurants
            .Where(r => r.Rate >= 4.5)
            .ToList();

            foreach (var r in goodRestaurants)
            {
                Console.WriteLine($"ID: {r.Id}, Name: {r.Name}, Type: {r.Type}, Rating: {r.Rate}");
            }

            // Feature: Summary
            Console.WriteLine("\n===== Restaurant Summary H&L =====");

            double Maxrate = restaurants.Max(r => r.Rate);

            var HighestRestaurants = restaurants
                .Where(r => r.Rate == Maxrate)
                .ToList();

            foreach (var r in HighestRestaurants)
            {
                Console.WriteLine($"ID: {r.Id}, Name: {r.Name}, Type: {r.Type}, Rating: {r.Rate}");
            }

            double MinRate = restaurants.Min(r => r.Rate);
            var LowestRestaurants = restaurants
                .Where(r => r.Rate == MinRate)
                .ToList();
            foreach (var r in LowestRestaurants)
            {
                Console.WriteLine($"ID: {r.Id}, Name: {r.Name}, Type: {r.Type}, Rating: {r.Rate}");
            }
        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }
        public Restaurant(int id, string name, string type, double rate)
        {
            this.Id = id;
            this.Name = name;
            this.Rate = rate;
            this.Type = type;
        }
    }
}

