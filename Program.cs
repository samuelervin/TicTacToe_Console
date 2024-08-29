
        
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
            }
            else{
                keepPlaying = false;
            }
        }   

        Console.WriteLine("Game Over!");
        Console.WriteLine("Thank you for Playing!");

    
