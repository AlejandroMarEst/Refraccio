using System;

class Program
{
    static void Main(string[] args)
    {
        // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
        const string InputWidthRectangle = "Introdueix l'amplada del rectangle:";
        const string InputHeightRectangle = "Introdueix l'altura del rectangle:";
        const string AreaRectangle = "L'àrea del rectangle és: {0}";
        const string InputRadiusCircle = "Introdueix el radi del cercle:";
        const string CircumferenceCircle = "La circumferència del cercle és: {0}";
        const string AreaBiggerThan50 = "L'àrea és més gran de 50";
        const string AreaInsideInterval = "L'àrea és entre 20 i 50";
        const string AreaSmallerThan20 = "L'àrea és menor o igual a 20";
        Console.WriteLine(InputWidthRectangle);
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(InputHeightRectangle);
        double height = Convert.ToDouble(Console.ReadLine());

        // Calcula l'àrea
        double area = width * height;
        Console.WriteLine(AreaRectangle,area);

        // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
        Console.WriteLine(InputRadiusCircle);
        double radius = Convert.ToDouble(Console.ReadLine());
        double circumference = 2 * Math.PI * radius;

        Console.WriteLine(CircumferenceCircle, circumference);

        // Imprimeix un missatge basat en el valor de l'àrea
        if (area > 50)
        {
            Console.WriteLine(AreaBiggerThan50);
        }
        else if (area > 20)
        {
            Console.WriteLine(AreaInsideInterval);
        }
        else
        {
            Console.WriteLine(AreaSmallerThan20);
        }
    }
}