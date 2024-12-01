

namespace Multiplication_table
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtNumber.Text, out number))
            {
                // Generar y mostrar la tabla de multiplicar
                txtMultiplicationTable.Text = PrintTable(number, 1);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un n�mero v�lido.");
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