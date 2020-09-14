using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
{
    public partial class Form1 : Form
    {

        TresEnRaya tresEnRaya = new TresEnRaya();
        private int[,] matriz = new int[2, 2];
        private int ganador = -1;

        public Form1()
        {
            InitializeComponent();
            tresEnRaya.inicializarPartida();
            matriz = tresEnRaya.Matriz;

        }

        private void comprobarGanador()
        {
            int[] ultMov = tresEnRaya.UltimoMovimientoMaquina;

            if (ultMov[0] == 0 && ultMov[1] == 0)
                button1.Text = "0";
            if (ultMov[0] == 0 && ultMov[1] == 1)
                button2.Text = "0";
            if (ultMov[0] == 0 && ultMov[1] == 2)
                button3.Text = "0";

            if (ultMov[0] == 1 && ultMov[1] == 0)
                button6.Text = "0";
            if (ultMov[0] == 1 && ultMov[1] == 1)
                button5.Text = "0";
            if (ultMov[0] == 1 && ultMov[1] == 2)
                button4.Text = "0";


            if (ultMov[0] == 2 && ultMov[1] == 0)
                button9.Text = "0";
            if (ultMov[0] == 2 && ultMov[1] == 1)
                button8.Text = "0";
            if (ultMov[0] == 2 && ultMov[1] == 2)
                button7.Text = "0";

            if (ganador == 0) MessageBox.Show("GANASTE");
             

            if (ganador == 1) MessageBox.Show("PERDISTE");
        

            if(ganador==-1 && tresEnRaya.tableroLleno())
                MessageBox.Show("EMPATE"); 


        }

        private void eventoBotones( int x, int y,Button boton)
        {
            if (matriz[x, y] == -1)
            {
                tresEnRaya.seleccionarPosicion(x,y);
                ganador = tresEnRaya.ganaPartida();
                comprobarGanador();
                boton.Text = "X";
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventoBotones(0, 0, button1);
       }

        private void button2_Click(object sender, EventArgs e)
        {
            eventoBotones(0, 1, button2);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eventoBotones(0, 2, button3);
   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            eventoBotones(1, 0, button6);
     
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eventoBotones(1, 1, button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eventoBotones(1,2, button4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            eventoBotones(2, 0, button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            eventoBotones(2, 1, button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
        eventoBotones(2, 2, button7);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tresEnRaya = new TresEnRaya();
            tresEnRaya.inicializarPartida();
            matriz = tresEnRaya.Matriz;
            ganador = -1;

            label1.Text = button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = String.Empty;
            
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }

}
