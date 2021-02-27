using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_U1
{
    public partial class Ejercicio1 : Form
    {
        //se declaran variables
        public Graphics papel;
        Triangulo triangulo;
        public Ejercicio1()
        {
            InitializeComponent();
            //se inicializa el papel
            papel = picpapel.CreateGraphics();
            //se inicializa el objeto de la clase Triangulo
            triangulo = new Triangulo(picpapel, txtLadoA, txtLadoB, txtLadoC);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //se cierra la forma
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //se limpian los textbox y el picturebox
            papel.Clear(Color.White);
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            btnBorrar.Enabled = false;

        }

        private void btnDibujar_Click_1(object sender, EventArgs e)
        {
            //se llama al metodo de la clase triangulo
            triangulo.dibujar();
            btnBorrar.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
        }
    }
}

