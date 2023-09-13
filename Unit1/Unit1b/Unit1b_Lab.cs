using System;
					
public class Program
{
	public void Main()
    {
        Console.WriteLine("Hello! What's the current temperature in Celcius?");
        while (true)

            {
            int currentTemp = Convert.ToInt32(Console.ReadLine()); //This converts the user input into an integer that the console can now compare with other numbers in the following lines
            
            if (currentTemp > 30) {//If the current temp is greater than 30, display the message directly below. If not, move onto "else if"
            Console.WriteLine("It's getting real hot out there! Don't forget to stay hydrated! Don't stay out in the sun too long!");
            break;//This breaks out of the "if" and moves on in the code.
            }
            
            else if (currentTemp < 30){ //If current temp is less than 30, display message, if not, move on with code.
            Console.WriteLine("I hope you get outside and enjoy the nice weather!");
            break;    
            }
            
            else if (currentTemp == 30){ //If current temp is exactly 30, display message, if not, move on with code.
            Console.WriteLine("A perfectly balanced warm day! If you decide to go out bring some water!");
            break;
            }
            
            else{//Else is meant for anything else that's put into the system.
            Console.WriteLine("Not a valid temperature, try again!");
            }
            }
        
        Console.WriteLine("What was your score on the exam?");
        while (true)

            {
            int userScore = Convert.ToInt32(Console.ReadLine());//This converts the user's score to an integer.
               
            if (userScore >= 100){ //If the score is greater than or equal to 100, display message. If not, move on.
            Console.WriteLine("You got an A+!\nExtra credit is always nice! I'm proud of you!");
            break;
            }
                
            if (userScore >= 90){ //If the score is greater than or equal to 90, display message. If not, move on.
            Console.WriteLine("You got an A!\nYour hard work paid off!");
            break;
            }
                
            else if (userScore >= 80){//If the score is greater than or equal to 80, display message. If not, move on.
            Console.WriteLine("You got an B!\nSolid score, good job!");
            break;
            }
                
            else if (userScore >= 70){//If the score is greater than or equal to 70, display message. If not, move on.
            Console.WriteLine("You got an C!\nNot bad! Could've been better.");
            break;
            }
                
            else if (userScore >= 60){//If the score is greater than or equal to 60, display message. If not, move on.
            Console.WriteLine("You got an D.\nIf you had applied yourself you could've gotten a higher score.");
            break;
            }
                
            else if (userScore < 60){//If the score is less than 60, display message.
            Console.WriteLine("You got an F.\nNext time study and prepare yourself.");
            break;
            }

            }
    }
}