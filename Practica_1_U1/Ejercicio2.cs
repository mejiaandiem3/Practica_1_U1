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
    public partial class Ejercicio2 : Form
    {
        public Graphics papel;
        public Ejercicio2()
        {
            InitializeComponent();
        }
        //Metodo JugarPartida
        public void Jugar(Button Gato)
        {
            if (RtnX.Checked == true)
            {
                Gato.ForeColor = Color.Black;
                Gato.Text = "X";
            }
            else
              if (RtnO.Checked == true)
            {
                Gato.ForeColor = Color.Blue;
                Gato.Text = "O";
            }
        }
        //Metodo cambiar turno
        public void Turnos()
        {
            if (RtnO.Checked == true)
            {
                RtnO.Checked = false;
                RtnX.Checked = true;
            }
            else
                if (RtnX.Checked == true)
            {
                RtnX.Checked = false;
                RtnO.Checked = true;
            }
        }
        //Metodo de seleccion de Ganador
        public void Ganador()
        {
            ValidarResultados(btn1.Text, btn2.Text, btn3.Text);
            ValidarResultados(btn4.Text, btn5.Text, btn6.Text);
            ValidarResultados(btn7.Text, btn8.Text, btn9.Text);
            ValidarResultados(btn1.Text, btn5.Text, btn9.Text);
            ValidarResultados(btn3.Text, btn5.Text, btn7.Text);
            ValidarResultados(btn1.Text, btn4.Text, btn7.Text);
            ValidarResultados(btn2.Text, btn5.Text, btn8.Text);
            ValidarResultados(btn3.Text, btn6.Text, btn9.Text);
        }

        //Metodo para limpiar los botnes
            public void Limpiar_Botones()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }

    private void btnSalir_Click(object sender, EventArgs e)
        {
            //se cierra la forma
            this.Close();
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            //Crea un objeto
            Metodos Dibujar = new Metodos();
            Dibujar.DibujarTablero(ref pictureBox1);

            //Obtiene o establece un valor que indica si el control puede responder la interaccion del usuario
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnReiniciar.Enabled = true;
            btnBorrar.Enabled = true;


        }
        //Declaracion de Variables Variables
        int X = 0, O = 0, EM = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            //llamo al metodo jugar
            Jugar(btn1);
            //llama al metodo seleccion de ganador
            Ganador();
            //llama al metod cambiar turnos
            Turnos();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //llamo al metodo jugar
            Jugar(btn2);
            //llama al metodo seleccion de ganador
            Ganador();
            //llama al metod cambiar turnos
            Turnos();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //llamo al metodo jugar
            Jugar(btn3);
            //llama al metodo seleccion de ganador
            Ganador();
            //llama al metod cambiar turnos
            Turnos();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //llamo al metodo jugar
            Jugar(btn4);
            //llama al metodo seleccion de ganador
            Ganador();
            //llama al metod cambiar turnos
            Turnos();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //llamo al metodo jugar
            Jugar(btn5);
            //llama al metodo seleccion de ganador
            Ganador();
            //llama al metod cambiar turnos
            Turnos();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //llamo al metodo jugar
            Jugar(btn6);
            //llama al metodo seleccion de ganador
            Ganador();
            //llama al metod cambiar turnos
            Turnos();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //llamo al metodo jugar
            Jugar(btn7);
            //llama al metodo seleccion de ganador
            Ganador();
            //llama al metod cambiar turnos
            Turnos();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //llamo al metodo jugar
            Jugar(btn8);
            //llama al metodo seleccion de ganador
            Ganador();
            //llama al metod cambiar turnos
            Turnos();
        }
        
        private void btn9_Click(object sender, EventArgs e)
        {
            //llamo al metodo jugar
            Jugar(btn9);
            //llama al metodo seleccion de ganador
            Ganador();
            //llama al metod cambiar turnos
            Turnos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Obtiene o establece un valor que indica si el control puede responder la interaccion del usuario
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnBorrar.Enabled = false;
            btnReiniciar.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.White);
            //Limpia los botones
            Limpiar_Botones();
            //Obtiene o establece un valor que indica si el control puede responder la interaccion del usuario
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnBorrar.Enabled = false;
            btnReiniciar.Enabled = false;
            //Limpia el puntaje
            CX.Text = "0";
            CO.Text = "0";
            CE.Text = "0";

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            {
                //llama al metodo limpiar botones
                Limpiar_Botones();
                //Contador
                EM++;
                //muestra el contador
                CE.Text = Convert.ToString(EM);
            }
        }

        //Metodo de Validar resultados
        public void ValidarResultados(string F1, string F2, string F3)
        {

            if (F1 == "X" && F2 == "X" && F3 == "X")
            {
                MessageBox.Show("Gana el jugador: X","Felicidades");
                X++;
                CX.Text = Convert.ToString(X);
                //Limpia los botones
                Limpiar_Botones();
            }
            else
                if (F1 == "O" && F2 == "O" && F3 == "O")
            {
                MessageBox.Show("Gana el jugador: O","Felicidades");
                O++;
                CO.Text = Convert.ToString(O);
                //Limpiar los botones
                Limpiar_Botones();
            }
           
        }
    }
}
