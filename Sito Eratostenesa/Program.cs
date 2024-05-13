namespace Sito_Eratostenesa
{
    class Program
    {
        static List<int> SieveOfEratosthenes(int n)
        {
            List<bool> primes = new List<bool>(new bool[n + 1]);
            List<int> result = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (primes[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        primes[i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (primes[i] == true)
                {
                    result.Add(i);
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            List<int> primesUpTo100 = SieveOfEratosthenes(100);
            foreach (int prime in primesUpTo100)
            {
                Console.WriteLine(prime);
            }
        }
    }
}
