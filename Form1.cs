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
        private bool ValidarEConfigurarInputs(bool apenasX = false)
        {
            bool xValido = double.TryParse(inputTextX.Text, out double x);
            bool yValido = true;
            double y = 0;

            if (!apenasX)
            {
                yValido = double.TryParse(inputTextY.Text, out y);
            }

            if (xValido && yValido)
            {
                op.setXFromInput(x);
                op.setYFromInput(y);
                return true;
            }
            else
            {
                labelOutput.Visible = true;
                labelOutput.Text = "Erro de entrada!";
                labelResult.Visible = true;
                labelResult.Text = "Verifique os números";
                return false;
            }
        }
        public void printResult(string operacaoFormatada, double result)
        {
            labelOutput.Visible = true;
            labelOutput.Text = operacaoFormatada;
            labelResult.Visible = true;
            labelResult.Text = result.ToString(); 
        }
        public void printResultString(string operacaoFormatada, string result)
        {
            labelOutput.Visible = true;
            labelOutput.Text = operacaoFormatada;
            labelResult.Visible = true;
            labelResult.Text = result;
        }
        private void ExecutarOperacao(string tipoOperacao)
        {
            bool necessitaApenasX = (tipoOperacao == "DOBRO_X" || tipoOperacao == "RAIZ_X" || tipoOperacao == "BINARIO_X");

            if (!ValidarEConfigurarInputs(necessitaApenasX))
            {
                return;
            }

            double result = 0;
            string formatoSaida = "";
            double x = op.getX();
            double y = op.getY();

            switch (tipoOperacao)
            {
                case "SOMA":
                    result = op.sum();
                    formatoSaida = $"{x} + {y} =";
                    break;
                case "SUB":
                    result = op.subtract();
                    formatoSaida = $"{x} - {y} =";
                    break;
                case "MULT":
                    result = op.multiply();
                    formatoSaida = $"{x} * {y} =";
                    break;
                case "DIV":
                    result = op.devide();
                    formatoSaida = $"{x} / {y} =";
                    break;
                case "DOBRO_X": 
                    result = op.squareOfX();
                    formatoSaida = $"{x}² =";
                    break;
                case "RAIZ_X": 
                    result = op.squareRootOfX();
                    formatoSaida = $"√{x} =";
                    break;
                case "PCT_XY":
                    result = op.percentageXofY();
                    formatoSaida = $"{x}% de {y} =";
                    break;
                case "POT_XY":
                    result = op.xRaisedToThePowerOfY();
                    formatoSaida = $"{x} ^ {y} =";
                    break;
                case "BINARIO_X":
                    string binario = op.toBinaryString();
                    formatoSaida = $"{x} em binário é:";
                    printResultString(formatoSaida, binario);
                    return;
            }

            printResult(formatoSaida, result);
        }

        //Método dos botões

        private void onSomaClick(object sender, EventArgs e)
        {
            ExecutarOperacao("SOMA");
        }

        private void onSubClick(object sender, EventArgs e)
        {
            ExecutarOperacao("SUB");
        }

        private void onMultiply(object sender, EventArgs e)
        {
            ExecutarOperacao("MULT");
        }

        private void onDivideClick(object sender, EventArgs e)
        {
            ExecutarOperacao("DIV");
        }

        public void onSquaredClick(object sender, EventArgs e)
        {
            ExecutarOperacao("DOBRO_X");
        }

        public void onSquareRootClick(object sender, EventArgs e)
        {
            ExecutarOperacao("RAIZ_X");
        }

        public void onPercentageClick(object sender, EventArgs e)
        {
            ExecutarOperacao("PCT_XY");
        }

        public void onToBinarieClick(object sender, EventArgs e)
        {
            ExecutarOperacao("BINARIO_X");
        }

        public void onXRaisedToY(object sender, EventArgs e)
        {
            ExecutarOperacao("POT_XY");
        }
    }
}
