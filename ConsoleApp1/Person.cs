using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Koord 
    {
            public float Distance(int x, int y)
        {
            return (float)(Math.Sqrt(x * x + y * y));
        }
    }
}
