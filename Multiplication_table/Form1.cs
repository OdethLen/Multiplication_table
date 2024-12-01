

namespace Multiplication_table
{
    public partial class Form1 : Form
    {
        int number;
        public Form1()
        {
            InitializeComponent();
            number = 0;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtNumber.Text, out number))
            {
                // Generar y mostrar la tabla de multiplicar
                txtMultiplicationTable.Text = PrintTable(number, 1);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private string PrintTable (int number, int multiplier)
        {
            if (multiplier > 10)
            {
                return ""; 
            }

            string line = number + " x " + multiplier + " = " + (number * multiplier) + "\r\n";

            return line + PrintTable(number, multiplier + 1);
        }
    }
}
