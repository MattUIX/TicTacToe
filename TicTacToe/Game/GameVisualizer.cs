﻿using System;

namespace TicTacToe.Game 
{
    class GameVisualizer 
    {

        /// <summary>
        /// Function to print out the current TicTacToe board
        /// </summary>
        /// <param name="ticTacToeBoard">The TicTacToe Board</param>
        public void PrintTicTacToeBoard(string[,] ticTacToeBoard) 
        {
            Console.WriteLine();
            Console.WriteLine("-Board-");
            Console.WriteLine();
            for (var i = 0; i < ticTacToeBoard.GetLength(0); i++) 
            {
                Console.Write("|");
                for (var j = 0; j < ticTacToeBoard.GetLength(0); j++)
                    Console.Write(ticTacToeBoard[i, j] + "|");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Function to fill a newly created TicTacToe Board with empty tiles
        /// </summary>
        /// <param name="ticTacToeBoard">The TicTacToe Board</param>
        public void InitalizeBoard(string[,] ticTacToeBoard) 
        {
            for (var i = 0; i < ticTacToeBoard.GetLength(0); i++) 
            {
                for (var j = 0; j < ticTacToeBoard.GetLength(0); j++)
                    ticTacToeBoard[i, j] = " ";
            }
        }

        /// <summary>
        /// This function prints the instructions for when the applications launched
        /// </summary>
        public void printInstructions() 
        {
            Console.WriteLine("What's TicTacToe?");
            Console.WriteLine("Tic-tac-toe (also known as noughts and crosses or Xs and Os) is a");
            Console.WriteLine("paper -and-pencil game for two players, X and O, who take turns");
            Console.WriteLine("marking the spaces in a 3×3 grid. The player who succeeds in placing");
            Console.WriteLine("three of their marks in a horizontal, vertical, or diagonal row");
            Console.WriteLine("wins the game");
            Console.WriteLine("");
            Console.WriteLine("This game uses coordinates!");
            Console.WriteLine("The X position in this game is the vertical position");
            Console.WriteLine("The Y Position in this game is the horizontal position");
            Console.WriteLine("The center (0,0) is in the top left hand cornor of the board");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("");
        }

    }
}
