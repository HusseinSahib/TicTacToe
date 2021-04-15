//Change History
//Date          Developer               Description
//2021-03-06    Hussein Sahib          -Design and Creation of class TicTacToe
//2021-03-06    Hussein Sahib          -Designing methods and determining their input and out put
//2021-03-06    Hussein Sahib          -Adding comments and program explanation
//2021-03-06    Hussein Sahib          -testing the class using the TicTacToe program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        //This two dimentional array acts as the game board for tictactoe
        private int[,] gameBoard = new int[3, 3];
        //This is the constructor for the class that intilizes the two dimentional array
        public TicTacToe()
        {
            //this for loop intilizes the two dimentional array
            for (int outer = 0; outer < 3; outer++)
            {
                for (int inner = 0; inner < 3; inner++)
                {
                    //sets all array elements to 0
                    gameBoard[outer, inner] = 0;
                }
            }
        }
        //seting up the get and set for the two dimentinoal array that acts as the board for the game
        public int[,] GameBoard{
            get
            {
                return gameBoard;
            }
            set
            {
                gameBoard = value;
            }
        }
        //This method prints the TicTacToe game board it over writes the class's ToString method
        public override string ToString()
        {
            //setting up string and formating it
            string str = string.Empty;
            str += $"\n              Pick a number to play in the numbers spot\n";
            str += $" {gameBoard[0, 0]} # {gameBoard[1, 0]} # {gameBoard[2, 0]}  |  1 # 2 # 3 \n";
            str += $"########### | ########### \n";
            str += $" {gameBoard[0, 1]} # {gameBoard[1, 1]} # {gameBoard[2, 1]}  |  4 # 5 # 6 \n";
            str += $"########### | ########### \n";
            str += $" {gameBoard[0, 2]} # {gameBoard[1, 2]} # {gameBoard[2, 2]}  |  7 # 8 # 9 \n\n";
            str += $"____________________________\n\n";

            return str;
        }
        //This function checks the board i.e. the two dimentional array to check if a player has won or the game ended in a draw, or the game is still going
        public int GameResults(int[,] board, int player)
        {
            //returns the result 1 means player 1 won 2 player two won and 3 is a draw and 0 game is still going
            int result = 0;
            //check for draw
            bool isTie = true;

            // These if else statment check the state of the game
            if (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player)
            {
                result = player;
            }
            else if (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player)
            {
                result = player;
            }
            else if (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player)
            {
                result = player;
            }
            else if (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player)
            {
                result = player;
            }
            else if (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player)
            {
                result = player;
            }
            else if (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player)
            {
                result = player;
            }
            else if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            {
                result = player;
            }
            else if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                result = player;
            }
            else
            {
                //0 means game is still going with no winner or draw
                result = 0;
            }
            for (int outer = 0; outer < 3; outer++)
            {
                for (int inner = 0; inner < 3; inner++)
                {
                    if(gameBoard[outer, inner] == 0)
                    {
                        //istie is set to false to make sure that there is no tie
                        isTie = false;
                    }
                        
                }
            }
            if (isTie)
            {
                //if there is a tie return 3
                result = 3;
            }
            return result;
        }
        //This function puts player number in the slot they picked, it returns 1 for success in doing so and 0 if it fail
        public int PlayTurn(int box, int player)
        {
            int results = 1;
            if (box == 1 && gameBoard[0, 0] == 0)
            {
                gameBoard[0,0]= player;
            }
            else if (box == 2 && gameBoard[1, 0] == 0)
            {
                gameBoard[1, 0] = player;
            }
            else if (box == 3 && gameBoard[2, 0] == 0)
            {
                gameBoard[2, 0] = player;
            }
            else if (box == 4 && gameBoard[0, 1] == 0)
            {
                gameBoard[0, 1] = player;
            }
            else if (box == 5 && gameBoard[1, 1] == 0)
            {
                gameBoard[1, 1] = player;
            }
            else if (box == 6 && gameBoard[2, 1] == 0)
            {
                gameBoard[2, 1] = player;
            }
            else if (box == 7 && gameBoard[0, 2] == 0)
            {
                gameBoard[0, 2 ] = player;
            }
            else if (box == 8 && gameBoard[1, 2] == 0)
            {
                gameBoard[1, 2] = player;
            }
            else if (box == 9 && gameBoard[2, 2] == 0)
            {
                gameBoard[2, 2] = player;
            }

            else
            {
                //if no slot was changed resturn 0
                results = 0;
            }
            return results;
        }
    }
}
