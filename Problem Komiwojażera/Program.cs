namespace Problem_Komiwojażera
{
    class Program
    {
        static double CalculateDistance((double x, double y) point1, (double x, double y) point2)
        {
            return Math.Sqrt(Math.Pow(point1.x - point2.x, 2) + Math.Pow(point1.y - point2.y, 2));
        }

        static (double distance, List<(double x, double y)> path) TravelingSalesman(List<(double x, double y)> points)
        {
            double shortestDistance = double.MaxValue;
            List<(double x, double y)> shortestPath = null;

            foreach (var path in GetPermutations(points))
            {
                double distance = 0;
                for (int i = 0; i < path.Count - 1; i++)
                {
                    distance += CalculateDistance(path[i], path[i + 1]);
                }
                distance += CalculateDistance(path.Last(), path.First()); // Wróć do punktu początkowego

                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    shortestPath = path.ToList();
                }
            }

            return (shortestDistance, shortestPath);
        }

        static IEnumerable<List<T>> GetPermutations<T>(IEnumerable<T> list)
        {
            if (list.Count() == 1)
                return new List<List<T>> { new List<T>(list) };

            return list.SelectMany((element, index) =>
                GetPermutations(list.Where((e, i) => i != index))
                .Select(permutation => { permutation.Insert(0, element); return permutation; }));
        }

        static void Main(string[] args)
        {
            List<(double x, double y)> points = new List<(double x, double y)>
            {
                (0, 0), (1, 2), (3, 1), (5, 3)
            };

            var (shortestDistance, shortestPath) = TravelingSalesman(points);
            Console.WriteLine("Najkrótsza droga:");
            foreach (var point in shortestPath)
            {
                Console.WriteLine($"({point.x}, {point.y})");
            }
            Console.WriteLine($"Długość najkrótszej drogi: {shortestDistance}");
        }
    }
}
