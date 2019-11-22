using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TSPSolver.TSP
{
    public class TSPSolving
    {
        public TSPSolving(string name, IReadOnlyList<int> optimaltour, IReadOnlyList<Location> cities)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name must not be null or whitespace!", nameof(name));
            }

            Name = name;
            Optimaltour = optimaltour ?? throw new ArgumentNullException(nameof(optimaltour));
            Cities = cities ?? throw new ArgumentNullException(nameof(cities));
        }

        public string Name { get; }
        public IReadOnlyList<int> Optimaltour { get; }
    
        public IReadOnlyList<Location> Cities { get; }
    }

    public class Location
    {
        public Location(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get;}
        public double Y { get; }
    }
}
