using System;

namespace LabAssignment
{
    class VariablesAndOperators
    {
        static void Main(string[] args)
        {
            int numberOfPies = 12; //This variable is meant for whole numbers. Whenever I reference this variable, I'm referencing it's number. It's number will change later.
            string aaronInitialPies = "Aaron has " + numberOfPies + " pies fully baked."; //String is meant for text. This text is now able to be visually displayed using Console.WriteLine
            Console.WriteLine(aaronInitialPies);
            
            numberOfPies++; //This "++" means add one to the current integer. Since numberOfPies is 12, the ++ makes it 13.
            string aaronBakedPie = "Last night Aaron baked another pie. He now has " + numberOfPies + ".";
            Console.WriteLine(aaronBakedPie);
            
            numberOfPies *= 2; //"*=" Means multiplication. It multiplies the integer "numberOfPies" by two. The next time the integer is written it will be 26
            string doubledPie = "The next night Aaron baked double the amount of pies he had at the time! He now has " + numberOfPies + "!";
            Console.WriteLine(doubledPie);
            
            if(numberOfPies >= 20 && numberOfPies <= 30)
            {
                bool boolean = true; //Booleans are meant for true/false situations. Since Aaron has more than 20 Pies, but less than 30 Pies the statement is true so console writes out the string.
                if(boolean == true)
                {string AaronLotsOfPie = "He now only needs 1 more pie! He is happy!";
                Console.WriteLine(AaronLotsOfPie);
                }          
            }

            float doughLeft = 0.6f; //This is a float. A float is used for numbers with decimals.
            string aaronNeedsDough = "Aaron has nearly run out of dough! He currently only has enough to make " + doughLeft + " of a pie.";
            Console.WriteLine(aaronNeedsDough);

            float doughPurchased = 0.4f;
            string aaronBuysDough = "Quickly he went to the store and bought the remaining " + doughPurchased + " dough that he needed.";
            Console.WriteLine(aaronBuysDough);

            doughLeft += doughPurchased; //"+=" Added the two floats together. Their combined sum is 1. This sum will be shown in the next string
            numberOfPies += (int)(doughLeft);
            string finalPie = "He then combined the dough into " + doughLeft + " last pie and he has now finished. In total he has made " + numberOfPies + " pies.";
            Console.WriteLine(finalPie);
        }
    }
}