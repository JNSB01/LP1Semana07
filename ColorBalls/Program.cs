using System;

namespace ColorBalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball1 = new Ball();
            Ball ball2 = new Ball();

            ball1.Throw();
            ball1.Throw();
            ball2.Pop();

            Console.WriteLine($"{ball1.GetVezes()},{ball1.GetRaio()},{ball1.GetColorGray()},(112,105,92)");
            Console.WriteLine($"{ball2.GetVezes()},{ball2.GetRaio()},{ball2.GetColorGray()},(112,105,92)");

        }
    }
}
