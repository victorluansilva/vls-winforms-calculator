namespace Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            int valorX = int.Parse(inputTextX.Text);
            int valorY = int.Parse(inputTextY.Text);

            int operacao = valorX + valorY;

            string formatoSaida = "Resultado da operação entre " + valorX + "e " +
                    valorY + " foi igual á: " + operacao;

            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;

        }
    }
}
