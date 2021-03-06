using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Interpreter
{
    public class PlusExpression : IExpression
    {
        public IExpression LeftExpression { get; set; }
        public IExpression RightExpression { get; set; }

        public PlusExpression(IExpression leftExpression, IExpression rightExpression)
        {
            LeftExpression = leftExpression;
            RightExpression = rightExpression;
        }



        public int interpret()
        {
            return LeftExpression.interpret() + RightExpression.interpret();
        }
    }
}
