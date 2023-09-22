using System;
public class Program
{
	public static void Main()
    {
        int[] numberList = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};//This int[] creates an integer array. The numbers within the numberList parentheses are te different values stored in the array that will be read later.
        Console.WriteLine("Guess a number 1 through 10!");//This prints the text in quotes.

        int guessNumber = 0; //This is the amount of guessed the user has made. It is currently zero, it will tick upwards as guesses are made.
        int userGuess = Convert.ToInt32(Console.ReadLine());//This turns the input from the user into a integer so that it can interact with other integers later.
		
        Random random = new Random(0);//This is the creation of a new random value.
        int randomNumber = random.Next(numberList.Length);//This turns the new random instance into an integer that is as long as the numberlist array, thus making a RNG of 1 - 10 since there are 10 values within the int[].

        while (userGuess > numberList[randomNumber])//While the user's guess is greater than the random number, run code below.
        {
            guessNumber++;//Add 1 to the guess counter.
            Console.WriteLine("You're too high, try again!");//System outputs this line.
            userGuess = Convert.ToInt32(Console.ReadLine());//The user is able to guess again.
        }

        while (userGuess < numberList[randomNumber])//While the user's guess is smaller than the random number, run code below.
        {
            guessNumber++;
            Console.WriteLine("You're too low, try again!");
            userGuess = Convert.ToInt32(Console.ReadLine());
        }

        while (userGuess == numberList[randomNumber])//While the user's number is exactly equal to the random number, run code below.
        {
        guessNumber++;
        Console.WriteLine ("You got it right! Good job!\nYou got it in " + guessNumber + " guesses!");//This congratulates the user and the "guessNumber" is shown to the user too.
        break;//This breaks out of the loop, continuing onto the top three favorite foods portion.
        }



        Console.WriteLine("Now name your top three favorite foods, one at a time please!\nWhat's your number one favorite food?");
        string veryFavoriteFood = Console.ReadLine();//This assigns the input from the user to the string variable named "veryFavoriteFood", assigning it to this name lets us cleanly use this input later. 
       
        Console.WriteLine("What's your second favorite food?");
        string secondFavoriteFood = Console.ReadLine();//This assigns this input to "secondFavoriteFood"
        
        Console.WriteLine("And finally, what's your third favorite food?");
        string thirdFavoriteFood = Console.ReadLine();//Assigns the final input to "thirdFavoriteFood"
        
        string[] food = {veryFavoriteFood, secondFavoriteFood, thirdFavoriteFood};//This array is where we store the input values using the names we gave them earlier. This is simplifies the code and gives us an easy way to affect the code in the next line using a "for" loop.
        for (int i = 0; i < food.Length; i++)//This for loop starts with us assigning the value of zero to i. Then if i is less than the number of strings in the array above, execute the line of code in the curly brace below then add one to the value of i. This loops until the value of i is equal to the amount of string within the array.
        {
            Console.WriteLine(food[i] + " mmm yummy yummy!");//This prints the current index of i that the loop is reading, when this code is running for the first time it prints "veryFavoriteFood", then moves back to the for loop parentheses above which adds 1 to the index, meaning the next time this code is printed it now prints the "secondFavoriteFood" value and so on.
        }
    }
}
