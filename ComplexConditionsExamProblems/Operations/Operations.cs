using System;

namespace Operations
{
    class Operations
    {
        static void Main(string[] args)
        {
            decimal n1 = decimal.Parse(Console.ReadLine());
            decimal n2 = decimal.Parse(Console.ReadLine());
            string nOperator = Console.ReadLine();
            decimal rezult = 0.0m;
            string output = string.Empty;

            if (n2 == 0 && (nOperator.Equals("/") || nOperator.Equals("%")))
            {
                output = string.Format($"Cannot divide {n1} by zero");
            }
            else if (nOperator == "+" || nOperator == "-" || nOperator == "*")
            {
                if (nOperator == "+")
                {
                    rezult = n1 + n2;
                }
                else if (nOperator == "-")
                {
                    rezult = n1 - n2;
                }
                else if (nOperator == "*")
                {
                    rezult = n1 * n2;
                }
                output = string.Format("{0} {1} {2} = {3} - {4}",
                                        n1, nOperator, n2, rezult,
                                        rezult  % 2 == 0? "even" : "odd");
            }
            else if (nOperator.Equals("/"))
            {
                rezult = n1 / n2;
                output = string.Format("{0} {1} {2} = {3:F2}", n1, nOperator, n2, rezult);
            }
            else if (nOperator.Equals("%"))
            {
                rezult = n1 % n2;
                output = string.Format("{0} {1} {2} = {3}", n1, nOperator, n2, rezult);
            }

            Console.WriteLine(output);
            //if (n2 != 0)
            //{
            //    if (nOperator == "+")
            //    {
            //        rezult = n1 + n2;

                //        if (rezult % 2 == 0)
                //        {
                //            Console.WriteLine($"{n1} {nOperator} {n2} = {rezult} - even");
                //        }
                //        else
                //        {
                //            Console.WriteLine($"{n1} {nOperator} {n2} = {rezult} - odd");
                //        }
                //    }
                //    else if (nOperator == "-")
                //    {
                //        rezult = n1 - n2;

                //        if (rezult % 2 == 0)
                //        {
                //            Console.WriteLine($"{n1} {nOperator} {n2} = {rezult} - even");
                //        }
                //        else
                //        {
                //            Console.WriteLine($"{n1} {nOperator} {n2} = {rezult} - odd");
                //        }
                //    }
                //    else if (nOperator == "*")
                //    {
                //        rezult = n1 * n2;

                //        if (rezult % 2 == 0)
                //        {
                //            Console.WriteLine($"{n1} {nOperator} {n2} = {rezult} - even");
                //        }
                //        else
                //        {
                //            Console.WriteLine($"{n1} {nOperator} {n2} = {rezult} - odd");
                //        }
                //    }
                //    else if (nOperator == "/")
                //    {
                //        rezult = n1 / n2;
                //        Console.WriteLine($"{n1} {nOperator} {n2} = {rezult:f2}");
                //    }
                //    else if (nOperator == "%")
                //    {
                //        rezult = n1 % n2;
                //        Console.WriteLine($"{n1} {nOperator} {n2} = {rezult}");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Invalid Operator");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine($"Cannot divide {n1} by zero");
                //}
        }
    }
}
