using System;
using System.Collections.Generic;
namespace Calc  
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите целое число");
            int numberDEC = int.Parse(Console.ReadLine()), numberInPositionI = 0, checkNumber = 1;
            string str = null;
            List<char> finiteNumber = new List<char>();
            finiteNumber.Add(' ');
            char[] numberSystemDigits = { '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            while (true)
            {
                switch (numberDEC)
                {
                    case < 18:
                        if (finiteNumber[0] != ' ')
                        {
                            finiteNumber.Reverse();
                            str = new string(finiteNumber.ToArray());
                        }
                        str += numberSystemDigits[numberDEC];
                        break;
                    default:
                        for (int i = 0; ; i++)
                        {
                            switch (finiteNumber[i])
                            {
                                case 'J':
                                    if (i == numberInPositionI)
                                    {
                                        finiteNumber.Add('0');
                                        numberInPositionI++;
                                    }
                                    finiteNumber[i] = '2';
                                    checkNumber = 1;
                                    if (finiteNumber[i + 1] != 'J')
                                    {
                                        finiteNumber[i + 1] = numberSystemDigits[checkNumber];
                                        break;
                                    }
                                    break;
                                default:
                                    finiteNumber[i] = numberSystemDigits[checkNumber];
                                    checkNumber++;
                                    numberDEC -= 18;
                                    break;
                            }
                        }
                        break;
                }
                Console.WriteLine(str);
            }
        }
    }
