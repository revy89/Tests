using System;
using System.Collections.Generic;


namespace PolishNotationCalculator
{
    public class PN
    {
        static public double Calculate(string input)
        {
            double result = Result(input); 
            return result; 
        }
        static private double Result (string input)
        {
            double result=0;
            Stack<string> digits = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (IsDelimeter(input[i]))
                    continue;
                string output = string.Empty;
                if (Char.IsDigit(input[i]))
                {

                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output = input[i] + output;
                        i--;

                        if (i == input.Length) break;
                    }
                    digits.Push(output);
                    i++;
                }
                if (IsOperator(input[i]))
                {
                        result = Counting(digits.Pop(), digits.Pop(), input[i]);
                        digits.Push(Convert.ToString(result));

                }
            }
                return result;
        }

        static private double Counting(string input1, string input2, char operation)
        {
            double result = 0;

                    double a =Convert.ToDouble(input2);
                    double b = Convert.ToDouble(input1);

            switch (operation) 
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = b / a; break;
                        case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
                    }

            return result; 
        }
        static private bool IsDelimeter(char c)
        {
            if ((" ".IndexOf(c) != -1))
                return true;
            return false;
        }
        static private bool IsOperator(char с)
        {
            if (("+-/*^".IndexOf(с) != -1))
                return true;
            return false;
        }
    }
}
