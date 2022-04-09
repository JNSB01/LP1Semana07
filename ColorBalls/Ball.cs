using System;

namespace ColorBalls
{
    internal class Ball
    {
        private Color cor;
        private int raio;
        private int nVezes;


        public Ball()
        {
            this.raio = 3;
            this.nVezes = 0;
            this.cor = new Color(112,105,92);
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Throw()
        {
            if (raio != 0)
            {
                nVezes += 1;
            }
        }
        public int GetVezes()
        {
            return nVezes;
        }
        public int GetRaio()
        {
            return raio;
        }
        public int GetColorGray()
        {
            return cor.GetGray();
        }
    }
}