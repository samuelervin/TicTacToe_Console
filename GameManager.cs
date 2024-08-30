public class GameManager{

    public Player player1;
    public Player player2;

    public Board board;

    public GameManager(){
        player1 = new Player("Player 1", "X");
        player2 = new Player("Player 2", "O");

        board = new Board();
    }


//Play the game
    public void PlayGame(){
        Player currentPlayer = player1;

        while(true){
            board.PrintBoard();
    
            Console.WriteLine(currentPlayer.GetName() + "'s turn");
    
            int position = GetPosition();
    
            if(!board.PlaceMarker(position, currentPlayer.GetMarker())){
                Console.WriteLine("Invalid move. Try again.");
                continue;
            }

           //check if the board is full
          
             if(board.CheckForTie()){
                Console.WriteLine("It's a tie!");
                break;
            }
            bool isTie = board.CheckForTie();
            bool isWin = board.CheckForWin();
            if(isTie && !isWin){
                Console.WriteLine("It's a tie!");
                break;
            }else if(isWin){
                Console.WriteLine(currentPlayer.GetName() + " wins!");
                break;
            }
            //change players
            if(currentPlayer == player1){
                currentPlayer = player2;
            }
            else{
                currentPlayer = player1;
            }
        }
    }
//Get the position from the user
    private int GetPosition(){
        int position = 0;
        bool validInput = false;
    
        while(!validInput){
            Console.Write("Enter position (1-9): ");
            string input = Console.ReadLine();
    
            if(int.TryParse(input, out position) && position >= 1 && position <= 9){
                validInput = true;
            }
            else{
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
            }
        }
    
        return position;
    }
    //Print the game play instructions
    public  void PrintGamePlay(){
        Console.WriteLine("Welcome to Tic Tac Toe!");
        Console.WriteLine($"Player 1 is {player1.GetMarker()}");
        Console.WriteLine($"Player 2 is {player2.GetMarker()}");
        Console.WriteLine();
        Console.WriteLine("The Game Board is made up of boxes numbered 1 thru 9 as shown below:");
        board.PrintBoardStructure();
        Console.WriteLine("Each player will take turns to place their marker in the box by entering the box number.");
    }
}