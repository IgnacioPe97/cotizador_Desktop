using Fahrenheit451;
using Celsius;
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
            double.TryParse(txb_Farenheit.Text, out valor);
            Fahrenheit farenheit = new Fahrenheit(valor);
            Kelvin kelvin = new Kelvin();
            Celsius celsius = new Celsius();

        }
    }
}