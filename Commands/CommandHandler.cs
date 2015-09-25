using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus.Commands
{
    public class CommandHandler
    {
        public static List<Command> AllCommands = new List<Command>
        {
            new Command("clear", false, ClearCommand.HelpText, ClearCommand.CommandMethod),
            new Command("exit", false, ExitCommand.HelpText, ExitCommand.CommandMethod)
        };

        public static void RegisterCommands()
        {
            foreach (Command command in AllCommands)
            {
                Program.Registry.RegisterCommand(command);
            }
        }
    }
}
