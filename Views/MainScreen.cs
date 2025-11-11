using System;
using System.Windows.Forms;
using winform_calculator.Views;

namespace winform_calculator
{
    public partial class MainScreen : Form, ICalculatorView
    {
        public MainScreen()
        {
            InitializeComponent();

            this.btnSoma.Click += (s, e) => SomaClick?.Invoke(this, EventArgs.Empty);
            this.btnSub.Click += (s, e) => SubClick?.Invoke(this, EventArgs.Empty);
            this.btnMult.Click += (s, e) => MultClick?.Invoke(this, EventArgs.Empty);
            this.btnDiv.Click += (s, e) => DivClick?.Invoke(this, EventArgs.Empty);
            this.btnDobro.Click += (s, e) => DobroClick?.Invoke(this, EventArgs.Empty);
            this.btnRaiz.Click += (s, e) => RaizClick?.Invoke(this, EventArgs.Empty);
            this.btnPorcent.Click += (s, e) => PorcentClick?.Invoke(this, EventArgs.Empty);

            this.btnBinary.Click += (s, e) => BinarioClick?.Invoke(this, EventArgs.Empty);
            this.btnXPowY.Click += (s, e) => PotenciaClick?.Invoke(this, EventArgs.Empty);
            this.btnClean.Click += (s, e) => ClearClick?.Invoke(this, EventArgs.Empty);
        }

        public string X_Value => this.inputTextX.Text;
        public string Y_Value => this.inputTextY.Text;

        public void SetOperation(string operation)
        {
            this.labelOutput.Visible = true;
            this.labelOutput.Text = operation;
        }

        public void SetResult(string result)
        {
            this.labelResult.Visible = true;
            this.labelResult.Text = result;
        }

        public void SetYVisibility(bool isVisible)
        {

            this.label1.Visible = isVisible;
            this.inputTextY.Visible = isVisible;
        }

        public void ShowError(string title, string message)
        {
            this.labelOutput.Visible = true;
            this.labelResult.Visible = true;
            this.labelOutput.Text = title;
            this.labelResult.Text = message;
        }

        public void ClearUI()
        {
            this.inputTextX.Text = "";
            this.inputTextY.Text = "";
            this.labelOutput.Visible = false;
            this.labelResult.Visible = false;
            this.labelOutput.Text = "";
            this.labelResult.Text = "";
            SetYVisibility(true);
        }


        public event EventHandler SomaClick;
        public event EventHandler SubClick;
        public event EventHandler MultClick;
        public event EventHandler DivClick;
        public event EventHandler DobroClick;
        public event EventHandler RaizClick;
        public event EventHandler PorcentClick;
        public event EventHandler BinarioClick;
        public event EventHandler PotenciaClick;
        public event EventHandler ClearClick;

    }
}