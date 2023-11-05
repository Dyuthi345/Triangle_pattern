using System;
class Trianglepattern
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the height of the Triangle : ");
        if (int.TryParse(Console.ReadLine(), out int height))
        {
            PrintTriangle(height); // Print the triangle 
        }
        else
        {
            Console.WriteLine("Please enter a valid integer for height");
        }
    }
    static void PrintTriangle(int height)  
    {
        for (int i = 1; i<= height; i++)
        {
            for(int j = 1; j<= height - i; j++) // print spaces before the stars
            {
                Console.Write(" ");
            }
            for(int k = 1; k<= 2*i - 1; k++)  // print stars for each row
            {
                Console.Write("*");
            }
            Console.WriteLine(); // move to the next line for the next row
        }
    }
}