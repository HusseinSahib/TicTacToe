//Change History
//Date          Developer               Description
//2021-03-06    Hussein Sahib          -Design and Creation of Program TicTacToe
//2021-03-06    Hussein Sahib          -Adding comments and program explanation
//2021-03-06    Hussein Sahib          -testing the program with single player mode
//2021-03-06    Hussein Sahib          -testing the program with two player mode
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
########################################
This is a TikTacToe game of 3*3 square
########################################\n");
            //instructions for players to pick a mode
            Console.Write("Please, press 1 for single player mode or press 2 for two player mode: ");
            int gameMode = int.Parse(Console.ReadLine());
            //if else statment to call the respective functions for to start the game mode chosen
            if (gameMode == 1)
            {
                gameModeOne();
            }
            else if (gameMode == 2)
            {
                gameModeTwo();
            }
            else
            {
                //display error if other numbers picked that are not 1 or 2 
                Console.WriteLine("ERROR: wrong input...");
            }
        }
        //This method runs the two player mode 
        private static void gameModeTwo()
        {
            Console.WriteLine("\nWelcome to game mode 2!");
            //intilize the gameboard
            TicTacToe game = new TicTacToe();
            int winner = 0;
            int currentPlayer = 1;
            int spotChoice = 0;
            //This while loop goes on until we have a winner
            while (winner == 0)
            {
                Console.WriteLine($"Player {currentPlayer}, its your turn");
                //display game board
                Console.WriteLine(game.ToString());

                Console.Write("Please enter the spot number: ");
                spotChoice = int.Parse(Console.ReadLine());
                game.PlayTurn(spotChoice, currentPlayer);
                //Determine if a player has won
                if(game.GameResults(game.GameBoard,currentPlayer) != 0 && game.GameResults(game.GameBoard, currentPlayer) != 3)
                {
                    Console.WriteLine(game.ToString());
                    Console.WriteLine($"Congrats player {currentPlayer} is the winner ");
                    winner = currentPlayer;

                }
                //determine if the game ended in a draw
                else if (game.GameResults(game.GameBoard, currentPlayer) == 3)
                {
                    Console.WriteLine(game.ToString());
                    Console.WriteLine($"Good Job all, its a tie !");
                    winner = currentPlayer;

                }
                //switch turns between players
                else
                {
                    if (currentPlayer == 1)
                    {
                        currentPlayer = 2;
                    }
                    else if(currentPlayer == 2)
                    {
                        currentPlayer = 1;
                    }
                }
            }

        }
        //
        private static void gameModeOne()
        {
            Console.WriteLine("\nWelcome to game mode 1! you are player 1");
            TicTacToe game = new TicTacToe();
            int winner = 0;
            int currentPlayer = 1;
            int spotChoice = 0;
            Random rand = new Random();
            int vaildRand = 0;
            //This while loop runs the game until it ends
            while (winner == 0)
            {
                Console.WriteLine($"Player {currentPlayer}, its your turn");
                //display game board
                Console.WriteLine(game.ToString());
                //the main player turn
                if (currentPlayer == 1)
                {
                    Console.Write("Please enter the spot number: ");
                    spotChoice = int.Parse(Console.ReadLine());
                    game.PlayTurn(spotChoice, currentPlayer);
                }
                //the automated player turn
                else if (currentPlayer == 2)
                {
                    while (vaildRand != 1)
                    {
                        spotChoice = rand.Next(1, 10);
                        vaildRand = game.PlayTurn(spotChoice, currentPlayer);
                    }
                    vaildRand = 0;
                }

                //Determine if a player has won
                if (game.GameResults(game.GameBoard, currentPlayer) != 0 && game.GameResults(game.GameBoard, currentPlayer) != 3)
                {
                    Console.WriteLine(game.ToString());
                    Console.WriteLine($"Congrats player {currentPlayer} is the winner ");
                    winner = currentPlayer;

                }
                //determine if the game ended in a draw
                else if (game.GameResults(game.GameBoard, currentPlayer) == 3)
                {
                    Console.WriteLine(game.ToString());
                    Console.WriteLine($"Good Job all, its a tie !");
                    winner = currentPlayer;

                }
                //switch turns between players
                else
                {
                    if (currentPlayer == 1)
                    {
                        currentPlayer = 2;
                    }
                    else if (currentPlayer == 2)
                    {
                        currentPlayer = 1;
                    }
                }
            }
        }
    }
}
