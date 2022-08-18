using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Game
    { 
        private Random rand = new Random();//Can be a local variable //the random class gets us a pseudorandom choise between 0 and 1
        //int myrandomnum = rand.Next();  can be a local variable 
        private int numberofties; //Instance variable/class variable
        private bool successfulConversion;
        private bool itsatie;
        private string playagain;

        private int testInput(string input)//input is a parameter
        {
            int testStr = 0;//set up int variable to test string
            successfulConversion = Int32.TryParse(input, out testStr);//Input valadation
            while (successfulConversion == false)//If tryParse returns false, put user inside of a loop
            {
                Console.WriteLine("Invalid input, please try again");//Tell the user about the mistake.
                input = Console.ReadLine();//Give the user a chance to correct their mistake.
                successfulConversion = Int32.TryParse(input, out testStr);//Test the input aganist the results
            }
            testStr = int.Parse(input);//Once we have a correct string from the user, convert it to an int.
            return testStr;
        }

        private void showChoice(string choice)
        {
            switch (choice)//A switch is a simpler if statement
            {
                case "1":
                    Console.WriteLine("Rock");
                    break;
                case "2":
                    Console.WriteLine("Paper");
                    break;
                case"3":
                    Console.WriteLine("Scissors");
                    break;
                case"4":
                    Console.WriteLine("Lizard");
                    break;
                case"5":
                    Console.WriteLine("Spock");
                    break;
            }
        }

        private string WhoWon(string player1, string player2)
        {
            //else if (player1.playersChoice == "1" && player2.playersChoice == "3" || player1.playersChoice == "2" && player2.playersChoice == "1", player1.playersChoice == "3" && player2.playersChoice == "4", player1.playersChoice == "4" && player2.playersChoice == "5", player1.playersChoice == "5" && player2.playersChoice == "3", player1.playersChoice == "4" && player2.playersChoice == "2", player1.playersChoice == "2" $$ player2.playersChoice == "5", player1.playersChoice == "5" && player2.playersChoice == "1", player1.playersChoice == "3" && player2.playersChoice == "2")
            //With else if, only one situation can happen - if the "else-ifs" were ifs, they can happen in tandem
            if (player1 == "3" && player2 == "2")
            {
                Console.WriteLine("You win, your scissors cut the opponents paper");
                return "player1";
            }
            else if (player1 == "2" && player2 == "1")
            {
                Console.WriteLine("You win, your paper covered the opponents rock");
                return "player1";
            }
            else if (player1 == "1" && player2 == "4")
            {
                Console.WriteLine("You win, your rock crushed the opponents lizard");
                return "player1";
            }
            else if (player1 == "4" && player2 == "5")
            {
                Console.WriteLine("You win, your lizard poisoned the opponents spock");
                return "player1";
            }
            else if (player1 == "5" && player2 == "3")
            {
                Console.WriteLine("You win, your spock smashed the opponents scissors");
                return "player1";
            }
            else if (player1 == "3" && player2 == "4")
            {
                Console.WriteLine("You win, your scissors decapitated the opponents lizard");
                return "player1";
            }
            else if (player1 == "4" && player2 == "2")
            {
                Console.WriteLine("You win, your lizard ate the opponents paper");
                return "player1";
            }
            else if (player1 == "2" && player2 == "5")
            {
                Console.WriteLine("You win, your paper disproved the opponents spock");
                return "player1";
            }
            else if (player1 == "5" && player2 == "1")
            {
                Console.WriteLine("You win, your spock vaporized the opponents rock");
                return "player1";
            }
            else if (player1 == "1" && player2 == "3")
            {
                Console.WriteLine("You win, your rock crushed the opponents scissors");
                return "player1";
            }
            else if (player1 == "2" && player2 == "3")
            {
                Console.WriteLine("You lose, your paper was cut by the opponents scissors");
                return "player2";
            }
            else if (player1 == "1" && player2 == "2")
            {
                Console.WriteLine("You lose, your rock was covered by the opponents paper");
                return "player2";
            }
            else if (player1 == "4" && player2 == "1")
            {
                Console.WriteLine("You lose, your lizard was smashed by the opponents rock");
                return "player2";
            }
            else if (player1 == "5" && player2 == "4")
            {
                Console.WriteLine("You lose, your spock was poisoned by the opponents lizard");
                return "player2";
            }
            else if (player1 == "3" && player2 == "5")
            {
                Console.WriteLine("You lose, your scissors were smashed by the opponents spock");
                return "player2";
            }
            else if (player1 == "4" && player2 == "3")
            {
                Console.WriteLine("You lose, your lizard was decapitated by the opponents scissors");
                return "player2";
            }
            else if (player1 == "2" && player2 == "4")
            {
                Console.WriteLine("You lose, your paper was eaten by the opponents lizard");
                return "player2";
            }
            else if (player1 == "5" && player2 == "2")
            {
                Console.WriteLine("You lose, your spock was disproven by the opponents paper");
                return "player2";
            }
            else if (player1 == "1" && player2 == "5")
            {
                Console.WriteLine("You lose, your rock was vaporized by the opponents spock");
                return "player2";
            }
            else if (player1 == "3" && player2 == "1")
            {
                Console.WriteLine("You lose, your scissors were crushed by the opponents rock");
                return "player2";
            }
            return "No one won";
           

        }

        public void playthegame(Player player1, Player player2)
        {
            itsatie = true;
            //write a loop for the beginning of the game
            while (true)
            {
                // a while look to prompt the user for choices til a tie has not happened
                while (itsatie)
                {
                    Console.WriteLine("Please make your choice....\n\t1 for rock \n\t2 for paper \n\t3 for scissors\n\t4 for lizard\n\t5 for spock");
                    player1.playersChoice = Console.ReadLine();
                    int convertChoice = testInput(player1.playersChoice); //playersChoice is an argument
                                                                          //use console.writeline in order to get the string of the choice and outcome of the number as an integer
                    Console.WriteLine("{0} picked ", player1.name);
                    showChoice(player1.playersChoice);
                    // get a random number by the computer
                    player2.playersChoice = ((rand.Next(1000) % 5) + 1).ToString();
                    Console.WriteLine("{0} picked ", player2.name);
                    showChoice(player2.playersChoice);//Display user's choice

                    //evaluate the choices to find out who the winner is
                    //what do you do if it is a tie?
                    if (string.Equals(player1.playersChoice, player2.playersChoice))
                    {
                        // tell them it was a tie as a loop back
                        Console.WriteLine("This round was a tie, you need to try again");
                        //let the tallies update for the game session
                        numberofties++; //other ways to do it are numberofties == numberofties + 1
                        //itsatie = true
                    }
                    if (WhoWon(player1.playersChoice, player2.playersChoice) == "player1")
                    {
                        player1.wins++;
                        itsatie = false;
                    }
                    else if (WhoWon(player1.playersChoice, player2.playersChoice) == "player2") //else alone also works
                    {
                        player2.wins++;
                        itsatie = false;
                    }
                    else
                    {
                        Console.WriteLine("No one won, bummer"); 
                    }                    // if the user won
                    //else if (player1.playersChoice == "1" && player2.playersChoice == "3", player1.playersChoice == "2" && player2.playersChoice == "1", player1.playersChoice == "3" && player2.playersChoice == "4", player1.playersChoice == "4" && player2.playersChoice == "5", player1.playersChoice == "5" && player2.playersChoice == "3", player1.playersChoice == "4" && player2.playersChoice == "2", player1.playersChoice == "2" $$ player2.playersChoice == "5", player1.playersChoice == "5" && player2.playersChoice == "1", player1.playersChoice == "3" && player2.playersChoice == "2")
                    //{ Console.WriteLine($"Congratulations {player1name} you won this round");
                    ////hooray he/she won, write up a code for that, indicating the number of wins
                    //player1wins == player1wins + 1;
                    ////player1wins += 1 is also acceptable, as well as player1wins++
                    //itsatie = false; 
                    //}



                    //else
                    //{ //if the computer won, what happens?
                    //    Console.WriteLine($"I'm sorry, {computername}, has won this round");
                    //    //well great, the computer won, now what?
                    //    computerwins == computerwins + 1; //(you know, computerwins += 1 and computerwins++ is also acceptable)
                    //    itsatie = false;
                    //}
                }

                // ask if they want to play again, if not then whatever
                Console.WriteLine("Would you like to play again?\n Enter 'Y' for Yes and enter 'N' for No");
                playagain = Console.ReadLine();
                if (String.Equals("Y", playagain, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("The strings are equal");
                    itsatie = true;
                    numberofties++;
                }
                else if (String.Equals("N", playagain, StringComparison.OrdinalIgnoreCase))
                {
                    //end the current loop
                    Console.WriteLine("Yeah whatever you're no fun anyway, bye");
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, what was that?");
                }
            }
            //ask to make another choice if it is a tie
            Console.WriteLine($"You won a total of {player1.wins} times");
            Console.WriteLine($" and they won a total of {player2.wins} times");
            //quit if they don't want to play, loop up to the begin again if they do

            //Game over screen


        }
    }
}
