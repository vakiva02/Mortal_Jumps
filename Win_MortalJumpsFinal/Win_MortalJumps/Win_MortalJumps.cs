using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_MortalJumps
{
    public partial class Win_MortalJumps : Form
    {
        private Pen blanco = new Pen(Brushes.BlanchedAlmond);
        private Graphics g;
        private Personaje p;
        private Supercama sp;
        private Camas_elasticas cama;
        private Tubos tubo1;
        private Tubos tubo2;
        private int inicioX, inicioY, finalX, finalY;
        private int direccion = 1;
        public Win_MortalJumps()
        {
            InitializeComponent();
            pictureBox_arena.Visible = false;
            this.BackgroundImage = Properties.Resources.mario_fondo;
            button_salir.Visible = false;
            lblGameOver.Visible = false;
            lblNumSaltos.Visible = false;
            lblSaltos.Visible = false;
            buttonvolver.Visible = false;
            //this.BackgroundImage = Properties.Resources.Imagen_fondo;
            //timer1.Start();
            p = new Personaje();
            sp = new Supercama(pictureBox_arena);
            cama = new Camas_elasticas(pictureBox_arena);
            g = pictureBox_arena.CreateGraphics();
            tubo1 = new Tubos(pictureBox_arena.Width, pictureBox_arena.Height);
            //tubo2 = new Tubos(pictureBox_arena, 500, 50);
            pictureBox_arena.BackgroundImage = Properties.Resources.fondo_mortaljumps2;
            pictureBox_arena.SendToBack();
            tubo1.Dibujar(g);
            //tubo2.Dibujar(g);
        }
        public void Inicializar()
        {
            p.Inicializar();
            sp.Inicializar();
            //return;
        }

        private void pictureBox_arena_Paint(object sender, PaintEventArgs e)
        {
            sp.Dibujar(e.Graphics);
            p.Dibujar(e.Graphics);
            tubo1.Dibujar(e.Graphics);
            return;
        }

        private void pictureBox_arena_MouseUp(object sender, MouseEventArgs e)
        {
            finalX = e.X;
            finalY = e.Y;
            cama.dibujarCama(inicioX, inicioY, finalX, finalY,g);
            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!p.TerminarJuego())
            {
                p.Caer(direccion);
                p.Dibujar(g);
                //bool getContact(int pos, int xMario, int yMario)
                for (int i = 0; i < 3; i++)
                {
                    if (cama.getContact(i, p.getX(), p.getY()))
                    {
                        p.Rebotar(-30);
                        cama.eliminarCamas(i);
                    }
                }
                if (sp.getContact(p.getY()))
                {
                    //sp.Incendiarse(g);
                    p.Rebotar(-60);
                }
                if (tubo1.getContact(p.getX()))
                {
                    direccion *= -1;
                }
                pictureBox_arena.Invalidate();
            }
            else
            {
                pictureBox_arena.Invalidate();
                timer1.Stop();
                pictureBox_arena.Visible = false;
                button_salir.Visible = false;
                lblGameOver.Visible = true;
                lblNumSaltos.Visible = true;
                lblSaltos.Visible = true;
                lblSaltos.Text = p.GetSaltos().ToString();
                this.BackgroundImage = Properties.Resources.Fondo_marioobjetos;
                //buttonvolver.Visible = true;

            }
            //return;
        }
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            pictureBox_arena.Visible = true;
            button_salir.Visible = true;
            btnComenzar.Visible = false;
            LblMortalJumps.Visible = false;
            timer1.Start();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Win_MortalJumps_Load(object sender, EventArgs e)
        {

        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonvolver_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox_arena_Click(object sender, EventArgs e)
        {

        }
        private void buttonvolver_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox_arena_MouseDown(object sender, MouseEventArgs e)
        {
            inicioX = e.X;
            inicioY = e.Y;
        }
    }
}
