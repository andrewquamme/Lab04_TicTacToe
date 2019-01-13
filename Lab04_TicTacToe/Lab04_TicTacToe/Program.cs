using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Board board = new Board();
            //board.DisplayBoard();

            Player p1 = new Player();
            p1.Marker = "X";
            Player p2 = new Player();
            p1.Marker = "O";

            Console.Write("Player One Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Player Two Name: ");
            p2.Name = Console.ReadLine();
            
            Game game = new Game(p1, p2);
           
        }
    }
}
