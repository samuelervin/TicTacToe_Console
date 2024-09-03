

      
      
      //get player1 name
        Console.WriteLine("Player 1, enter your name: ");  
        string player1Name = Console.ReadLine();
        string player2Name = "Computer";


     // do you want to play against computer
        Console.WriteLine("Do you want to play against the computer? (Y/N)");
        string playAgainstComputer = Console.ReadLine();
        bool isComputer = false;
        // if user wants to play against computer
        if(playAgainstComputer.ToLower() == "y"){
            isComputer = true;
        }
        // if not playing against computer, get player2 name
        if(!isComputer){
            Console.WriteLine("Player 2, enter your name: ");
            player2Name = Console.ReadLine();
        }
    

        Player player1 = new Player(player1Name, "X", true);
        Player player2 = new Player(player2Name, "O", isComputer);
      
        // initial game play
        GameManager gameManager = new GameManager(player1,player2);
        gameManager.PrintGamePlay();

        gameManager.PlayComputer();

    // would you like to continue play
        bool keepPlaying = true;
    
        while(keepPlaying){
            Console.WriteLine("Play Again? (Y/N)");
            string playAgain = Console.ReadLine();
            
            if(playAgain.ToLower() == "y"){
                gameManager.board.ResetBoard();
                gameManager.PlayComputer();
           }else if(playAgain.ToLower() == "n"){
                keepPlaying = false;
            }
            else{
                Console.WriteLine("Invalid input. Please enter Y to play again or N to exit.");
            }
        }   

        Console.WriteLine("Game Over!");
        Console.WriteLine("Thank you for Playing!");
