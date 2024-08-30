
        
        // initial game play
        GameManager gameManager = new GameManager();
        gameManager.PrintGamePlay();
        gameManager.PlayGame();

    // would you like to continue play
        bool keepPlaying = true;
    
        while(keepPlaying){
            Console.WriteLine("Play Again? (Y/N)");
            string playAgain = Console.ReadLine();
            
            if(playAgain.ToLower() == "y"){
                gameManager.board.ResetBoard();
                gameManager.PlayGame();
            }else if(playAgain.ToLower() == "n"){
                keepPlaying = false;
            }
            else{
                Console.WriteLine("Invalid input. Please enter Y to play again or N to exit.");
            }
        }   

        Console.WriteLine("Game Over!");
        Console.WriteLine("Thank you for Playing!");

    
