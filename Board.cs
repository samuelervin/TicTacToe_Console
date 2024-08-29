//Board Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Board{

    //create a dictionary to store the board
    private Dictionary<int, string> board;

    public Board(){
        //initialize the board
        board = new Dictionary<int, string>();
        for(int i = 1; i <= 9; i++){
            board.Add(i, " ");
        }

    
    }

    public void PrintBoard(){
        Console.WriteLine(" " + board[1] + " | " + board[2] + " | " + board[3]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" " + board[4] + " | " + board[5] + " | " + board[6]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" " + board[7] + " | " + board[8] + " | " + board[9]);
    }

       public void PrintBoardStructure(){
       Console.WriteLine(" 1 | 2 | 3 ");
        Console.WriteLine("---|---|---");
         Console.WriteLine(" 4 | 5 | 6 ");
        Console.WriteLine("---|---|---");
        Console.WriteLine(" 7 | 8 | 9 ");
    }


    public bool PlaceMarker(int position, string marker){
        if(board[position] == " "){
            board[position] = marker;
            return true;
        }
        else{
            return false;
        }
    }

    public bool CheckForWin(){
        //check rows
        for(int i = 1; i <= 7; i += 3){
            if(board[i] != " " && board[i] == board[i + 1] && board[i] == board[i + 2]){
                return true;
            }
        }

        //check columns
        for(int i = 1; i <= 3; i++){
            if(board[i] != " " && board[i] == board[i + 3] && board[i] == board[i + 6]){
                return true;
            }
        }

        //check diagonals
        if(board[1] != " " && board[1] == board[5] && board[1] == board[9]){
            return true;
        }
        if(board[3] != " " && board[3] == board[5] && board[3] == board[7]){
            return true;
        }

        return false;
    }

    public bool CheckForTie(){
        for(int i = 1; i <= 9; i++){
            if(board[i] == " "){
                return false;
            }
        }
        return true;
    }

    public void ResetBoard(){
        for(int i = 1; i <= 9; i++){
            board[i] = " ";
        }
    }

    
}