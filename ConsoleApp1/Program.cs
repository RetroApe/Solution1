//Console.WriteLine("And this...?");
using ConsoleApp1;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace MyFirstNamespace
{
    public class Person
    {
        public int Age;
    }

    class CanIWriteSomethingElseHere
    {
        static string Lines(int n)
        {
            return new string('-', n);
        }

        static void Main(string[] args)
        {
            var koord = new Koord();
            
            Console.WriteLine(koord.Distance(3,4));

            var znakovi = new char[3];

            znakovi[1] = (char) 65;

            Console.WriteLine("Razmak");
            Console.WriteLine(znakovi[0]);
            Console.WriteLine(znakovi[1]);
            Console.WriteLine(znakovi[2]);

            Console.Write("   ");
            for (int i = 1; i <= 10; i++)
                Console.Write("{0,-3}", i);
            Console.WriteLine();
            
            Console.WriteLine("{0}", Lines(33));

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,-2}|", i);
                for (int j = 1; j <= 10; j++)
                    Console.Write("{0,-3}", i * j);
                Console.WriteLine();
            }

            Person person1 = new Person();
            Person person2 = new Person();
            var person3 = person1;
;           
            person2.Age = 30;
            person3.Age = 29;
            MakeOld(person1);

            Console.WriteLine("\nAge of three people are:\n{0}\n{1}\n{2}", person1.Age, person2.Age, person3.Age);

            Console.WriteLine("\nNow genereting password:\n");
            Generate.Password();

        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

        
    }
}

