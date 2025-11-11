using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winform_calculator.Models;
using winform_calculator.Views;

namespace winform_calculator.Presenters
{
    public class CalculatorPresenter
    {
        private readonly ICalculatorModel _model;
        private readonly ICalculatorView _view;

        public CalculatorPresenter(ICalculatorModel model, ICalculatorView view)
        {
            _model = model;
            _view = view;

            _view.SomaClick += OnSomaClick;
            _view.SubClick += OnSubClick;
            _view.MultClick += OnMultClick;
            _view.DivClick += OnDivClick;
            _view.DobroClick += OnDobroClick;
            _view.RaizClick += OnRaizClick;
            _view.PorcentClick += OnPorcentClick;
            _view.BinarioClick += OnBinarioClick;
            _view.PotenciaClick += OnPotenciaClick;
            _view.ClearClick += OnClearClick;
        }


        private bool TryParseInputs(out double x, out double y, bool apenasX = false)
        {
            x = 0; y = 0;
            if (!double.TryParse(_view.X_Value, out x))
            {
                _view.ShowError("Erro de Entrada", "Valor de X inválido.");
                return false;
            }

            if (!apenasX && !double.TryParse(_view.Y_Value, out y))
            {
                _view.ShowError("Erro de Entrada", "Valor de Y inválido.");
                return false;
            }
            return true;
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            _view.ClearUI();
        }

        private void OnSomaClick(object sender, EventArgs e)
        {
            _view.SetYVisibility(true); if (TryParseInputs(out double x, out double y))
            {
                double result = _model.Sum(x, y);
                _view.SetOperation($"{x} + {y} =");
                _view.SetResult(result.ToString("N2"));
            }
        }

        private void OnSubClick(object sender, EventArgs e)
        {
            _view.SetYVisibility(true);
            if (TryParseInputs(out double x, out double y))
            {
                double result = _model.Subtract(x, y);
                _view.SetOperation($"{x} - {y} =");
                _view.SetResult(result.ToString("N2"));
            }
        }

        private void OnMultClick(object sender, EventArgs e)
        {
            _view.SetYVisibility(true);
            if (TryParseInputs(out double x, out double y))
            {
                double result = _model.Multiply(x, y);
                _view.SetOperation($"{x} * {y} =");
                _view.SetResult(result.ToString("N2"));
            }
        }

        private void OnDivClick(object sender, EventArgs e)
        {
            _view.SetYVisibility(true);
            if (TryParseInputs(out double x, out double y))
            {
                double result = _model.Divide(x, y);
                if (double.IsNaN(result))
                {
                    _view.ShowError("Erro de Cálculo", "Divisão por zero.");
                }
                else
                {
                    _view.SetOperation($"{x} / {y} =");
                    _view.SetResult(result.ToString("N2"));
                }
            }
        }

        private void OnDobroClick(object sender, EventArgs e)
        {
            _view.SetYVisibility(false); if (TryParseInputs(out double x, out _, apenasX: true))
            {
                double result = _model.SquareOfX(x);
                _view.SetOperation($"{x}² =");
                _view.SetResult(result.ToString("N2"));
            }
        }

        private void OnRaizClick(object sender, EventArgs e)
        {
            _view.SetYVisibility(false); if (TryParseInputs(out double x, out _, apenasX: true))
            {
                double result = _model.SquareRootOfX(x);
                if (double.IsNaN(result))
                {
                    _view.ShowError("Erro de Cálculo", "Raiz de negativo.");
                }
                else
                {
                    _view.SetOperation($"√{x} =");
                    _view.SetResult(result.ToString("N2"));
                }
            }
        }

        private void OnPorcentClick(object sender, EventArgs e)
        {
            _view.SetYVisibility(true);
            if (TryParseInputs(out double x, out double y))
            {
                double result = _model.PercentageXofY(x, y);
                _view.SetOperation($"{x}% de {y} =");
                _view.SetResult(result.ToString("N2"));
            }
        }

        private void OnBinarioClick(object sender, EventArgs e)
        {
            _view.SetYVisibility(false); if (TryParseInputs(out double x, out _, apenasX: true))
            {
                double result = _model.ToBinary(x);
                if (double.IsNaN(result))
                {
                    _view.ShowError("Erro de Cálculo", "Inválido p/ binário.");
                }
                else
                {
                    _view.SetOperation($"{x} em binário:");
                    _view.SetResult(result.ToString("N0"));
                }
            }
        }

        private void OnPotenciaClick(object sender, EventArgs e)
        {
            _view.SetYVisibility(true);
            if (TryParseInputs(out double x, out double y))
            {
                double result = _model.XRaisedToThePowerOfY(x, y);
                _view.SetOperation($"{x} ^ {y} =");
                _view.SetResult(result.ToString("N2"));
            }
        }

    }
}
