using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_MortalJumps
{
    class Camas
    {
        protected int coordX, coordY;
        protected int altoc, anchoc;
        protected int contadorcontactos;
        public Camas(PictureBox espacio, int numContactos)
        {
            coordY = espacio.Height - 32; ;
            coordX = 50;
            altoc = 5;
            anchoc = espacio.Width - 100;
            contadorcontactos = numContactos;
        }
        //public delegate bool getContact(int pos, int xMario, int yMario);
    }
}
