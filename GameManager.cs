public class GameManager
{

    public Player player1;
    public Player player2;

    public Board board;

    public GameManager(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;

        board = new Board();
    }


    //Play the game
    public void PlayGame()
    {
        Player currentPlayer = player1;

        while (true)
        {
            board.PrintBoard();

            Console.WriteLine(currentPlayer.GetName() + "'s turn");

            int position = GetPosition();

            if (!board.PlaceMarker(position, currentPlayer.GetMarker()))
            {
                Console.WriteLine("Invalid move. Try again.");
                continue;
            }

            //check if the board is full

             //check if win or tie
            if (isGameOver(currentPlayer))
            {
                break;
            }

            //change players
           currentPlayer = changePlayer(currentPlayer);
        }
    }
    //Get the position from the user
    private int GetPosition()
    {
        int position = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Enter position (1-9): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out position) && position >= 1 && position <= 9)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
            }
        }

        return position;
    }

    public void PlayComputer()
    {
        //always start with player 1
        Player currentPlayer = player1;

        while (true)
        {
            board.PrintBoard();
            Console.WriteLine(currentPlayer.GetName() + "'s turn");

            // Is the current player a computer? Oddly enough the computer can play itself
            if (currentPlayer.IsComputer())
            {
                int position = board.FindNextPosition();
                Console.WriteLine("Computer chose position " + position);
                if (!board.PlaceMarker(position, currentPlayer.GetMarker()))
                {
                    Console.WriteLine("Invalid move. Try again.");
                    continue;
                }
            }
            else
            {

                int position = GetPosition();

                if (!board.PlaceMarker(position, currentPlayer.GetMarker()))
                {
                    Console.WriteLine("Invalid move. Try again.");
                    continue;
                }
            }

           //check if win or tie
            if (isGameOver(currentPlayer))
            {
                break;
            }

            //change players
           currentPlayer = changePlayer(currentPlayer);
        }
    }


    private bool isGameOver(Player currentPlayer){

         //check if the game is over
                bool isTie = board.CheckForTie();
                bool isWin = board.CheckForWin();
                if (isTie && !isWin)
                {
                    Console.WriteLine("It's a tie!");
                    return true;
                }
                else if (isWin)
                {
                    Console.WriteLine(currentPlayer.GetName() + " wins!");
                    return true;
                }
                return false;

         }

    private Player changePlayer(Player currentPlayer){
        if (currentPlayer == player1)
        {
            return player2;
        }
        else
        {
            return player1;
        }
    }

        //Print the game play instructions
        public void PrintGamePlay()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine($"Player 1 is {player1.GetMarker()}");
            Console.WriteLine($"Player 2 is {player2.GetMarker()}");
            Console.WriteLine();
            Console.WriteLine("The Game Board is made up of boxes numbered 1 thru 9 as shown below:");
            board.PrintBoardStructure();
            Console.WriteLine("Each player will take turns to place their marker in the box by entering the box number.");
        }
    
}
