using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

        //one at at time here appartently
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> planetEnd = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(planetEnd);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Remove("Neptune");

            // planetList.GetRange();

            planetList.ForEach(planet => Console.WriteLine(planet));
        }

    }
}
