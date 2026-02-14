namespace TicTacToe
{
    class TicTacToe
    {
        private string[] _grid = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string _firstPlayer;
        private string _secondPlayer;

        public TicTacToe(string firstPlayer, string secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;
        }

        private void PrintGrid()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(_grid[i * 3 + j] + "| ");
                }
                Console.WriteLine();
                Console.WriteLine("---------");
            }
        }

        private void GameLogic()
        {
            bool PlayerOneTurn = true;
            int NumberOfTurns = 0;
            while (NumberOfTurns != 9 && !CheckVictory())
            {
                PrintGrid();

                if (PlayerOneTurn) Console.WriteLine($"{_firstPlayer}'s turn : ");
                else Console.WriteLine($"{_secondPlayer}'s turn : ");

                string choice = Console.ReadLine();

                if (_grid.Contains(choice) && choice != "X" && choice != "O")
                {
                    int index = Convert.ToInt32(choice) - 1;
                    if (PlayerOneTurn) _grid[index] = "X";
                    else _grid[index] = "O";

                PlayerOneTurn = !PlayerOneTurn;
                    NumberOfTurns++;

                }

                Console.Clear();

            }

            if (CheckVictory())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                PrintGrid();
                string winner = PlayerOneTurn ? _secondPlayer : _firstPlayer;
                Console.WriteLine($"WHOAAA, {winner} WIN!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                PrintGrid();

                Console.WriteLine("TIE ):");
            }
        }

        private bool CheckVictory()
        {
            if (_grid[0] == _grid[1] && _grid[1] == _grid[2]) return true;
            if (_grid[3] == _grid[4] && _grid[4] == _grid[5]) return true;
            if (_grid[6] == _grid[7] && _grid[7] == _grid[8]) return true;

            if (_grid[0] == _grid[3] && _grid[3] == _grid[6]) return true;
            if (_grid[1] == _grid[4] && _grid[4] == _grid[7]) return true;
            if (_grid[2] == _grid[5] && _grid[5] == _grid[8]) return true;

            if (_grid[0] == _grid[4] && _grid[4] == _grid[8]) return true;
            if (_grid[2] == _grid[4] && _grid[4] == _grid[6]) return true;

            return false;
        }

        public void Play()
        {
            GameLogic();
        }
    }
}