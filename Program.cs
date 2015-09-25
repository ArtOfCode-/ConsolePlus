using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolePlus.Commands;

namespace ConsolePlus
{
    public class Program
    {
        /// <summary>
        /// The version of the program.
        /// </summary>
        public const string Version = "1.0.0.0";

        public static CommandRegistry<Command> Registry = new CommandRegistry<Command>();

        /// <summary>
        /// The application's entry point.
        /// </summary>
        /// <param name="args">The command-line arguments passed to the program.</param>
        public static void Main(string[] args)
        {
            CommandHandler.RegisterCommands();

            Console.WriteLine("ConsolePlus v." + Version);
            while (true)
            {
                Console.Write(">>> ");
                string line = Console.ReadLine();
                List<string> parts = line.Split(' ').ToList<string>();
                string commandName = parts[0];
                parts.RemoveAt(0);
                string[] commandArgs = parts.ToArray<string>();

                try
                {
                    string result = Registry.Execute(commandName, commandArgs);
                    if (result != null)
                    {
                        Console.WriteLine("[{0}] {1}", commandName, result);
                    }
                }
                catch (CommandNotFoundException)
                {
                    Console.WriteLine("[ConsolePlus] No such command.");
                }
            }
        }
    }
}
