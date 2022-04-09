using System;

namespace ColorBallsWithProperties
{
    internal class Ball
    {
        public Color Cor { get; set; } = new Color() {Red = 112, Green = 105, Blue = 92};
        public int Raio { get; set; } = 3;
        public int NVezes { get; set; } = 0;

        public void Throw()
        {
            if (Raio != 0)
            {
                NVezes += 1;
            }
        }
        public int GetVezes()
        {
            return NVezes;
        }
        public int GetRaio()
        {
            return Raio;
        }
    }
}