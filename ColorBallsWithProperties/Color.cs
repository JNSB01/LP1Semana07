using System;

namespace ColorBallsWithProperties
{
    internal class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; } = 0;

        public int GetGray()
        {
            int media = (Red + Blue + Green)/3;
            return media;
        }
    }
}