using System;
using System.Threading;
using main.tiktaktoe;
namespace csharp
{
    class Program{
        static void Main(string[] args){

            Random rn = new Random();
            int turn = 1;
            
            while(!TikTakToe.checkWinner()){

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("    Tik Tak Toe!!!   ");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=\n");
                TikTakToe.printBoard();              

                if (turn % 2 == 0){
                    Console.WriteLine("--------------------\n    PC TURN!\n--------------------");
                    Thread.Sleep(3000);
                    TikTakToe.pcPlay(); 
                }else{
                    Console.WriteLine("------------------\n    YOUR TURN!\n------------------\n");
                    Console.Write("Choose a position: ");
                    var x = Console.ReadLine();
                    turn = TikTakToe.play(int.Parse(x), turn); 
                }

                Console.Clear();
            turn++;
            }
            TikTakToe.printBoard();
            Console.WriteLine();
            Console.WriteLine(TikTakToe.returnWinner());
            Console.WriteLine();

        }
    }
}
