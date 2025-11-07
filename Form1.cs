using Exemplo.Classes;
using System.Security.Cryptography;

namespace Exemplo
{
    public partial class Form1 : Form
    {
        Operacoes op;
        public Form1()
        {
            InitializeComponent();
            op = new Operacoes();

        }

        public void setInputs()
        {
            op.setXFromInput(double.Parse(inputTextX.Text));
            op.setYFromInput(double.Parse(inputTextY.Text));
        }

        public void cleanInputs()
        {

        }
        public void printResult(double x, double y, string operacao, double result)
        {
            string formatoSaida = x + " " + operacao + " " + y + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();
        }

        private void onSomaClick(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            op.setXFromInput(double.Parse(inputTextX.Text));
            labelResult.Visible = true;
            labelResult.Text = op.toBinarie().ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            setInputs();
            printResult(op.getX(),op.getY(),"",op.xRaisedByPowerOfY());
        }
    }
}
