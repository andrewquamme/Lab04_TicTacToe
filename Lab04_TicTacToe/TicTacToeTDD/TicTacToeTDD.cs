using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTDD
{
    public class GameBoardTests
    {
        //Given a game board, Test for winners

        [Fact]
        public void TestForWinners()
        {
            Player p1 = new Player();
            p1.Name = "P1";
            p1.Marker = "X";
            Player p2 = new Player();
            p2.Name = "P2";
            p2.Marker = "O";
            Game testGame = new Game(p1, p2);
            testGame.Board.GameBoard =  new string[,]
            {
                {"X", "2", "3"},
                {"4", "X", "6"},
                {"7", "8", "X"},
            };
            
            Assert.True(testGame.CheckForWinner(testGame.Board));
        }

        [Fact]
        public void TestForNoWinners()
        {
            Player p1 = new Player();
            p1.Name = "P1";
            p1.Marker = "X";
            Player p2 = new Player();
            p2.Name = "P2";
            p2.Marker = "O";
            Game testGame = new Game(p1, p2);
            testGame.Board.GameBoard = new string[,]
            {
                {"X", "X", "O"},
                {"O", "O", "X"},
                {"X", "O", "X"},
            };

            Assert.False(testGame.CheckForWinner(testGame.Board));
        }
    }

    public class PlayerSwitchTest
    {
        //Test that there is a switch in players between turns

        [Fact]
        public void TestForPlayerSwitch()
        {
            Player p1 = new Player();
            p1.Name = "P1";
            p1.IsTurn = true;
            Player p2 = new Player();
            p2.Name = "P2";
            p2.IsTurn = false;
            Game testGame = new Game(p1, p2);
            testGame.SwitchPlayer();
            Assert.True(p2.IsTurn);
        }
    }

    public class TestEnteredCoordinates
    {
        //Confirm that the position the player inputs correlates to the correct index of the array

        [Fact]
        public void TestForCorrectCoordinates()
        {
            Position testPosition = Player.PositionForNumber(2);
            int[] expected = { 0, 1 };
            int[] actual = new int[2];
            actual[0] = testPosition.Row;
            actual[1] = testPosition.Column;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForIncorrectCoordinates()
        {
            Position testPosition = Player.PositionForNumber(10);
            Assert.Null(testPosition);
        }
    }

    public class AutoGenerateGameBoard
    {
        //One other “unique” test of your own

        [Fact]
        static void TestForAutoGameBoard()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game testGame = new Game(p1, p2);
            string[,] expected = new string[,]
            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            };
            Assert.Equal(expected, testGame.Board.GameBoard);
        }
    }
}
