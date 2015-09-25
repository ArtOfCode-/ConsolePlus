using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus.Commands
{
    class ExitCommand
    {
        public static string HelpText = "Exits the ConsolePlus instance.";

        public static string CommandMethod(string[] args)
        {
            Environment.Exit(0);
            return "Exiting.";
        }
    }
}
