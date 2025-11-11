using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_calculator.Models
{
    public class CalculatorModel : ICalculatorModel
    {
        public double Sum(double x, double y) => x + y;

        public double Subtract(double x, double y) => x - y;

        public double Multiply(double x, double y) => x * y;

        public double Divide(double x, double y)
        {

            if (y == 0)
            {
                return double.NaN;
            }
            return x / y;
        }

        public double SquareOfX(double x) => x * x;

        public double SquareRootOfX(double x)
        {

            if (x < 0)
            {
                return double.NaN;
            }

            return Math.Sqrt(x);
        }

        public double PercentageXofY(double x, double y) => (x / 100) * y;

        public double ToBinary(double x)
        {
            long numero = (long)x;
            if (numero < 0) return double.NaN;
            if (numero == 0) return 0;

            double resultadoBinario = 0;
            double multiplicador = 1;

            while (numero > 0)
            {
                resultadoBinario += (numero % 2) * multiplicador;
                numero /= 2;
                multiplicador *= 10;
            }
            return resultadoBinario;
        }

        public double XRaisedToThePowerOfY(double x, double y)
        {
            if (y == 0) return 1.0;

            double resultado = 1.0;
            int potencia = (int)Math.Abs(y);

            for (int i = 0; i < potencia; i++)
            {
                resultado *= x;
            }

            if (y < 0)
            {
                return 1.0 / resultado;
            }
            return resultado;
        }
    }
}
