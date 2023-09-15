using System;
					
public class Program
{
	public static void Main()
	{
        int playerHealth = 100; //These are the initial heal values of the player and sandbag. These will change eventually.
        int sandbagHealth = 100;

		Console.WriteLine("You have " + playerHealth + " health.\nqHung in the air suspended by a rope, a sandbag hangs in front of you.\nThe sandbag has " + sandbagHealth + " health."); //Everytime you see "playerHealth" or "sandbagHealth", I'm referencing the health values within the code.
        Console.WriteLine("Do you choose to strike the sandbag with a punch or kick?");
        Console.WriteLine("PUNCH or KICK?");
        
        while (true)
        {
            string punchOrKick = Console.ReadLine(); //This gives the player the option to type the attack they'd like to use.

            if (punchOrKick == "punch" ||punchOrKick ==  "PUNCH" || punchOrKick == "Punch") //This says if the user has input "punch", move on inside the curly bracket. If not, move on.
            {
            Console.WriteLine("You've decided to punch. You throw all your strength into a single punch and snap the rope holding the sandbag, throwing it to the floor.");
            sandbagHealth -= 100; //This lowered the sandbag's health to zero.
            Console.WriteLine("The sandbag's health is now " + sandbagHealth + ". The sandbag has been defeated.\nYOU WIN.");
            break;
            }

            if (punchOrKick == "kick" || punchOrKick == "KICK" || punchOrKick == "Kick") //This reads the players kick input and moves them into the curly bracket too.
            {
            playerHealth /= 2; //This has divided the player's health by 2.
            sandbagHealth -= 25;
            Console.WriteLine("You've decided to kick. You kick too hard and you break your leg in the process.\nYour health is now " + playerHealth + ".\nThe sandbags health is now " + sandbagHealth + ".");
            break;
            }

            else //This "else" is meant for every other input and tells users to retype their input since it didn't recognize the command.
            {
            Console.WriteLine("Invalid input. Try again.");
            }
        }
        if (playerHealth == 50) //If the player dies in this game this "if" will have the system type a game over message.
        {
            Console.WriteLine("You're still conscious but unable to act due to pain!\nGAME OVER\nThanks for playing!");
        }
	}
}