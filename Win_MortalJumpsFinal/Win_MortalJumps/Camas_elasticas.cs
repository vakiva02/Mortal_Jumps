using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_MortalJumps
{
    class Camas_elasticas:Camas
    {
        private Pen color = new Pen(Brushes.BlanchedAlmond);
        private int camasPermitas=3;
        private float[] bVector;
        private float[] mVector;
        public Camas_elasticas(PictureBox espacio):base(espacio, 1)
        {
            bVector = new float[camasPermitas];
            mVector = new float[camasPermitas];
            for (int i = 0; i < camasPermitas; i++)
            {
                mVector[i] = -1;
                bVector[i] = -1;
            }
        }
        public void Max_camas()
        {
            /*if (contadorNumCamas==2)
            {

            }*/
        }
        /*public void DibujarCamas()
        {
            for (int i = 0; i < camasPermitas; i++)
            {
                if (bVector[i]>0)
                {
                    g.DrawImage(Properties.Resources.cama_elastica, (float)(inicioX), (float)(inicioY), (float)(finalX - inicioX), (float)(finalY - inicioY));
                }
            }
        }*/
        public void dibujarCama(int inicioX, int inicioY, int finalX, int finalY, Graphics g)
        {
            int pos = bLibre();
            if (pos != -1 && inicioX!=finalX)
            {
                // graphics.DrawImage(Properties.Resources.tubos_paredes22, (float)(posx1), (float)(posy1), (float)(tamx), (float)(tamy));
                g.DrawImage(Properties.Resources.cama_elastica, (float)(inicioX), (float)(inicioY), (float)(finalX-inicioX), (float)(finalY-inicioY));
                //camasPermitas++;
                crearEcuacionRecta(inicioX, inicioY, finalX, finalY,pos);
            }
        }
        public void eliminarCamas(int i)
        {
            bVector[i] = -1;
        }
        public int bLibre()
        {
            int res=-1;
            for (int i = 0; i < camasPermitas; i++)
            {
                if (bVector[i]==-1)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
        public void crearEcuacionRecta(int inicioX, int inicioY, int finalX, int finalY, int pos)
        {
            float pendiente = (inicioY - finalY) / (inicioX - finalX);
            float b = inicioY - pendiente * inicioX;
            bVector[pos] = b;
            mVector[pos] = pendiente;
            //y=mx+b
        }
        public bool getContact(int pos, double xMario, double yMario)
        {
            /*
            altoPersonaje = 80;
            anchoPersonaje = 60;
            */
            //y-mx-b=0
            return Math.Abs(- mVector[pos] * xMario+30 + 1 * yMario+40 - bVector[pos]) / Math.Sqrt(Math.Pow(-mVector[pos], 2) + Math.Pow(1, 2))<=50;
        }
    }
}
