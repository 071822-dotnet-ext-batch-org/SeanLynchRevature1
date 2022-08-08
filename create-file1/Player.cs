using System;

namespace Trial1
{
    class Player
    {
        private int choice_;
        private int wins_;
        private string name_;
        private string playersChoice_;
        private string Genderchoice_;
        Random rand = new Random(); //the random class gets us a pseudorandom choise between 0 and 1
        int myrandomnum = rand.Next();

        public int choice
        {
            get { return choice_; }
            set { choice_ = value; }
        }

        public int wins
        {
            get{return wins_;}
            set{wins_ = value;}
        }

        public string name
        {
            get{return name_;}
            set{name_ = value;}
        }
        
        public string playersChoice
        {
            get{return playersChoice_;}
            set{playersChoice_ = value;}
        }

        public string Genderchoice
        {
            get{return Genderchoice_;}
            set{Genderchoice_ = value;}
        }

        void entername()
        {
            Console.WriteLine($"What is your name?");
            name = Console.ReadLine();
            
        }

        public void playthegame()
        {
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
            }
            //ask to make another choice if it is a tie
            Console.WriteLine($"player1name won a total of {player1wins} times");
            Console.WriteLine($" and {computername} won a total of {computerwins} times");
            //quit if they don't want to play, loop up to the begin again if they do

            //Game over screen


        }

    }
}