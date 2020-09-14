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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus();
            bool rest = false;
            if (rest == false)
            {
                button10.Enabled = false;
            }

        }
        bool x = false;
        bool o = true;

        public void Circulos()
        {
            
            if (uno.Text.Equals("O") && dos.Text.Equals("O") && tres.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
            }

            if (cuatro.Text.Equals("O") && cinco.Text.Equals("O") && seis.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
            }

            if (siete.Text.Equals("O") && ocho.Text.Equals("O") && nueve.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
            }

            if (uno.Text.Equals("O") && cuatro.Text.Equals("O") && siete.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
            }

            if (dos.Text.Equals("O") && cinco.Text.Equals("O") && ocho.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
            }

            if (tres.Text.Equals("O") && seis.Text.Equals("O") && nueve.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
            }

            if (uno.Text.Equals("O") && cinco.Text.Equals("O") && nueve.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
            }


            if (tres.Text.Equals("O") && cinco.Text.Equals("O") && siete.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
            }


        }


        public void Equis()
        {
            if (uno.Text.Equals("X") && dos.Text.Equals("X") && tres.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
                Application.Restart();
            }

            if (cuatro.Text.Equals("X") && cinco.Text.Equals("X") && seis.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
            }

            if (siete.Text.Equals("X") && ocho.Text.Equals("X") && nueve.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
            }
            
            if (uno.Text.Equals("X") && cuatro.Text.Equals("X") && siete.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
            }

            if (dos.Text.Equals("X") && cinco.Text.Equals("X") && ocho.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
            }

            if (tres.Text.Equals("X") && seis.Text.Equals("X") && nueve.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
            }

            
            if (uno.Text.Equals("X") && cinco.Text.Equals("X") && nueve.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + equis);
            }


            if (tres.Text.Equals("X") && cinco.Text.Equals("X") && siete.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
            }


        }
        public void sendN(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;

            if (x == true)
            {
                btn.Text = "X";
                x = false;
                o = true;
                btn.Enabled = false;
                radioButton1.Checked = true;
            }
            else
            {
                btn.Text = "O";
                o = false;
                x = true;
                btn.Enabled = false;
                radioButton2.Checked = true;
            }
            this.Circulos();
            this.Equis();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string equis = "";
        string circulo = "";
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Focus();
            textBox2.Visible = true;
            button2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            equis = textBox1.Text;
            radioButton1.Text = equis;
            circulo = textBox2.Text;
            radioButton2.Text = circulo;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            uno.Enabled = true;
            dos.Enabled = true;
            tres.Enabled = true;
            cuatro.Enabled = true;
            cinco.Enabled = true;
            seis.Enabled = true;
            siete.Enabled = true;
            ocho.Enabled = true;
            nueve.Enabled = true;
            button10.Enabled = true;


        }


    }
}

