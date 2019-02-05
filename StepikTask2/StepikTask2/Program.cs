using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepikTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = null;
            string input = null;
            Random rnd = new Random();
            int num = 0;
            int sum = 0;
            int count = 0;
            int ctrl = 0;
            input = Console.ReadLine();
            if (input.IndexOf("*") > 0)
            {
                output = input.Remove(input.IndexOf("*"));
                num = int.Parse(output);
                for (int i = 0; i < output.Length; i++)
                {
                    count = num % 10;
                    if ((num.ToString().Length - 1) % 2 == 1)
                    {
                        sum += count;
                    }
                    else
                    {
                        if (count * 2 > 9)
                        {
                            sum += count * 2 - 9;
                        }
                        else
                        {
                            sum += count * 2;
                        }
                    }
                    if (num.ToString().Length > 1) 
                    num = int.Parse(num.ToString().Remove(num.ToString().Length-1));
                }
                
                for (int i = 0; i < (16 - input.Length); i++)
                {
                    num = rnd.Next(0, 9);
                    output += num;
                    if ((input.Length-2)%2 == 1)
                    {
                        sum += num;
                    }
                    else
                    {
                        if (num * 2 > 9)
                            sum += (num * 2) - 9;
                        else
                            sum += num * 2;
                    }
                }
                
                sum = 10 - sum % 10;
                output += sum;
                Console.WriteLine(output);
            }
            if (input.IndexOf("*")==0)
            {
                output = input.Remove(input.IndexOf("*"),1);              
                num = int.Parse(output);
                input = output;
                //вычисление суммы* заданного окончания
                for (int i = 0; i < output.Length; i++)
                {
                    
                    count = num % 10;
                    if ((num.ToString().Length - 1) % 2 == 1)
                    {
                        sum += count;
                    }
                    else
                    {
                        if (count * 2 > 9)
                        {
                            sum += count * 2 - 9;
                        }
                        else
                        {
                            sum += count * 2;
                        }
                    }
                    if (num.ToString().Length > 1)
                        num = int.Parse(num.ToString().Remove(num.ToString().Length - 1));
                }
                num = rnd.Next(2, 7);
                output = num.ToString();
                for (int i = 0; i < (14 - input.Length); i++)
                {
                    num = rnd.Next(0, 9);
                    output += num;
                    if ((input.Length - 2) % 2 == 1)
                    {
                        sum += num;
                    }
                    else
                    {
                        if (num * 2 > 9)
                            sum += (num * 2) - 9;
                        else
                            sum += num * 2;
                    }
                }
                //Добавить вычисление символа перед определенным окончанием
                //Обращение суммы в кратную 10
                if ((16 - output.Length) % 2 == 1)
                {
                    if ((10 - sum % 10) % 2 == 0)
                    {
                        ctrl = (10 - sum % 10) / 2;
                    }
                    else
                    {
                        ctrl = (19 - sum % 10) / 2;
                    }
                }
                else
                {
                    ctrl = 10 - sum % 10;
                }
                output += ctrl;
                output += input;
                Console.WriteLine(output);
            }
            if (input.Equals("Visa"))
            {
                output += 4;
                for (int i = 0; i < 14; i++)
                {
                    num = rnd.Next(0, 9);
                    output += num;
                    
                    if (i % 2 == 0)
                    {
                        sum += num;
                    }
                    else
                    {
                        if (num * 2 > 9)
                        {
                            sum += (num * 2) - 9;
                        }
                        else
                        {
                            sum += num * 2;
                        }
                    }

                }
            sum += 8;
            sum = 10 - sum % 10;
            output += sum;
            Console.WriteLine(output);
            }
            if (input.Equals("MasterCard"))
            {
                output += 5;
                for (int i = 0; i < 14; i++)
                {
                    num = rnd.Next(0, 9);
                    output += num;
                    
                    if (i % 2 == 0)
                    {
                        sum += num;
                    }
                    else
                    {
                        if (num * 2 > 9)
                        {
                            sum += (num * 2) - 9;
                        }
                        else
                        {
                           sum += num * 2;
                        }
                    }

                }
                sum += 1;
                sum = 10 - sum % 10;
                output += sum;
                Console.WriteLine(output);
                           }
            if (input.Equals("AmericanExpress"))
            {
                output += 3;
                for (int i = 0; i < 11; i++)
                {
                    num = rnd.Next(0, 9);
                    output += num;
                    if (i % 2 == 1)
                    {
                        sum += num;
                    }
                    else
                    {
                        if (num * 2 > 9)
                        {
                            sum += (num * 2) - 9;
                        }
                        else
                        {
                            sum += num * 2;

                        }
                    }

                }
                sum += 3;
                sum = 10 - sum % 10;
                output += sum;
                Console.WriteLine(output);

            }
            if (input.Equals("Discover"))
            {
                output += 6;
                for (int i = 0; i < 14; i++)
                {
                    num = rnd.Next(0, 9);
                    output += num;
                    
                    if (i % 2 == 0)
                    {
                        sum += num;
                    }
                    else
                    {
                        if (num * 2 > 9)
                        {
                            sum += (num * 2) - 9;
                        }
                        else
                        {
                            sum += num * 2;
                        }
                    }

                }
                sum += 3;
                sum = 10 - sum % 10;
                output += sum;
                Console.WriteLine(output);
                
            }
            Console.ReadKey();


        }
    }
}

/*Написать программу, которая будет генерировать валидный номер банковской карты.
 * Пример ввода:
 * Visa (выдает валидный номер виза)
 * MasterCard
 * AmericanExpress
 * Discover
 * *26 (номер должен оканчиваться на 26)
 * 512* (номер должен начинаться на 512)
 */