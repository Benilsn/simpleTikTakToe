using System;
namespace main.tiktaktoe
{
    public static class TikTakToe
    {
        public static string[] board = new string[] 
                                                    {"_","|","_","|","_","\n",
                                                    "_","|","_","|","_","\n",
                                                    " ","|"," ","|"," ","\n\n"};
                                                    //0, 2, 4
                                                    //6, 8, 10
                                                    //12, 14, 16

        public static string[] printBoard(){
            foreach(string i in board){
                Console.Write(i);
            }
            return board;
        }

        public static void info(){
            string[] model = new string[] {"1","|","2","|","3\n",
                                           "4","|","5","|","6\n",
                                           "7","|","8","|","9\n"};
                                
            foreach(string i in model){
                Console.Write(i);
            }
            Console.Write("\nEscolha uma posição:");
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
            if (board[x] != "_" && board[x] != " "){
                free = false;
                Console.WriteLine("Posicão Invalida!");
            }
            return free;
        }

        public static int play(int p, int turn){
            int pos = convertPosition(p);
            string c;
            if (turn % 2 == 0){
                c = "O";
            }else{
                c = "X";
            }

            if (checkIfEmpty(pos) == true){
                board[pos] = c;
            }else{
                return -1;
            }
            return turn;

        }

        public static bool checkWinner(){
            bool win = false;
            if (board[0].Equals("X") && board[2].Equals("X") && board [4].Equals("X")){
                win = true;
                returnWinner("X");
            }else if(board[6].Equals("X") && board[8].Equals("X") && board [10].Equals("X")){
                win = true;
                returnWinner("X");
            }else if(board[12].Equals("X") && board[14].Equals("X") && board [16].Equals("X")){
                win = true;
                returnWinner("X");
            }else if (board[0].Equals("X") && board[6].Equals("X") && board [12].Equals("X")){
                win = true;
                returnWinner("X");
            }else if (board[2].Equals("X") && board[8].Equals("X") && board [14].Equals("X")){
                win = true;
                returnWinner("X");
            }else if (board[4].Equals("X") && board[10].Equals("X") && board [16].Equals("X")){
                win = true;
                returnWinner("X");
            }else if (board[0].Equals("X") && board[8].Equals("X") && board [16].Equals("X")){
                win = true;
                returnWinner("X");
            }else if(board[4].Equals("X") && board[8].Equals("X") && board [12].Equals("X")){
                win = true;
                returnWinner("X");
            }
            if (board[0].Equals("O") && board[2].Equals("O") && board [4].Equals("O")){
                win = true;
                returnWinner("O");
            }else if(board[6].Equals("O") && board[8].Equals("O") && board [10].Equals("O")){
                win = true;
                returnWinner("O");
            }else if(board[12].Equals("O") && board[14].Equals("O") && board [16].Equals("O")){
                win = true;
                returnWinner("O");
            }else if (board[0].Equals("O") && board[6].Equals("O") && board [12].Equals("O")){
                win = true;
                returnWinner("O");
            }else if (board[2].Equals("O") && board[8].Equals("O") && board [14].Equals("O")){
                win = true;
                returnWinner("O");
            }else if (board[4].Equals("O") && board[10].Equals("O") && board [16].Equals("O")){
                win = true;
                returnWinner("O");
            }else if (board[0].Equals("O") && board[8].Equals("O") && board [16].Equals("O")){
                win = true;
                returnWinner("O");
            }else if(board[4].Equals("O") && board[8].Equals("O") && board [12].Equals("O")){
                win = true;
                returnWinner("O");
            }
            return win;
        }


        public static string  returnWinner(string x){
            return x;
        }
    }
}