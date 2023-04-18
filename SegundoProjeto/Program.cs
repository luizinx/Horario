using System;
using System.Globalization;
using System.Security.AccessControl;

namespace hora
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int x = int.Parse(Console.ReadLine());

            if ( x < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (x < 18) {
                Console.WriteLine("Boa Tarde!!");
            }
            else
            {
                Console.WriteLine("Boa Noite!!");
                
            }

        }
    }

}

