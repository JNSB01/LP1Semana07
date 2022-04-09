using System;

namespace ColorBalls
{
    internal class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;

            alpha = 255;
        }

        public int GetRed()
        {
            return red;
        }
        public int GetGreen()
        {
            return green;
        }
        public int GetBlue()
        {
            return blue;
        }
        public int GetAlpha()
        {
            return alpha;
        }

        public int GetGray()
        {
            int media = (red + blue + green)/3;
            return media;
        }

        public void SetRed(int red)
        {
            this.red = red;
        }
        public void SetGreen(int green)
        {
            this.green = green;
        }
        public void SetBlue(int blue)
        {
            this.blue = blue;
        }
        public void SetAlpha(int alpha)
        {
            this.alpha = alpha;
        }

    }
}