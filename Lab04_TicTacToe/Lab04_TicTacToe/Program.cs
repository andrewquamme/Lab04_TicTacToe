using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            p1.Marker = "X";
            Player p2 = new Player();
            p2.Marker = "O";

            Console.Write("Player One Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Player Two Name: ");
            p2.Name = Console.ReadLine();
            
            Game game = new Game(p1, p2);
            game.Play();

            Console.Clear();
            game.Board.DisplayBoard();

            try
            {
                Console.WriteLine($"{game.Winner.Name} wins!!");
            }
            catch (Exception)
            {
                Console.WriteLine("There are no winners.\nThe only winning move is not to play.");
            }
            Console.Write("Press any key to exit . . .");
            Console.ReadLine();
        }
    }
}
