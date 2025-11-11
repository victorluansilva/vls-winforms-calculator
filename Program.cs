using System;
using System.Windows.Forms;
using winform_calculator.Models;
using winform_calculator.Presenters;
using winform_calculator.Views;
using static System.Windows.Forms.DataFormats;

namespace winform_calculator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ICalculatorModel model = new CalculatorModel();
            MainScreen view = new MainScreen();
            CalculatorPresenter presenter = new CalculatorPresenter(model, view);

            Application.Run(view);
        }
    }
}