using Fahrenheit451;
using Celsius;
using KelvinClass = Kelvin.Kelvin;
using CelsiusClass = Celsius.Celsius;
using Kelvin;

namespace ConversorTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Farenheit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double num;
            if (!double.TryParse(txb_Farenheit.Text, out num))
            {
                MessageBox.Show("Debe ingresar un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb_Celsius.Focus();
                e.Cancel = true;
            }
        }

        private void txt_Celsius_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double num;
            if (!double.TryParse(txb_Celsius.Text, out num))
            {
                MessageBox.Show("Debe ingresar un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb_Celsius.Focus();
                e.Cancel = true;
            }


        }

        private void txt_Kelvin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double num;
            if (!double.TryParse(txb_Kelvin.Text, out num))
            {
                MessageBox.Show("Debe ingresar un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb_Kelvin.Focus();
                e.Cancel = true;
            }
        }

        private void btn_Farenheit_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(txb_Farenheit.Text, out valor))
            {
                Fahrenheit farenheit = new Fahrenheit(valor);
                txt_FarToFar.Text = Convert.ToString(farenheit.GetTemperatura());
                KelvinClass kelvin = (KelvinClass)farenheit;
                txt_FarToKel.Text = Convert.ToString(kelvin.GetTemperatura());
                CelsiusClass celsius = (CelsiusClass)farenheit;
                txt_FarToCel.Text = Convert.ToString(celsius.GetTemperatura());
            }




        }

        private void txb_Farenheit_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txt_Farenheit.Text, out double tempFar))
            {

            }
        }
    }
}