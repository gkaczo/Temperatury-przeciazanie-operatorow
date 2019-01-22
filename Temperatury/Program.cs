using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatury
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatura t1 = new Temperatura();
            t1.TempKelwin = 283;

            Temperatura t2 = new Temperatura();
            t2.TempCelsjusz = 10;

            Temperatura t = new Temperatura();
            t = t1 + t2;
            t = t + 20;

            Console.WriteLine("temperatura:{0} C", t.TempCelsjusz);

           
            if (t1==t2)
            {
                Console.WriteLine("Temperatury są równe");
            }

            Console.ReadLine();
        }
    }
}
