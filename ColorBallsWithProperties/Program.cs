using System;

namespace ColorBallsWithProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball1 = new Ball() {Raio = 4, NVezes = 0};
            Ball ball2 = new Ball() {Raio = 4, NVezes = 0};

            ball1.Throw();
            ball1.Throw();
            ball2.Raio = 0;

            Console.WriteLine($"{ball1.GetVezes()},{ball1.GetRaio()},{ball1.Cor.GetGray()},({ball1.Cor.Red = 122},{ball1.Cor.Green = 105},{ball1.Cor.Green = 92})");
            Console.WriteLine($"{ball2.GetVezes()},{ball2.GetRaio()},({ball2.Cor.Red = 112},{ball2.Cor.Green = 95},{ball2.Cor.Green = 82})");
            Console.WriteLine($"{ball2.Cor.Name}");

        }
    }
}