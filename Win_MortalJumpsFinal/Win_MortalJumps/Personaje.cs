using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Win_MortalJumps
{
    class Personaje
    {
        private double posicionx, posiciony;
        private double velocidadx, velocidady;
        private double maxh;
        private int altoPersonaje, anchoPersonaje;
        private int contador_saltos;
        private int velY;
        public Personaje()
        {
            posicionx = 40;
            posiciony = 20;
            velocidadx = 2;
            velocidady = 1;
            maxh = 100;
            altoPersonaje = 80;
            anchoPersonaje = 60;
            contador_saltos = 0;
        }
        public void Inicializar()
        {
            Console.WriteLine("Posición: {0}, {1}", posicionx, posiciony);
            
        }
        public int GetSaltos()
        {
            return contador_saltos;
        }
        public bool TerminarJuego()
        {
            return contador_saltos > 25 || posiciony>510;
        }
        public void Perder()
        {

        }
        private void DefinirImpulso(int impulso)
        {
            this.velY = impulso;
            
        }
        public void Caer(int direccion)
        {
            Console.WriteLine("Caer...");
            posicionx += 15*direccion;
            if (velY == 0)
            {
                velY++;
            }
            posiciony += velY;
            if (velY < 1)
            {
                velY /= 2;
            }
            else
            {
                velY += velY - velY / 3;
            }
        }
        public void Rebotar(int rebote)
        {
            DefinirImpulso(rebote);
            contador_saltos++;
        }
        public void Ganar(double posicionx, double posiciony)
        {

        }
        public void Dibujar(Graphics graphics)
        {
            graphics.DrawImage(Properties.Resources.Mario2, (float)(posicionx), (float)(posiciony), (float)(anchoPersonaje),
                (float)(altoPersonaje));
            //return;
        }
        
        /*public void Borrar(Graphics graphics)
        {
            graphics.DrawImage(, (float)(posicionx), (float)(posiciony), (float)(anchoPersonaje),
                (float)(altoPersonaje));
        }*/
        public double getX()
        {
            return posicionx;
        }
        public double getY()
        {
            return posiciony;
        }
    }
}
