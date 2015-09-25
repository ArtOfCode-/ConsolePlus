using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus.Commands
{
    class ClearCommand
    {
        public static string HelpText = "Clears the console screen.";

        public static string CommandMethod(string[] args)
        {
            Console.Clear();
            return null;
        }
    }
}
