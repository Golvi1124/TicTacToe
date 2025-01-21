namespace TicTacToe.Extras;
using static TicTacToe.Extras.coreInfo;
public class Methods
{
 //..This will initialize the board.
    public static void InitializeBoard()
    {
        Console.WriteLine("\nThis is your new favorite playground!");
        // Initialize the board with empty spaces
        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLUMNS; c++)
            {
                board[r, c] = ' ';
            }
        }
    }

    //..This will print the layout of the board on the console screen.
    public static void PrintBoard()
    {
        // Print the current state of the board
        for (int r = 0; r < ROWS; r++)
        {
            Console.WriteLine("-------------");
            for (int c = 0; c < COLUMNS; c++)
            {
                Console.Write("| ");
                Console.Write(board[r, c]);
                Console.Write(" ");
            }
            Console.WriteLine("|");
        }
        Console.WriteLine("-------------");
    }

    //..This will make a move by the input of user.
    public static bool MakeMove(int row, int column)
    {
        // Check if the move is valid (within the bounds of the board and on an                            empty square)
        if (row >= 0 && row < ROWS && column >= 0 && column < COLUMNS && board[row, column] == ' ')
        {
            // Mark the square with the current player's symbol
            board[row, column] = currentPlayer == Player.X ? 'X' : 'O';
            return true;
        }
        return false;
    }

      //..This will help to switch between the players.
    public static void TogglePlayer()
    {
        currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
    }

}
