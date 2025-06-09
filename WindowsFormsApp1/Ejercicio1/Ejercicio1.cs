using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, Tabla, Resultado;

            Tabla = int.Parse(textBox1.Text);

            listBox1.Items.Clear();

            for (num = 1; num <= 12; num++) 



            {
                Resultado = num * Tabla;

               listBox1.Items.Add(Tabla+" x "+ num+" = "+Resultado);
         
            }
             
           
        }
         private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();  

            listBox1.Items.Clear();

            textBox1.Focus();

    


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
