using System;

namespace ConsoleApp1
{
    class Player
    {
        private int choice_;
        private int wins_;
        private string name_;
        private string playersChoice_;
        private string Genderchoice_;
        Random rand = new Random(); //the random class gets us a pseudorandom choise between 0 and 1
        //int myrandomnum = rand.Next();

        public int choice
        {
            get { return choice_; }
            set { choice_ = value; }
        }

        public int wins
        {
            get { return wins_; }
            set { wins_ = value; }
        }

        public string name
        {
            get { return name_; }
            set { name_ = value; }
        }

        public string playersChoice
        {
            get { return playersChoice_; }
            set { playersChoice_ = value; }
        }

        public string Genderchoice
        {
            get { return Genderchoice_; }
            set { Genderchoice_ = value; }
        }

        void entername()
        {
            Console.WriteLine($"What is your name?");
            name = Console.ReadLine();

        }

       

    }

   
}