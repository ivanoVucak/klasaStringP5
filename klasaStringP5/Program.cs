
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši jedan prirodan i jedan decimalan broj odvojen razmakom: ");

            var znak = Console.ReadLine();
            var podatak = znak.Split(' ');
            var x = int.Parse(podatak[0]);
            var y = double.Parse(podatak[1]);


            Console.WriteLine(x);
            Console.WriteLine(y);
            

            Console.ReadKey(); 
        }
    }
}
