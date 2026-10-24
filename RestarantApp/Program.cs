using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestarantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/2");
        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }

        public Restaurant(int id,string name,string type,double rate)
        {
            Id = id;
            Name = name;
            Type = type;
            Rate = rate;
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
         };
            }
        }
    }
}

