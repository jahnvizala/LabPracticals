using System;

public class Class1
{
    public static void Main()
    {
        for (int i = 5; i > 0; i--)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write("@");
            }
            Console.Write("\n");
        }
    }
}
