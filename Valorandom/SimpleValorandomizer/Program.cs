using System;

namespace SimpleValorandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool power = false;
            int player1, player2, player3, player4, player5 = -1;
            string[] agentList = new string[] {"Astra", "Breach", "Brimstone", "Chamber", "Cypher", "Jett", "KAY/O", "Killjoy", "Neon", "Omen",
                "Phoenix", "Raze", "Reyna", "Sage", "Skye", "Sova", "Viper", "Yoru"};
            Random numberGen = new Random();
            
            while (power == false)
            {
                Console.WriteLine("Your Team:");
                agentRoller();
                results();
                Console.WriteLine("Reroll? [y/n]");
                power = Console.ReadKey().Key == ConsoleKey.N;
                Console.Clear();
            }
            

            void agentRoller()
            {
                do
                {
                    player1 = numberGen.Next(0, agentList.Length);
                    //Console.WriteLine("player1 attempt: " + player1); //debugging
                }
                while (player1 < 0);
                do
                {
                    player2 = numberGen.Next(0, agentList.Length);
                    //Console.WriteLine("player2 attempt: " + player2); //debugging
                }
                while (player2 < 0 || player2 == player1);
                do
                {
                    player3 = numberGen.Next(0, agentList.Length);
                    //Console.WriteLine("player3 attempt: " + player3); //debugging
                }
                while (player3 < 0 || player3 == player1 || player3 == player2);
                do
                {
                    player4 = numberGen.Next(0, agentList.Length);
                    //Console.WriteLine("player4 attempt: " + player4); //debugging
                }
                while (player4 < 0 || player4 == player1 || player4 == player2 || player4 == player3);
                do
                {
                    player5 = numberGen.Next(0, agentList.Length);
                    //Console.WriteLine("player5 attempt: " + player5); //debugging
                }
                while (player5 < 0 || player5 == player1 || player5 == player2 || player5 == player3 || player5 == player4);
            }

            void results()
            {
                Console.WriteLine("Player 1: " + agentList[player1]);
                Console.WriteLine("Player 2: " + agentList[player2]);
                Console.WriteLine("Player 3: " + agentList[player3]);
                Console.WriteLine("Player 4: " + agentList[player4]);
                Console.WriteLine("Player 5: " + agentList[player5]);
            }
            
        }
    }
}
