using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multi_Roblox
{
    class Program
    {
        static void Main(string[] args)
        {
            new Mutex(true, "ROBLOX_singletonMutex");

            Console.Title = "Multi Roblox - ImmuneLion318#0001";
            Console.SetWindowSize(80, 20);

            string Watermark = @"
  ___  ___      _ _   _  ______      _     _           
  |  \/  |     | | | (_) | ___ \    | |   | |          
  | .  . |_   _| | |_ _  | |_/ /___ | |__ | | _____  __
  | |\/| | | | | | __| | |    // _ \| '_ \| |/ _ \ \/ /
  | |  | | |_| | | |_| | | |\ \ (_) | |_) | | (_) >  < 
  \_|  |_/\__,_|_|\__|_| \_| \_\___/|_.__/|_|\___/_/\_\
                                                       
                                                     ";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Watermark);
            Console.ResetColor();
            Console.WriteLine("  Keep This Console Open To Run Multiple Roblox Clients \n  If Closed Some Of The Clients Will Shutdown \n " +
                " Each Client Must Have A Different Accounts Logged In");
            Console.ReadLine();
        }
    }
}
