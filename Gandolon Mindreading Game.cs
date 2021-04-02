using System;
using System.Threading;

namespace C__Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Screen
            Console.WriteLine("_________GANDOLON ARISES____________!");
            Console.WriteLine("Welcome my buddy Programmer");
            Console.WriteLine("Be so kind and draw one of the following cards: ");
            Console.WriteLine("_________ _________ _________ ________ _________ ");
            Console.WriteLine("|       | |        | |       | |       | |       | |");
            Console.WriteLine("|   1   | |   2    | |   3   | |   4   | |   5   | |");
            Console.WriteLine("|       | |        | |       | |       | |       | |");
            Console.WriteLine(" - - - -   - - - - -   - - - -   - - - -  - - -- -");
            Console.WriteLine("");
            Console.WriteLine("Enter a number between 1 to 5 to choose a card. After that hit enter key.");


            //User has to choose an answer
            var userInput = Console.ReadLine();
            int enteredNumber = Convert.ToInt32(userInput);

            //Gandolons Answer#1
            Console.WriteLine("You chose card number " + enteredNumber);


            //Display the card to the user
            Console.WriteLine("And this is your card, keep the card in mind: ");

            if(enteredNumber == 1)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     A     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            } 
            else if (enteredNumber == 2)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     J     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            }

            else if(enteredNumber == 3)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     k     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            }
            else if (enteredNumber == 4)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     A     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            }

            else if (enteredNumber == 5)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     7     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            }

            else
            {
                Console.WriteLine("Ha ha ha ha ! Don't fool me, Here is a card then.");
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     Q     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            }

            //Let the user memorize the cards
            Thread.Sleep(1000);


            //Wait for the user input
            Console.WriteLine("Hit Eneter, when you're ready for my magic powers!");
            Console.ReadLine();


            //Gandolons Answer#2
            Console.WriteLine("Now I am going to guess the card you have drawn: ");
            Thread.Sleep(500);
            Console.WriteLine("Let me listen to your thoughts");


             //Gandolon's Thinking
             for(int i = 0; i< 4; i++)
             {
                 Thread.Sleep(500 * i);
                 Console.WriteLine("Hmm ...");
             }

             //Tension for the user
             Thread.Sleep(1000);
             Console.WriteLine("AHA!");


             //Gandolon Reveals the card you have drawn
             Console.WriteLine("Your card was: ");
             if(enteredNumber == 1)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     A     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            } 
            else if (enteredNumber == 2)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     J     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            }

            else if(enteredNumber == 3)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     k     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            }
            else if (enteredNumber == 4)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     A     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            }

            else if (enteredNumber == 5)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     7     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            }

            else
            {
                Console.WriteLine("Ha ha ha ha ! Don't fool me, Here is a card then.");
                Console.WriteLine("_____________");
                Console.WriteLine("|           |");
                Console.WriteLine("|     Q     |");
                Console.WriteLine("|           |");
                Console.WriteLine("_____________");
            }

            //Let the user decide to be honest with Gandolon and await answer
            Console.WriteLine("Am I right? Enter Y for Yes and N for No.");
            string answerOfUser = Console.ReadLine().Substring(0, 1).ToUpper();


            if(answerOfUser == "Y")
            {
                Console.WriteLine("I am the empowered Gandolon - The Visionnaire of the brains!");
            }
            else if(answerOfUser == "N")
            {
                Console.WriteLine("What!? It can't be, you're lying! Gandolon never misses a mindshot!");
            }
            else 
            {
                Console.WriteLine("You can't fool me around giving false answers. This was the card you have!");
            }



        
        }
    }
}
