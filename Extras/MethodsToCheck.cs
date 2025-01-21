namespace TicTacToe.Extras;

using static TicTacToe.Extras.coreInfo;
public class MethodsToCheck
{
//..This is the core function that checks the win.
    public static bool CheckForWin()
    {
        // Check rows
        for (int r = 0; r < ROWS; r++)
        {
            if (board[r, 0] == board[r, 1] && board[r, 1] == board[r, 2] && board[r, 0] != ' ')
            {
                return true;
            }
        }

        // Check columns
        for (int c = 0; c < COLUMNS; c++)
        {
            if (board[0, c] == board[1, c] && board[1, c] == board[2, c] && board[0, c] != ' ')
            {
                return true;
            }
        }

        // Check diagonals
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
        {
            return true;
        }
        if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] != ' ')
        {
            return true;
        }

        return false;
    }

    //..If the board is full (When the game is drawn), This function will help to identify it.
    public static bool IsBoardFull()
    {
        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLUMNS; c++)
            {
                if (board[r, c] == ' ')
                {
                    return false;
                }
            }
        }
        return true;
    }
}
