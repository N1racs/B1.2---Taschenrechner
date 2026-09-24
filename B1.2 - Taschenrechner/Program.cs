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
            string enterOperator = "Operator eingeben! (+, -, /, *)";
            string endResult = "Resultat = ";
            string invalide = "Ungültige Zahl! \n" +
                "Versuche es noch einmal.";

            //console output
            float a, b, result;
            Console.WriteLine(first);
            Console.Write("> ");

            while (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(invalide);
                Console.Write("> ");
            }

            Console.WriteLine(second);
            Console.Write("> ");

            while (!float.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine(invalide);
                Console.Write("> ");
            }

            string opp;
            
            do
            {
                Console.WriteLine(enterOperator);
                Console.Write("> ");

                opp = Console.ReadLine();

                if (opp != "+" && opp != "-" && opp != "*" && opp != "/")
                {
                    Console.WriteLine(invalide);
                }

            } 
            while (opp != "+" && opp != "-" && opp != "*" && opp != "/");

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

                    
            }

            Console.ReadLine();
        }
    }
}
