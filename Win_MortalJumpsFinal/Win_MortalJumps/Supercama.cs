using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_MortalJumps
{
    class Supercama:Camas
    {
        public Supercama(PictureBox espacio):base(espacio, 0)
        {
        }
        public void Inicializar()
        {
            Console.WriteLine("Posición: {0}, {1}", coordX, coordY);
            
        }

        public void Dibujar(Graphics graphics)
        {
            if (contadorcontactos < 50)
            {
                if (contadorcontactos<30)
                {
                    graphics.DrawImage(Properties.Resources.cama_elastica, (float)(coordX), (float)(coordY), (float)(anchoc), (float)(altoc + 20));
                }
                else
                {
                    graphics.DrawImage(Properties.Resources.Fuego, (float)(coordX), (float)(coordY), (float)(anchoc), (float)(altoc + 20));
                }
                
            }
            return;
        }
        public bool getContact(double yMario)
        {
            /*
            altoPersonaje = 80;
            anchoPersonaje = 60;
            */
            //y-mx-b=0
            bool res = yMario + 80>= coordY;
            contadorcontactos++;
            if (contadorcontactos>50)
            {
                res = false;
            }
            return res;
        }
    }
}
