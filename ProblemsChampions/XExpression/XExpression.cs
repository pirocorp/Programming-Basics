using System;

namespace XExpression
{
    class XExpression
    {
        static void Main()
        {
            int simbol = Console.Read();

            decimal rezult = 0;
            int exit = '=';

            rezult = Expression(simbol, exit);

            //while (simbol != '=')
            //{
            //    if (simbol == '(')
            //    {
            //        decimal innerRezult = 0;
            //        int innerOperator = '+';
            //        simbol = Console.Read();
            //        while (simbol != ')')
            //        {
            //            if (0 <= simbol - '0' && simbol - '0' <= 9)
            //            {
            //                switch (innerOperator)
            //                {
            //                    case '+': innerRezult += simbol - '0'; break;
            //                    case '-': innerRezult -= simbol - '0'; break;
            //                    case '*': innerRezult *= simbol - '0'; break;
            //                    case '/': innerRezult /= simbol - '0'; break;

            //                }
            //            }
            //            else if (simbol == '+' || simbol == '-' || simbol == '*' || simbol == '/')
            //            {
            //                innerOperator = simbol;
            //            }

            //            simbol = Console.Read();
            //        }
            //        switch (expressionOperator)
            //        {
            //            case '+': rezult += innerRezult; break;
            //            case '-': rezult -= innerRezult; break;
            //            case '*': rezult *= innerRezult; break;
            //            case '/': rezult /= innerRezult; break;

            //        }
            //    }
            //    else if (0 <= simbol - '0' && simbol - '0' <= 9)
            //    {
            //        switch (expressionOperator)
            //        {
            //            case '+': rezult += simbol - '0'; break;
            //            case '-': rezult -= simbol - '0'; break;
            //            case '*': rezult *= simbol - '0'; break;
            //            case '/': rezult /= simbol - '0'; break;

            //        }
            //    }
            //    else if (simbol == '+' || simbol == '-' || simbol == '*'|| simbol == '/')
            //    {
            //        expressionOperator = simbol;
            //    }

            //    simbol = Console.Read();
            //}

            Console.WriteLine($"{rezult:f2}");
        }

        static decimal Expression (int simbol, int exit)
        {
            int expressionOperator = '+';
            decimal rezult = 0;
            while (simbol != exit)
            {
                if (simbol == '(')
                {
                    int innerExit = ')';
                    simbol = Console.Read();
                    decimal innerRezult = Expression(simbol, innerExit); //Recursion
                    switch (expressionOperator)
                    {
                        case '+': rezult += innerRezult; break;
                        case '-': rezult -= innerRezult; break;
                        case '*': rezult *= innerRezult; break;
                        case '/': rezult /= innerRezult; break;
                    }
                }
                else if (0 <= simbol - '0' && simbol - '0' <= 9)
                {
                    switch (expressionOperator)
                    {
                        case '+': rezult += simbol - '0'; break;
                        case '-': rezult -= simbol - '0'; break;
                        case '*': rezult *= simbol - '0'; break;
                        case '/': rezult /= simbol - '0'; break;
                    }
                }
                else if (simbol == '+' || simbol == '-' || simbol == '*' || simbol == '/')
                {
                    expressionOperator = simbol;
                }

                simbol = Console.Read();
            }
            return rezult;
        }
    }
}
