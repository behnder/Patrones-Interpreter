using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Interpreter
{
    public class Context
    {
        private Stack<IExpression> expressionsStack = new Stack<IExpression>();
        private Stack<string> operatorsStack = new Stack<string>();

        //2+9-5

        public int InsertExpression(string expressions)
        {
            for (int i = 0; i < expressions.Length; i++)
            {
                switch (expressions[i].ToString())
                {
                    case "+":
                        operatorsStack.Push(expressions[i].ToString());
                        break;
                    case "-":
                        operatorsStack.Push(expressions[i].ToString());
                        break;
                    default:
                        if (Int32.TryParse(expressions[i].ToString(), out int number))
                        {
                            IExpression expression = new NumberExpression(number);
                            expressionsStack.Push(expression);
                        }
                        break;
                }
                if (operatorsStack.Count == 1 && expressionsStack.Count == 2)
                {
                    IExpression rightExpression = null;
                    IExpression leftExpression = null;
                    switch (operatorsStack.Pop())
                    {
                        case "+":
                            rightExpression = expressionsStack.Pop();
                            leftExpression = expressionsStack.Pop();
                            IExpression plusExpression = new PlusExpression(leftExpression, rightExpression);

                            expressionsStack.Push(plusExpression);


                            break;
                        case "-":
                            rightExpression = expressionsStack.Pop();
                            leftExpression = expressionsStack.Pop();
                            IExpression minusExpression = new MinusExpression(leftExpression, rightExpression);

                            expressionsStack.Push(minusExpression);

                            break;
                    }
                }
            }

            return expressionsStack.Pop().interpret();
        }

    }
}
