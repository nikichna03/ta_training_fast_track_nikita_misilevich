using System;
using System.Collections.Generic;
namespace задание_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите целое число");
            int number10 = int.Parse(Console.ReadLine()), step = 0, step2 = 1;
            string str = null;
            List<char> a = new List<char>();
            a.Add(' ');
            char[] simvol = { '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            while (true)
            {
                if (number10 < 18)
                {
                    if (a[0]!=' ')
                    {
                        a.Reverse();
                        str = new string(a.ToArray());
                    }
                    str += simvol[number10];
                    break;
                }
                else
                {
                    for (int i = 0; ; i++)
                    {
                        if (a[i] == simvol[17])
                        {
                            if (i == step)
                            {
                                a.Add('0');
                                step++;
                            }
                            a[i] = '2';
                            step2 = 1;
                            if (a[i + 1] != simvol[17])
                            {
                                a[i + 1] = simvol[step2];
                                break;
                            }
                        }
                        else
                        {
                            a[i] = simvol[step2];
                            step2++;
                            number10 -= 18;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(str);
        }
    }
}



/*629
 2 	 0
 3	 1
 4	 2
 5	 3
 6	 4
 7	 5
 8	 6 
 9	 7
 A	 8
 B	 9
 C	10
 D	11
 E	12
 F	13
 G	14
 H	15
 I	16
 J	17
32	18
*/