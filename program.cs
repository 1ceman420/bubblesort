using System;
public class Program

{
    public static void Main()
    {
        //number list to sort 
       
        Console.WriteLine("Enter number 1:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 3:");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 4:");
        int num4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 5:");
        int num5 = int.Parse(Console.ReadLine());


        int[] data = new int[5] { num1, num2, num3, num4, num5 };

        //declare variables 
        int temp;
        bool swapped;

        //start of bubble sort algorithm 
        do
        {
            swapped = false;

            for (int index = 0; index < data.Length - 1; index++)
            {

                //sorts the numbers 
                if (data[index + 1] < data[index])
                {
                    temp = data[index + 1];
                    data[index + 1] = data[index];
                    data[index] = temp;
                    swapped = true;
                }
            }

        //checks if all numbers are sorted 
        } while (swapped == true);

        //if all numbers sorted do this 
        foreach (int number in data)
        {
            Console.WriteLine(number);
            Console.ReadLine();
        }

    }

}
