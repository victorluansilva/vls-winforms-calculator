using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Classes
{
    internal class Operacoes
    {
        double x, y;
        public Operacoes() {
            x = 0; y = 0;
        }

        //Getters e Setters

        public void setXFromInput(double x)
        {
            this.x = x;
        }

        public double getX()
        {
            return this.x;
        }

        public void setYFromInput(double y)
        {
            this.y = y;
        }

        public double getY()
        {
            return this.y;
        }

        // Operações

        public double sum()
        {
            return this.x + this.y;
        }

        public double subtract()
        {
            return this.x - this.y;
        }

        public double multiply()
        {
            return this.x * this.y;
        }

        public double devide()
        {
            if (this.y == 0)
            {
                return 0;
            }
            else
            {
                return this.x / this.y;
            }
        }

        public double squareOfX()
        {
            return (this.x * this.x);
        }

        public double squareRootOfX()
        {
            if (this.x < 0)
            {
                return 0;
            }
            return Math.Sqrt(this.x);
        }

        public double percentageXofY()
        {
            return (this.x / 100) * this.y;
        }

        public string toBinaryString()
        {
            return Convert.ToString((long)this.x, 2);
        }

        public double xRaisedToThePowerOfY()
        {
            return Math.Pow(this.x, this.y);
        }

    }
}
