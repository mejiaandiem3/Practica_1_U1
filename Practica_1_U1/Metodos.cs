using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Practica_1_U1
{
    class Metodos
    {
        //Metodo para dibujar el tablero del juego
        public void DibujarTablero(ref PictureBox pct)
        {
            //Declarar 
            Graphics papel;
            papel = pct.CreateGraphics();
            //Inicializamos la pluma
            Pen lapiz = new Pen(Color.Blue, 3);
            papel.Clear(Color.White);
            //Trazar los ejes Horizontal
            papel.DrawLine(lapiz, 30, 70, 210, 70);
            papel.DrawLine(lapiz, 30, 120, 210, 120);
            //Trazar los ejes Vertical
            papel.DrawLine(lapiz, 90, 170, 90, 20);
            papel.DrawLine(lapiz, 150, 170, 150, 20);
        }
    }
}
