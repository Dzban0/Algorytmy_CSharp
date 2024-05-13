namespace Wielomian_do_potęgi_5
{
    class Program
    {
        static double FifthDegreePolynomial(double x, double a, double b, double c, double d, double e, double f)
        {
            return a * Math.Pow(x, 5) + b * Math.Pow(x, 4) + c * Math.Pow(x, 3) + d * Math.Pow(x, 2) + e * x + f;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartości parametrów a, b, c, d, e i f:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę: ");
            double x = double.Parse(Console.ReadLine());

            double result = FifthDegreePolynomial(x, a, b, c, d, e, f);
            Console.WriteLine($"Wynik wielomianu dla liczby {x} wynosi: {result}");
        }
    }
}
