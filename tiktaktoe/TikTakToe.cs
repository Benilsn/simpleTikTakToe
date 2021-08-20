using System;
namespace main.tiktaktoe
{
    public static class TikTakToe
    {
        public static string[] board = new string[] 
                                                    {"_ ","| ","_ ","| ","_ ","    1 | 2 | 3 \n",
                                                    "_ ","| ","_ ","| ","_ ","    4 | 5 | 6 \n",
                                                    "  ","| ","  ","| ","  ","    7 | 8 | 9 \n\n"};


        public static string[] printBoard(){
            foreach(string i in board){
                Console.Write(i);
            }
            return board;
        }

        public static int convertPosition(int pos){

            switch(pos)
            {
                case 1:
                    pos = 0;
                break;
                case 2:
                    pos = 2;
                break;
                case 3:
                    pos = 4;
                break;
                case 4:
                    pos = 6;             
                break;
                case 5:
                    pos = 8;               
                break;
                case 6:
                    pos = 10;             
                break;
                case 7:
                    pos = 12;              
                break;
                case 8:
                    pos = 14;              
                break;
                case 9:
                    pos = 16;
                break;
            }
            return pos;
        }

        public static bool checkIfEmpty(int x){
            bool free = true;
            if (board[x] != "_ " && board[x] != "  "){
                free = false;
                Console.WriteLine("Posicão Invalida!");
            }
            return free;
        }

        public static int play(int p, int turn){
            int pos = convertPosition(p);
            string c;
            if (turn % 2 == 0){
                c = "O ";
            }else{
                c = "X ";
            }

            if (checkIfEmpty(pos) == true){
                board[pos] = c;
            }else{
                return -1;
            }
            return turn;

        }

        public static void pcPlay(){
            Random rn = new Random();
            int x = rn.Next(1,10);
            int pos = convertPosition(x);


            while (!checkIfEmpty(pos)){
                x = rn.Next(1,10);
                pos = convertPosition(x);
            }
            board[pos] = "O ";
        }

        public static bool checkWinner(){
            bool win = false;
            if (board[0].Equals("X ") && board[2].Equals("X ") && board [4].Equals("X ")){
                win = true;
            }else if(board[6].Equals("X ") && board[8].Equals("X ") && board [10].Equals("X ")){
                win = true;
            }else if(board[12].Equals("X ") && board[14].Equals("X ") && board [16].Equals("X ")){
                win = true;
            }else if (board[0].Equals("X ") && board[6].Equals("X ") && board [12].Equals("X ")){
                win = true;
            }else if (board[2].Equals("X ") && board[8].Equals("X ") && board [14].Equals("X ")){
                win = true;
            }else if (board[4].Equals("X ") && board[10].Equals("X ") && board [16].Equals("X ")){
                win = true;
            }else if (board[0].Equals("X ") && board[8].Equals("X ") && board [16].Equals("X ")){
                win = true;
            }else if(board[4].Equals("X ") && board[8].Equals("X ") && board [12].Equals("X ")){
                win = true;
            }
            if (board[0].Equals("O ") && board[2].Equals("O ") && board [4].Equals("O ")){
                win = true;
            }else if(board[6].Equals("O ") && board[8].Equals("O ") && board [10].Equals("O ")){
                win = true;
            }else if(board[12].Equals("O ") && board[14].Equals("O ") && board [16].Equals("O ")){
                win = true;
            }else if (board[0].Equals("O ") && board[6].Equals("O ") && board [12].Equals("O ")){
                win = true;
            }else if (board[2].Equals("O ") && board[8].Equals("O ") && board [14].Equals("O ")){
                win = true;
            }else if (board[4].Equals("O ") && board[10].Equals("O ") && board [16].Equals("O ")){
                win = true;
            }else if (board[0].Equals("O ") && board[8].Equals("O ") && board [16].Equals("O ")){
                win = true;
            }else if(board[4].Equals("O ") && board[8].Equals("O ") && board [12].Equals("O ")){
                win = true;
            }
            return win;
        }

        public static string returnWinner(){
            string winner = "";
            if (board[0].Equals("X ") && board[2].Equals("X ") && board [4].Equals("X ")){
                winner = "X ";
            }else if(board[6].Equals("X ") && board[8].Equals("X ") && board [10].Equals("X ")){
                winner = "X ";
            }else if(board[12].Equals("X ") && board[14].Equals("X ") && board [16].Equals("X ")){
                winner = "X ";
            }else if (board[0].Equals("X ") && board[6].Equals("X ") && board [12].Equals("X ")){
                winner = "X ";
            }else if (board[2].Equals("X ") && board[8].Equals("X ") && board [14].Equals("X ")){
                winner = "X ";
            }else if (board[4].Equals("X ") && board[10].Equals("X ") && board [16].Equals("X ")){
                winner = "X ";
            }else if (board[0].Equals("X ") && board[8].Equals("X ") && board [16].Equals("X ")){
                winner = "X ";
            }else if(board[4].Equals("X ") && board[8].Equals("X ") && board [12].Equals("X ")){
                winner = "X ";
            }
            if (board[0].Equals("O ") && board[2].Equals("O ") && board [4].Equals("O ")){
                winner = "O ";
            }else if(board[6].Equals("O ") && board[8].Equals("O ") && board [10].Equals("O ")){
                winner = "O ";
            }else if(board[12].Equals("O ") && board[14].Equals("O ") && board [16].Equals("O ")){
                winner = "O ";
            }else if (board[0].Equals("O ") && board[6].Equals("O ") && board [12].Equals("O ")){
                winner = "O ";
            }else if (board[2].Equals("O ") && board[8].Equals("O ") && board [14].Equals("O ")){
                winner = "O ";
            }else if (board[4].Equals("O ") && board[10].Equals("O ") && board [16].Equals("O ")){
                winner = "O ";
            }else if (board[0].Equals("O ") && board[8].Equals("O ") && board [16].Equals("O ")){
                winner = "O ";
            }else if(board[4].Equals("O ") && board[8].Equals("O ") && board [12].Equals("O ")){
                winner = "O ";
            }
            
            switch(winner){
                case "X ":
                    return "CONGRATULATION! YOU WON!";
                case "O ":
                    return "YOU LOSE!";        
            }
            return winner;
        }
    }
}