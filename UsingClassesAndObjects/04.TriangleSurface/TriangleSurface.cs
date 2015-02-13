/* Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
 */ 

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Calculate the surface of a triangle:");
        Console.Write(@"
Side and an altitude to it  --> 1
Three sides                 --> 2
Two sides and an angle      --> 3
");
        Console.Write("\nEnter your choise: ");
        int choise = int.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1: OneSideAltitude(); break;
            case 2: ThreeSides(); break;
            case 3: TwoSidesAngle(); break;
            default:
                Console.WriteLine("Invalid choise!");
                break;
        }
    }

    private static void TwoSidesAngle()
    {
        // S = ½(ab.sinC) = ½(ac.sinB) = ½(bc.sinA)
        Console.Write("Enter side A = ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side B = ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter an angle = ");
        double angle = double.Parse(Console.ReadLine());
        
        double surface = (sideA * sideB * Math.Sin(angle)) / 2;
        
        Console.WriteLine("The surface = {0:F4}", surface);
    }

    private static void ThreeSides()
    {
        // S = √p(p - a)(p - b)(p - c)
        Console.Write("Enter side A = ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side B = ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter side C = ");
        double sideC = double.Parse(Console.ReadLine());
       
        double halfPerimeter = (sideA + sideB + sideC) / 2;
        double surface = Math.Sqrt(halfPerimeter*(halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        
        Console.WriteLine("The surface = {0:F4}", surface);
    }

    static void OneSideAltitude()
    {
        //S = ½(a.ha) = ½(b.hb) = ½(c.hc)
        Console.Write("Enter side = ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude = ");
        double altitude = double.Parse(Console.ReadLine());
       
        double surface = side * altitude / 2;
        
        Console.WriteLine("The surface = {0:F4}", surface);
    }
}

