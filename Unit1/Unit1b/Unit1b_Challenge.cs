using System;
public class Program
{
	public SubjectChecker subjectChecker;
	
	public void Main()
    {
        Console.WriteLine("Hello! What's the current temperature in Celcius?");//Displays message on console.
        while (true)

            {
            int currentTemp = Convert.ToInt32(Console.ReadLine()); //This converts the user input into an integer that the console can now compare with other numbers in the following lines
            
            if (currentTemp >= 40){//If current temp is greater than or equal to 40 display message directly below.
            Console.WriteLine("It's way too hot! Get inside and avoid the heat!");
            break;//Move onto next portion of code.
            }
            
            else if (currentTemp >= 30 && currentTemp <= 39) {//If input is greater than or equal to 30 while also being less than or equal to 39, display message.
            Console.WriteLine("It's getting real hot out there! Don't forget to stay hydrated! Don't stay out in the sun too long!");
            break;
            }

            else if (currentTemp >= 20 && currentTemp <= 29){//If input is greater than or equal to 20 while also being less than or equal to 29, display message.
            Console.WriteLine("Perfect temperature! Enjoy a nice day outside.");
            break;
            }

            else if (currentTemp >= 10 && currentTemp <= 19){//If input is greater than or equal to 10 while also being less than or equal to 19, display message.
            Console.WriteLine("It's on the cooler side, but luckily not too cold yet! Have fun out there.");
            break;
            }

            else if (currentTemp >= 0 && currentTemp <= 9){//If input is greater than or equal to 0 while also being less than or equal to 9, display message.
            Console.WriteLine("It's pretty cold out! Bundle up for the cold!");
            break;
            }

            else{//For any other input, display message.
            Console.WriteLine("Not a valid temperature, try again!");
            }
            }
        
        Console.WriteLine("What was your score on the exam?");
        while (true)

            {
            int userScore = Convert.ToInt32(Console.ReadLine());
               
            if (userScore > 100){
            Console.WriteLine("You got an A+!\nExtra credit is always nice! I'm proud of you!");
            break;
            }
                
            if (userScore >= 90 && userScore <= 100 ){
            Console.WriteLine("You got an A!\nYour hard work paid off!");
            break;
            }
                
            else if (userScore >= 80 && userScore <= 89){
            Console.WriteLine("You got an B!\nSolid score, good job!");
            break;
            }
                
            else if (userScore >= 70 && userScore <= 79){
            Console.WriteLine("You got an C!\nNot bad! Could've been better.");
            break;
            }
                
            else if (userScore >= 60 && userScore <= 69){
            Console.WriteLine("You got an D.\nIf you had applied yourself you could've gotten a higher score.");
            break;
            }
                
            else if (userScore < 60){
            Console.WriteLine("You got an F.\nNext time study and prepare yourself.");
            break;
            }

            }
        Console.WriteLine("Of the core subjects taught in school, which one is your favorite?");
		
		subjectChecker = new SubjectChecker();
		subjectChecker.CheckFavoriteSubject();//Runs void CheckFavoriteSubject
	
	}
public class SubjectChecker {


    public void CheckFavoriteSubject () {

		string favoriteSubject = Console.ReadLine();
        
		switch (favoriteSubject) {//Similar to the ifs and else ifs seen above, this is conditional logic that will only run code if conditions are met.
			case "Math": case "math" : case "MATH" ://If math is input, display message below
                Console.WriteLine("I love math! Logical problem solving is the best");
				break;
        }
		
		switch (favoriteSubject) {
			case "Science": case "science" : case "SCIENCE" ://If science is input, display message below
                Console.WriteLine("Science is really cool and important in society! Good on ya!");
				break;
        }
		
		switch (favoriteSubject) {
			case "English": case "english" : case "ENGLISH" ://If english is input, display message below
                Console.WriteLine("English is pretty awesome. Communication via language is important.");
				break;
        }
		
		switch (favoriteSubject) {
			case "History": case "history" : case "HISTORY" ://If history is input, display message below
                Console.WriteLine("Learning where we came from to be aware of where we're going is vital to humanity.");
				break;
        }

        
    }

}
    }