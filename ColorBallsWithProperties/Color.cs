using System;

namespace ColorBallsWithProperties
{
    internal class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; } = 0;
        public string Name
        {
            get
            {
                if (Red == 0 && Green == 0) return "Blue 100%";
                else if (Red == 0 && Blue == 0) return "Green 100%";
                else if (Blue == 0 && Green == 0) return "Red 100%";
                else return "Mixed";
            }
        }

        public int GetGray()
        {
            int media = (Red + Blue + Green)/3;
            return media;
        }
    }
}