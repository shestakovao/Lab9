using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte operation = 0;
            int X = 0;
            int Y = 0;
            double result = 0;
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.Write("Введите целое число X=");
            bool conditionError = true;
            try
            {
                X = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conditionError = false;
            }

            if (conditionError)
            {
                Console.Write("Введите целое число Y=");
                try
                {
                    Y = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    conditionError = false;
                }
            }

            if (conditionError)
            {
                Console.Write("Введите код операции\n\t1 - сложение\n\t2 - вычитание\n\t3 - произведение\n\t4 - частное\nВаш выбор:");
                try
                {
                    operation = Convert.ToByte(Console.ReadLine());
                    if ((operation > 4) || (operation < 1))
                    {

                        Console.WriteLine("Нет операции с указанным номером");
                        conditionError = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    conditionError = false;
                }
            }

            if (conditionError)
            {
                try
                {
                    switch (operation)
                    {
                        case 1:
                            {
                                result = X + Y;
                                break;
                            }
                        case 2:
                            {
                                result = X - Y;
                                break;
                            }
                        case 3:
                            {
                                result = X * Y;
                                break;
                            }
                        case 4:
                            {
                                result = X / Y;//почему то без целочисленного деление не хочет отлавливать деление на ноль
                                result = (double)X / Y;
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    conditionError = false;
                }
            }



            if (conditionError)
            {
                Console.WriteLine("Результат = {0}", result);
            }

            Console.ReadKey();
        }
    }
}
