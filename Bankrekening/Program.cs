using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class Program
    {
        static void Printmenu()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Geld storten op rekening.");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. Geld afhalen van rekening.");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("3. Toon Saldo.");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("0. EXIT");
            Console.ResetColor();
            Console.WriteLine("Geen kommagetallen geven.");
        }

        static void Main(string[] args)
        {
            Rekening Klant = new Rekening();

            bool finished = false;
            while (!finished)
            {
                Printmenu();
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Transactie beëindigd");
                        Console.ResetColor();
                        finished = true;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Hoeveel geld wilt u storten:");
                        Console.ResetColor();
                        Klant.stort(Convert.ToInt64(Console.ReadLine()));
                        break;
                    case 2:
                        if (Klant.Saldo < 50)
                        {
                            Console.WriteLine("!!! Saldo is niet toereikend. Neem contact op met uw bank !!!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Hoeveel geld wilt u afhalen:");
                            Console.ResetColor();
                            Klant.NeemOp(Convert.ToInt64(Console.ReadLine()));
                        }
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Je totale saldo bedraagt:");
                        Console.WriteLine(Klant.Saldo);
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
