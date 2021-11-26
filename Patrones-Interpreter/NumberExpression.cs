using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Interpreter
{
    public class NumberExpression : IExpression
    {

        public int Value { get; set; }
        public NumberExpression(int value)
        {
            Value = value;
        }

        public int interpret()
        {
            return Value;
        }
    }
}
