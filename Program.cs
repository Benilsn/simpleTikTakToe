using System;
using main.tiktaktoe;
namespace csharp
{
    class Program{
        static void Main(string[] args){

            Random rn = new Random();

            int turn = 1;
            
            while(!TikTakToe.checkWinner()){

                TikTakToe.printBoard();
                TikTakToe.info();
                var x = Console.ReadLine();
                Console.Clear();
                turn = TikTakToe.play(int.Parse(x), turn);
               
                

            turn++;
            }


        }
    }
    

}
