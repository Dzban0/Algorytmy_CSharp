namespace Funkcja_sześcienna
{
    internal class Program
    {
        static double CubicFunction(double x)
        {
            return Math.Pow(x, 3);
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            double x = double.Parse(Console.ReadLine());
            double result = CubicFunction(x);
            Console.WriteLine($"Wynik funkcji sześciennej dla liczby {x} wynosi: {result}");
        }
    }
}
