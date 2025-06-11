using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGeneral_Click(object sender, EventArgs e)
        {
            int longitudPass = int.Parse(tbLongitud.Text);

            Random random = new Random();

            string cadena = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+";

            char[] password = new char[longitudPass];

            for (int i = 0; i < longitudPass; i++)
            {
                int indice = random.Next(cadena.Length);
                password[i] = cadena[indice];

            }

            string NuevoPass = new string(password);

            tbGenerada.Text = NuevoPass;


        }

    }

}
