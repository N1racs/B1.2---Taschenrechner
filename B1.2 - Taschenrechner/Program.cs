using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace B1._2___Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Text
            string first = "Erste Zahl!";
            string second = "Zweite Zahl!";
            string enterOperator = "Operator eingeben!";
            string endResult = "Resultat = ";
            string invalide = "Ungültige Zahl! Versuche es noch einmal.";

            //console output
            float a, b, result;
            Console.WriteLine(first);
            Console.Write(">");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine(second);
            Console.Write(">");
            b = float.Parse(Console.ReadLine());


            Console.WriteLine(enterOperator);
            Console.Write(">");

            string opp = Console.ReadLine();

            //switch-case
            switch (opp)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine(endResult + result);

                    break;
                case "-":
                    result = a - b;
                    Console.WriteLine(endResult + result);

                    break;
                case "*":
                    result = a * b;
                    Console.WriteLine(endResult + result);

                    break;
                case "/":
                    result = a / b;
                    Console.WriteLine(endResult + result);

                    break;
                default:
                    Console.WriteLine(invalide);

                    break;
            }

            Console.ReadLine();
        }
    }
}
