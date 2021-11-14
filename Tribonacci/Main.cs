using System;

public class Tribonacci {

 public static void Tribonacci(int input)
        {
            int firstNumber = 0;
            int secondNUmber = 1;
            int thirdNumber = 1;
            Console.Write("{0} {1} {2}", firstNumber, secondNUmber, thirdNumber);
            while(thirdNumber <= input)
            {
                int temp = firstNumber + secondNUmber + thirdNumber;
                firstNumber = secondNUmber;
                secondNUmber = thirdNumber;
                thirdNumber = temp;
                if(thirdNumber <= input)
                {
                    Console.Write(" {0} ", thirdNumber);
                }

            }
        }

    public static void Main() 
    {
        Console.WriteLine("Tribonacci: \n");
        Tribonacci(24);
        Console.ReadLine();

    }
}