using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_calculator.Views
{
    public interface ICalculatorView
    {
        string X_Value { get; }
        string Y_Value { get; }

        void SetOperation(string operation);
        void SetResult(string result);
        void ShowError(string title, string message);

        void SetYVisibility(bool isVisible);
        void ClearUI();

        event EventHandler ClearClick;

        event EventHandler SomaClick;
        event EventHandler SubClick;
        event EventHandler MultClick;
        event EventHandler DivClick;
        event EventHandler DobroClick;
        event EventHandler RaizClick;
        event EventHandler PorcentClick;
        event EventHandler BinarioClick;
        event EventHandler PotenciaClick;
    }
}
