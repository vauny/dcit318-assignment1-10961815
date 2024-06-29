using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter the length of the first side: ");
        int side1 = GetValidatedSide();

        Console.Write("Enter the  of the second side: ");
        int side2 = GetValidatedSide();

        Console.Write("Enter the length of the third side: ");
        int side3 = GetValidatedSide();

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }

    static int GetValidatedSide()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int side))
            {
                return side;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
