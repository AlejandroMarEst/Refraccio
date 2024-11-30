using System;

namespace Refraccio { 
    class Refraccio
    {
        static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }
        static double CalculateCircleCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static void CheckInterval(double area)
        {
            const string AreaBigger = "L'àrea és més gran de 50";
            const string AreaInside = "L'àrea és entre 20 i 50";
            const string AreaSmaller = "L'àrea és menor o igual a 20";
            if (area > 50)
            {
                Console.WriteLine(AreaBigger);
            }
            else if (area > 20)
            {
                Console.WriteLine(AreaInside);
            }
            else
            {
                Console.WriteLine(AreaSmaller);
            }
        }
        static void Main(string[] args)
        {
            // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
            const string InputWidth = "Introdueix l'amplada del rectangle:";
            const string InputHeight = "Introdueix l'altura del rectangle:";
            const string AreaRectangle = "L'àrea del rectangle és: {0}";
            const string InputRadius = "Introdueix el radi del cercle:";
            const string CircumferenceCircle = "La circumferència del cercle és: {0}";

            Console.WriteLine(InputWidth);
            double widthRectangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(InputHeight);
            double heightRectangle = Convert.ToDouble(Console.ReadLine());

            // Calcula l'àrea
            double areaRectangle = CalculateRectangleArea(widthRectangle, heightRectangle);
            Console.WriteLine(AreaRectangle, areaRectangle);

            // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
            Console.WriteLine(InputRadius);
            double radiusCircle = Convert.ToDouble(Console.ReadLine());
            double circumferenceCircle = CalculateCircleCircumference(radiusCircle);
            Console.WriteLine(CircumferenceCircle, circumferenceCircle);
            CheckInterval(areaRectangle);
        }
    }
}