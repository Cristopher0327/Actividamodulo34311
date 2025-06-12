using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class frmaconversiones : Form
    {
        public frmaconversiones()
        {
            InitializeComponent();
        }

        private void btconvertir_Click(object sender, EventArgs e)
        {
            if (cmbde.SelectedItem.ToString() == "Centimetro" & cmba.SelectedItem.ToString() == "Centimetro")
            {
                int Conversion;
                Conversion = int.Parse(txtvalor.Text) * 1;
                txtresultado.Text = Conversion.ToString();
            }
            else
                 if (cmbde.SelectedItem.ToString() == "Centimetro" & cmba.SelectedItem.ToString() == "Metro")
            {
                double Conversion;
                Conversion = int.Parse(txtvalor.Text) * 0.01;
                txtresultado.Text = Conversion.ToString();



            }
            else
                if (cmbde.SelectedItem.ToString() == "Centimetro" & cmba.SelectedItem.ToString() == "Pulgadas")
            {
                double Conversion;
                Conversion = int.Parse(txtvalor.Text) * 0.3937;
                txtresultado.Text = Conversion.ToString();
            }
            else
                 if (cmbde.SelectedItem.ToString() == "Metro" & cmba.SelectedItem.ToString() == "Centimetro")
            {
                int Conversion;
                Conversion = int.Parse(txtvalor.Text) * 100;
                txtresultado.Text = Conversion.ToString();
            }
            else
                 if (cmbde.SelectedItem.ToString() == "Metro" & cmba.SelectedItem.ToString() == "Metro")
            {
                double Conversion;
                Conversion = int.Parse(txtvalor.Text) * 0.01;
                txtresultado.Text = Conversion.ToString();



            }
            else
                if (cmbde.SelectedItem.ToString() == "Metro" & cmba.SelectedItem.ToString() == "Pulgadas")
            {
                double Conversion;
                Conversion = int.Parse(txtvalor.Text) * 0.3937;
                txtresultado.Text = Conversion.ToString();
            }
            
                  if (cmbde.SelectedItem.ToString() == "Pulgadas" & cmba.SelectedItem.ToString() == "Centimetro")
            {
                double Conversion;
                Conversion = int.Parse(txtvalor.Text) * 2.54;
                txtresultado.Text = Conversion.ToString();
            }
            else
                 if (cmbde.SelectedItem.ToString() == "Pulgadas" & cmba.SelectedItem.ToString() == "Metro")
            {
                double Conversion;
                Conversion = int.Parse(txtvalor.Text) * 0.0254;
                txtresultado.Text = Conversion.ToString();



            }
            else
                if (cmbde.SelectedItem.ToString() == "Metro" & cmba.SelectedItem.ToString() == "Pulgadas")
            {
                double Conversion;
                Conversion = int.Parse(txtvalor.Text) * 39.3701;
                txtresultado.Text = Conversion.ToString();
            }
        }

        private void frmaconversiones_Load(object sender, EventArgs e)
        {

        }
    }
}
