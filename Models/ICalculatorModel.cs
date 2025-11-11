using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_calculator.Models
{
    public interface ICalculatorModel
    {
        double Sum(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
        double SquareOfX(double x);
        double SquareRootOfX(double x);
        double PercentageXofY(double x, double y);
        double ToBinary(double x);
        double XRaisedToThePowerOfY(double x, double y);
    }
}
