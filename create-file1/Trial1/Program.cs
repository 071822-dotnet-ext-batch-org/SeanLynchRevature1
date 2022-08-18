using System;

namespace Trial1
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome message
            Console.WriteLine("Welcome to, ROCK PAPER SCISSORS");

            //instructions
            Console.WriteLine("Everybody knows how to play rock paper scissors, Scissors beats paper, paper covers rock, rock crushes scissors, EZ\n are you ready to play? Press Enter");


            //(unseen to user) create some variables to store the choice which the user has made
            //computer choice, computer wins, user wins, number of ties, player 1 (user), player 2 (computer for now)
            int computerchoice = 0;
            Random rand = new Random(); //the random class gets us a pseudorandom choise between 0 and 1
            int myrandomnum = rand.Next();
            int computerwins = 0;
            int player1choice = 0;
            int player1wins = 0;
            int numberofties = 0;
            string player1name = "";
            string computername = "";
            string theplayerschoice;
            bool successfulConversion = false;
            bool itsatie = true;
            string playagain = "";

            //start the game by pressing enter
            Console.Read();

            // create variables in the game

            //get the users name
            Console.WriteLine("what is your name?");
            player1name = Console.ReadLine();

            //introduce them to the game

            Console.WriteLine($"Welcome to rock paper scissors, {player1name}");

            //write a loop for the beginning of the game
            while (true)
            {
                // a while look to prompt the user for choices til a tie has not happened
                while (itsatie)
                {
                    Console.WriteLine("Please make your choice....\n\t1 for rock \n\t2 for paper \n\t3 for scissors");
                    theplayerschoice = Console.ReadLine();

                    successfulConversion = Int32.TryParse(theplayerschoice, out player1choice);

                    //use console.writeline in order to get the string of the choice and outcome of the number as an integer

                    // get a random number by the computer
                    computerchoice = (rand.Next(1000) % 3) +1;
                    Console.WriteLine(computerchoice);

                    //evaluate the choices to find out who the winner is
                    //what do you do if it is a tie?
                    if (string.Equals(theplayerschoice, computerchoice))
                    {
                        // tell them it was a tie as a loop back
                        Console.WriteLine($"This round was a tie, you need to try again");
                        //let the tallies update for the game session
                        numberofties++; //other ways to do it are numberofties == numberofties + 1
                        //itsatie = true
                    }
                    // if the user won
                    else if (theplayerschoice == 1 && computerchoice == 3, theplayerschoice == 2 && computerchoice == 1, theplayerschoice == 3 && computerchoice == 2);
                    Console.WriteLine($"Congratulations {player1name} you won this round");
                    //hooray he/she won, write up a code for that, indicating the number of wins
                    player1wins == player1wins + 1;
                    //player1wins += 1 is also acceptable, as well as player1wins++
                    itsatie = false;

                }
                

                    else
                    { //if the computer won, what happens?
                        Console.WriteLine($"I'm sorry, {computername}, has won this round");
                        //well great, the computer won, now what?
                        computerwins == computerwins + 1; //(you know, computerwins += 1 and computerwins++ is also acceptable)
                        itsatie = false;
                    }

              
            // ask if they want to play again, if not then whatever
            Console.WriteLine($"{player1name}, would you like to play again?\n Enter 'Y' for Yes and enter 'N' for No");            
            playagain = Console.ReadLine();
            if (String.Equals("Y", playagain, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"The strings are equal");
                itsatie = true;

            }
            else
            {
                //end the current loop
                Console.WriteLine($"Yeah whatever you're no fun anyway, bye");
                break;
            }
            //ask to make another choice if it is a tie
            Console.WriteLine($"player1name won a total of {player1wins} times");
            Console.WriteLine($" and {computername} won a total of {computerwins} times");
            //quit if they don't want to play, loop up to the begin again if they do

            //Game over screen


        }
    }
};
