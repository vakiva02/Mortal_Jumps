using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_MortalJumps
{
    class Tubos
    {
        private double posx1, posy1, posx2;
        private double tamx, tamy;
        public Tubos(int x, int y)
        {
            posx1 = 0;
            posy1 = y / 5;
            posx2 = (x / 10) * 9;
            tamx = x / 10;
            tamy = (y / 5) * 4;
        }
        public void Dibujar(Graphics graphics)
        {
            graphics.DrawImage(Properties.Resources.tubos_paredes22, (float)(posx1), (float)(posy1), (float)(tamx), (float)(tamy));
            graphics.DrawImage(Properties.Resources.tubos_paredes22, (float)(posx2), (float)(posy1), (float)(tamx), (float)(tamy));
        }
        public bool getContact(double xMario)
        {
            return xMario < posx1 + tamx || xMario > posx2- tamx;
        }
    }
}
