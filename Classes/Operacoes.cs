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
        public Operacoes()
        {
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

        //Operações

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
            return Math.Round(Math.Sqrt(this.x), 5);
        }

        public double percentageOfXintoY()
        {
            return Math.Round(((this.x / 100) * this.y),5);
        }

        public int toBinarie()
        {
            long value = (long) this.x;

            if (value <= 0)
            {
                return 0000;
            }
            else
            {
                string restos = "";
                while (value > 0) 
                {
                    restos += value % 2;
                    value = value / 2; //condição de parada
                }
                string resultadoBinario = "";
                for (int i = restos.Length-1; i >= 0 ; i--)
                {
                    resultadoBinario += restos[i];
                }
                return int.Parse(resultadoBinario);
            }


        }

        public double xRaisedByPowerOfY()
        {
            int count = 0;
            double result = this.x;

            while (count < (this.y - 1))
            {
                result *= this.x;
                count++;
            }

            return result;
        }
    }
}
