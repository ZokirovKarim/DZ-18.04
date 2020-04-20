using System;
using System.Collections.Generic;

namespace DZ18._04
{
    class Program
    {
        delegate T Operation<T>(T x, T y);
        static void Main(string[] args)
        {
            bool qqq = true;
            while (qqq)
            {

                Console.WriteLine("" +
                "1.+\n" +
                "2.-\n" +
                "3.*\n" +
                "4./\n"+
                "5.Выход \n");
                string cal = Console.ReadLine();
                switch (cal)
                {
                    case "1":
                        {
                            Console.WriteLine("Введите свой первый номер");
                            double x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите свой второй номер");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Operation<double> mult = Calculator<double>.Plus<double>;
                            double result = mult.Invoke(x, y);
                            Console.WriteLine(result);
                        }; break;
                    case "2":
                        {
                            Console.WriteLine("Введите свой первый номер");
                            double x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите свой второй номер");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Operation<double> mult = Calculator<double>.Minus<double>;
                            double result = mult.Invoke(x, y);
                            Console.WriteLine(result);


                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("Введите свой первый номер");
                            double x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите свой второй номер");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Operation<double> mult = Calculator<double>.Multiply<double>;
                            double result = mult.Invoke(x, y);
                            Console.WriteLine(result);


                        }
                        break;
                    case "4":
                        {
                            Console.WriteLine("Введите свой первый номер");
                            double x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите свой второй номер");
                            double y = Convert.ToDouble(Console.ReadLine());
                            if (x != 0 && y != 0)
                            {

                                Operation<double> mult = Calculator<double>.Divide<double>;
                                double result = mult.Invoke(x, y);
                                Console.WriteLine(result);
                            }
                            else
                            {
                                Console.WriteLine("Ноль не делится на число");
                            }



                        }
                        break;
                    case "5": qqq = false; break;


                }
            }

        }
    }

    class Calculator<T>
    {
        public static T Plus<T>(T x, T y)
        {
            return (dynamic)x + (dynamic)y;
        }
        public static T Minus<T>(T x, T y)
        {
            return (dynamic)x - (dynamic)y;

        }
        public static T Multiply<T>(T x, T y)
        {
            return (dynamic)x * (dynamic)y;


        }
        public static T Divide<T>(T x, T y)
        {
            return (dynamic)x / (dynamic)y;
        }

    }

}
