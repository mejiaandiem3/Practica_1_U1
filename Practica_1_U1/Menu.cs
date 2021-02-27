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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //se cierra el menu
            this.Close();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            //se llama el formulario y se inicia
            Form Formulario1 = new Ejercicio1();
            Formulario1.Show();
            MessageBox.Show("Este´programa te permite crear un trinagulo rectangulo con las medidas que ingreses.", "Instrucciones");
            MessageBox.Show("Ingresa los valores y despues dibujalos, si te equivocaste puedes borrar la figura y agregar valores nuevos.", "Instrucciones");
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            //se llama el formulario y se inicia
            Form Formulario1 = new Ejercicio2();
            Formulario1.Show();
            MessageBox.Show("En este rograma puedes jugar con un amigo al JUEGO DEL GATO.", "Instrucciones");
            MessageBox.Show("Primero tienes que dibujar el tablero para habilitar las  demas opciones.", "Instrucciones:");
            MessageBox.Show("Una vez habilitado el tablero seleccionas X o O dependiendo cual quieres ser, ya solo queda poner la X o la O en el lugar que quieras.", "Instrucciones:");
            MessageBox.Show("En caso de empatar daras click en el boton reiniciar para jugar de nuevo, y cuando te aburras daras click en el boton borrar para borrar todo, si deseas volver a jugar  vuelve a dibujar el tablero.", "Instrucciones:");
        }

        private void lblCreditos_Click(object sender, EventArgs e)
        {
            //Se llama el formulario y se inicia
            Form Formulario1 = new creditos();
            Formulario1.Show();
            //Mensaje de derechos de autor
            MessageBox.Show("Gracias Por Utilizar Nuestro Programa.", "Copyright Oficial ©:");
        }
    }
}
