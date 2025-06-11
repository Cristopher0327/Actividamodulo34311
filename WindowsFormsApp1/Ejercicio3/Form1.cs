using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();
        int tiempo;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Correr()
        {
            timer.Interval = 1000;
            tiempo = int.Parse(tbTiempo.Text);
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            Correr();
            timer.Start();
           
            timer.Tick += new EventHandler(Activar);
        }
        public void Activar(object sender, EventArgs e)
        {
            tiempo--;
            LbCuenta.Text = tiempo.ToString();
            if (tiempo == 0)
            {
                timer.Stop();
                btIniciar.Enabled = true;
                MessageBox.Show("Termino el tiempo");
            }

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btIniciar.Enabled = true;
            btStop.Enabled = true;
        }
    }
}