namespace FCC_Course___College_Algebra.Units.Unit_1;

public class Lesson2
{
    public static void Init()
    {
        Console.WriteLine("Unit 1, Lesson 2");
        Console.WriteLine("Solving Proportions");
        Solve();
    }
    
    private static void Solve()
    {
        Console.WriteLine("Enter proportion 1 as n/d, both being numbers.");
        Console.Write("Enter Proportion 1: ");
        string proportion1 = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Enter proportion 2 as x/d or n/x, using x as the unknown number.");
        Console.Write("Enter Proportion 2: ");
        string proportion2 = Console.ReadLine();

        double result = 0;
        
        try
        {
            string[] p1Parts = proportion1.Split('/');
            string n1Str = p1Parts[0].Trim();
            string d1Str = p1Parts[1].Trim();
        
            string[] p2Parts = proportion2.Split('/');
            string n2Str = p2Parts[0].Trim();
            string d2Str = p2Parts[1].Trim();
        
            double n1, d1, n2, d2;

            if (n2Str.ToLower() == "x" )
            {
                n1 = double.Parse(n1Str);
                d1 = double.Parse(d1Str);
                d2 = double.Parse(d2Str);

                result = (n1 * d2) / d1;
            }
            else if (d2Str.ToLower() == "x")
            {
                n1 = double.Parse(n1Str);
                d1 = double.Parse(d1Str);
                n2 = double.Parse(n2Str);

                result = (d1 * n2) / n1;
            }
            else
            {
                Console.WriteLine("Error: Proportion 2 must contain an 'x'.");
                Console.WriteLine("Press any key to exit...");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("\nError: Invalid numbers. Please use 'x' and numbers only.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nInvalid format. Please follow the 'n/d' and 'x/d or n/x' pattern.");
        }
        
        Console.WriteLine("");
        Console.WriteLine("X = " + result);
        Console.WriteLine("");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}