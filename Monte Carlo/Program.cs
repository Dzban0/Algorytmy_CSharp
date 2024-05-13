namespace Monte_Carlo
{
    class Program
    {
        static double MonteCarloPi(int numSamples)
        {
            Random random = new Random();
            int insideCircle = 0;
            for (int i = 0; i < numSamples; i++)
            {
                double x = random.NextDouble() * 2 - 1;
                double y = random.NextDouble() * 2 - 1;
                double distance = x * x + y * y;
                if (distance <= 1)
                {
                    insideCircle++;
                }
            }
            return (double)insideCircle / numSamples * 4;
        }

        static void Main(string[] args)
        {
            double piEstimate = MonteCarloPi(100000);
            Console.WriteLine(piEstimate); 
        }
    }
}
