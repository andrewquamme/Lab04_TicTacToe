using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTDD
{
    public class GameBoardTests
    {
        [Fact]
        public void Test1()
        {
            Board testBoard = new Board();
            testBoard.GameBoard = new string[,]
            {
                {"X", "2", "3"},
                {"4", "X", "6"},
                {"7", "8", "X"},
            };

            Assert.True()
        }
    }
}
