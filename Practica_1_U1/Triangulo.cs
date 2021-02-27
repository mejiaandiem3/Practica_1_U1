using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms; //se agregaron dos librerias para el uso de ciertos componentes

namespace Practica_1_U1
{
    public class Triangulo
    {
        //inicializacion de variables y objetos
        private Pen lapiz;
        private PictureBox picpapel;
        private Graphics dibujarT;
        private TextBox txtLadoA, txtLadoB, txtLadoC;
        private int a = 0;
        private int b = 0;
        private double c = 0;
        int cA = 0, cB = 0;

        // private int x1,x2,y1,y2,z1,z2;
        public Triangulo()
        {

        }

        public Triangulo(PictureBox picpapel, TextBox txtLadoA, TextBox txtLadoB, TextBox txtLadoC)
        {
            //se le asigna una variable a los objetos
            this.txtLadoA = txtLadoA;
            this.txtLadoB = txtLadoB;
            this.picpapel = picpapel;
            this.txtLadoC = txtLadoC;


        }
        
        public void dibujar()
        {
            //se inicaliza el grafico
            dibujarT = picpapel.CreateGraphics();

            //se inicializa el lapiz y se le asigna un color
            lapiz = new Pen(Color.Black, 2);
            lapiz.Color = Color.Black;
            try
            {
            //se le asigna lo que contienen los textbox a las variables
            a = Convert.ToInt32(txtLadoA.Text);
            b = Convert.ToInt32(txtLadoB.Text);

            //se realiza el teorema de pitagoras para mostrar cuanto mide el lado c en el textbox
            int c1 = (a * a) + (b * b);
            double raiz = Math.Sqrt(c1);
            c = raiz;
            txtLadoC.Text = Convert.ToString(c);

            //operaciones para sacar medidas correctas
            cA = 300 - a;
            cB = b - 15;

            //dibuja el lado a
            dibujarT.DrawLine(lapiz, Convert.ToInt32(15), Convert.ToInt32(300), Convert.ToInt32(15), Convert.ToInt32(cA));
            //dibuja el lado b
            dibujarT.DrawLine(lapiz, Convert.ToInt32(15), Convert.ToInt32(300), Convert.ToInt32(cB), Convert.ToInt32(300));
            //dibuja el lado c
            dibujarT.DrawLine(lapiz, Convert.ToInt32(15), Convert.ToInt32(cA), Convert.ToInt32(cB), Convert.ToInt32(300));

            //Libera todos los recursos utilizados por este System.Drawing.Pen
            lapiz.Dispose();
            //Libera todos los recursos utilizados por este System.Drawing.Graphics.
            dibujarT.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show("Porfavor ingrese los valores.","Error"); ;
            }

        }

    }
}
