namespace TicTacToe.Extras;

public class coreInfo
{
// Constant values for the size of the game board
    public const int ROWS = 3;
    public const int COLUMNS = 3;

    // 2D array to represent the game board
    public static char[,] board = new char[ROWS, COLUMNS];

    // Enum to represent the current player
    public enum Player
    {
        X, O
    }

    //Variable to store the current player
    public static Player currentPlayer = Player.X;
}

