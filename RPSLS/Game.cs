﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //MembVars
        public List<Gesture> GestureList;
        public int RoundsToTWin;
        public Player P1;
        public Player P2;
        //Constr
        public Game()
        {
            GestureList = new List<Gesture> { new Rock(),new Paper(),
                new Scissors(),new Lizard(), new Spock()};
        }
        //MembMeth
        public void DisplayRules()
        {
            Console.Clear();
            Console.WriteLine("Each player chooses a gesture from this list:");
            foreach(Gesture gesture in GestureList)
            {
                Console.WriteLine(gesture.Name);
            }
            Console.WriteLine("\n,then the winner is chosen based on these criteria:");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Two of the same gesture results in a tie.\n");
            Console.WriteLine("Play continues until one player has won the specified number of rounds.");
        }
        private void SetRoundsToWin()
        {
            Console.Clear();
            int rounds;
            do
            {
                Console.WriteLine("Enter the number of rounds needed to win the game:");
                rounds = int.Parse(Console.ReadLine());
            } while (rounds < 2);
            RoundsToTWin = rounds;
        }
        private void ChooseNumberOfPlayers()
        {
            Console.Clear();
            int players;
            do
            {
                Console.WriteLine("Enter the number of players:");
                players = int.Parse(Console.ReadLine());
            } while (players < 1 || players.GetType() != 2.GetType() || players >= 3);
            switch (players)
            {
                case 1:
                    Console.WriteLine("Enter your name:");
                    string newName = Console.ReadLine();
                    P1 = new HumanPlayer(newName);
                    P2 = new AIPlayer();
                    break;
                case 2:
                    Console.WriteLine("Enter Player 1's name:");
                    string p1Name = Console.ReadLine();
                    P1 = new HumanPlayer(p1Name);
                    Console.WriteLine("Enter Player 2's name:");
                    string p2Name = Console.ReadLine();
                    P2 = new HumanPlayer(p2Name);
                    break;
                default:
                    break;
            }
        }
        public void PrintGestureList()
        {
            foreach(Gesture gesture in GestureList)
            {
                Console.WriteLine(gesture.Name);
            }
        }
        public void StartGame()
        {

            ChooseNumberOfPlayers();
            SetRoundsToWin();
            Gesture P1Choice;
            Gesture P2Choice;
            while (P1.RoundsWon < RoundsToTWin && P2.RoundsWon < RoundsToTWin)
            {
                Console.Clear();
                PrintGestureList();
                P1Choice = P1.ChooseGesture(GestureList);
                P2Choice = P2.ChooseGesture(GestureList);
                if (P1Choice.DoITie(P2Choice))
                {
                    Console.WriteLine($"Round is a tie.({P1Choice.Name})");
                    continue;
                }
                else if (P1Choice.DoIBeat(P2Choice))
                {
                    Console.WriteLine($"{P1.Name} wins.");
                    P1.RoundsWon++;
                    P1Choice.PrintVictoryText(P2Choice);
                }
                else
                {
                    Console.WriteLine($"{P2.Name} wins.");
                    P2.RoundsWon++;
                    P2Choice.PrintVictoryText(P1Choice);
                }
                Console.WriteLine($"Current Score: {P1.Name}:{P1.RoundsWon} - {P2.Name}:{P2.RoundsWon}.");
                Console.ReadLine();
            }
            Console.WriteLine($"Final Score: {P1.Name}:{P1.RoundsWon} - {P2.Name}:{P2.RoundsWon}.");
            if (P1.RoundsWon > P2.RoundsWon) {
                Console.WriteLine($"{P1.Name} Wins.");
                    }
            else
            {
                Console.WriteLine($"{P2.Name} Wins.");
            }
        }
    }
}
