using System;
using System.ComponentModel.Design;

namespace Simple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string choix;
            Console.WriteLine("Entrer la valeur de a");

            choix = Console.ReadLine();
            double a = Convert.ToDouble(choix);

            Console.WriteLine("Entrer la valeur de b");
            choix = Console.ReadLine();
            double b = Convert.ToDouble(choix);

            Console.WriteLine("Entrer la valeur de c");
            choix = Console.ReadLine();
            double c = Convert.ToDouble(choix);

            calculer(a, b, c);
        }

        public static void calculer(double a , double b, double c)
        {
            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                double racine1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double racine2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"L'équation a deux solutions réelles : x1 = {racine1}, x2 = {racine2}");
            }
            else if (delta == 0)
            {
                double racineUnique = -b / (2 * a);
                Console.WriteLine($"L'équation a une solution unique : x = {racineUnique}");
            }
            else
            {
                Console.WriteLine("L'équation n'a pas de solution réelle (discriminant négatif).");
            }
        
        }
    }
}


