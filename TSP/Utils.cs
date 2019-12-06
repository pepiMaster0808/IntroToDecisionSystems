using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSPSolver.TSP
{
    public static class Utils
    {
        public static double GetDistance(IReadOnlyList<int> solution, IReadOnlyList<Location> cities)
        {
            double entfX = 0;
            for(int i = 0; i < cities.Count; i++)
            {
                entfX += Math.Sqrt(Math.Pow(Math.Abs(cities[i].X - cities[i + 1].X), 2) + Math.Pow(Math.Abs(cities[i].Y - cities[i + 1].Y), 2)); 
            }
            return entfX;
        }

    }
}
