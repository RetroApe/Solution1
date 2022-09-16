using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Generate
    {
        public static void Password()
        {
            Random rnd = new Random();
            char[] password = new char[16];

            Console.WriteLine("Random three: {0}, {1}, {2}\n", rnd.Next(3), rnd.Next(3), rnd.Next(3));

            for (int i = 0; i < 16; i++)
            {
                switch (rnd.Next(4))
                {
                    case 0:
                        password[i] = Convert.ToChar(rnd.Next('0', '9'));
                        break;
                    case 1:
                        password[i] = Convert.ToChar(rnd.Next('a', 'z'));
                        break;
                    case 2:
                        password[i] = Convert.ToChar(rnd.Next('A', 'Z'));
                        break;
                    case 3:
                        password[i] = Convert.ToChar(rnd.Next(35, 38));
                        break;
                }
            }
            Console.WriteLine(String.Join("", password));
        }
    }
}
