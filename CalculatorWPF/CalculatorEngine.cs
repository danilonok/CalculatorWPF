using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPF
{
    public class CalculatorEngine
    {

        public double Answer;
        public double Operand1;
        public double Operand2;

        public Operations SelectedOperation;

        public double LastOperand;

        public void Sum()
        {
            Answer = Operand1 + Operand2;
            Operand1 = Answer;
        }
        public void Substract()
        {
            Answer = Operand1 - Operand2;
            Operand1 = Answer;
        }
        public void Multiplication()
        {
            Answer = Operand1 * Operand2;
            Operand1 = Answer;
        }
        public void Division()
        {
            Answer = Operand1 / Operand2;
            Operand1 = Answer;
        }
        public void Sqrt()
        {
            Answer = Math.Sqrt(Operand1);
        }
        public void Power2()
        {
            Answer = Math.Pow(Operand1, 2);
        }
        public void OneByX()
        {
            Answer = 1 / Operand1;
        }

        public void Calculate()
        {
            switch (SelectedOperation)
            {
                case Operations.Sum: Sum(); break;
                case Operations.Division: Division(); break;
                case Operations.Substraction: Substract(); break;
                case Operations.Multiplication: Multiplication(); break;
            }

        }
        public void Clear()
        {
            Answer = 0;
            Operand1 = 0;
            Operand2 = 0;
        }
    }
    public enum Operations
    {
        None,
        Sum,
        Substraction,
        Multiplication,
        Division,
        Sqrt,
        Power2,
        oneDivX
    }
}
