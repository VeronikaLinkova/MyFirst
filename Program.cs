using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_про_ворон
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ворон:");

            int lastNumber;
            string val;
            int val1 = 0;
            while (val1 != -5)
            {

                val = Console.ReadLine();                
                val1 = Convert.ToInt32(val);
                lastNumber = Convert.ToInt32(val1 % 10);
                if (val1 <0)
                {
                    Console.WriteLine("Введите число больше нуля");                    
                }
                else
                {
                    if (lastNumber == 1)
                    {
                        Console.WriteLine($"На ветке сиделa {val1} воронa");
                    }
                    else if (lastNumber == 0)
                    {
                        Console.WriteLine($"На ветке сиделo {val1} ворон");
                    }
                    else if (lastNumber == 2)
                    {
                        Console.WriteLine($"На ветке сиделo {val1} вороны");
                    }
                    else
                    {
                        Console.WriteLine("КРЯ!!!!");
                    }
                                                                                

                }
                                
            }           

        }
    }
}
