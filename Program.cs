using System;
using System.Collections.Generic;

namespace listPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Planet List:");
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            // planetList.ForEach(planet => Console.WriteLine(planet));

            List<string> newPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(newPlanets);
            // Console.WriteLine("AddRange New Planets");
            // planetList.ForEach(planet => Console.WriteLine(planet));

            List<string> correctOrder = new List<string>() { "Venus", "Earth" };
            planetList.InsertRange(1, correctOrder);
            planetList.Add("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine("Rocky Planets:");
            rockyPlanets.ForEach(planet => Console.WriteLine(planet));

            Console.WriteLine("Pluto is not a planet :(");
            planetList.Remove("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
        }
    }
}
