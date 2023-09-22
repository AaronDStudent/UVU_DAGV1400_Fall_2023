using System;
public class Program
{
    public void Main()
    {
Console.WriteLine("Enter a number to see a number pyramid!");
        int userNumber = Convert.ToInt32(Console.ReadLine());//Turns users input into a int to be manipulated later.

        for (int i = 1; i <= userNumber; i++)// i is declared as equal to 1. If i <= userNumber, run block of code below and then add 1 to i, loop this until i equals the input's value.
        {
            for (int j = 1; j <= i; j++)//j is equal to 1, if j is less than or equal to i, the console with write out i (because it runs block of code below).
            {
                Console.Write(i);//This is run everytime the 1st for is looped to add 1 to the i to match the user input, which is why it displays so many times.
            }
            Console.WriteLine();//Unlike Console.Write, Console.WriteLine(seperates the code by printing each run of the initial "for" on a separate line. If we had only Console.Write, it would all be printed on one line
        }
    }
}