﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class Calculator
    {
        public float Add(float number1, float number2) => number1 + number2;
        public float Subtract(float number1, float number2) => number1 - number2;
        public float Multiply(float number1, float number2) => number1 * number2;
        public float Divide(float number1, float number2)
        {
            if(number2 == 0)
            {
                throw new ArgumentException("Can't divide by zero!");
            }
            return number1 / number2;
        }
    }
}
