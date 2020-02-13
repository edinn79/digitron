using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitron
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Dobro dosli u vas digitron");
            Console.WriteLine("Unesite prvi clan na kojem zelite da se vrsi operacija");
                double prviBroj = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi clan sa kojim zelite da se vrsi operacija");
                int drugiBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite operaciju");
            string Op = Console.ReadLine();
            
            switch(Op)
                {
                case "+":
                    Console.WriteLine("Vas rezultat je" + " " + (prviBroj + drugiBroj));
                    break;
                case "-":
                    Console.WriteLine("Vas rezultat je" + " " + (prviBroj - drugiBroj));
                    break;
                case "*":
                    Console.WriteLine("Vas rezultat je" + " " + (prviBroj * drugiBroj));
                    break;
                case "/":
                    Console.WriteLine("Vas rezultat je" + " " + (prviBroj / drugiBroj));
                    break;
                case "%":
                    Console.WriteLine("Vas rezultat je" + " " + (prviBroj % drugiBroj));
                    break;
                

            }





            Console.ReadKey();
            
        }
    }
}
