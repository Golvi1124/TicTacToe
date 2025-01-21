/* 
For base used this link - https://utsavbhattarai.hashnode.dev/how-to-make-tic-tac-toe-console-game-using-c-in-vs-code
Store methods in different tabs? First write a game and then start moving shit around
To try to change:
- different border look
- at the start will display board and that moves are possible by entering 1-9
- Both players have different color when making a move Blue and Green
- Winning message Yellow
- full board without winning Red

 */
namespace TicTacToe;
using TicTacToe.Extras; 
//to actually access all other tabs
using static TicTacToe.Extras.coreInfo;
using static TicTacToe.Extras.Methods;
using static TicTacToe.Extras.MethodsToCheck;


class Program
{
   
    static void Main(string[] args)
    {
        InitializeBoard();

        while (true)
        {
            PrintBoard();
            Console.WriteLine($"Player {currentPlayer}, enter your move (row column): ");
            int row = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());
            if (MakeMove(row, column))
            {
                if (CheckForWin())
                {
                    PrintBoard();
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    break;
                }
                else if (IsBoardFull())
                {
                    PrintBoard();
                    Console.WriteLine("It's a draw!");
                    break;
                }
                TogglePlayer();
            }
            else
            {
                Console.WriteLine("Invalid move, try again.");
            }
        }
    }


   

    

  


}
