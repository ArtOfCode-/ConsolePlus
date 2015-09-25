using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus
{
    public class Command : ICommand
    {
        public string Name { get; set; }

        public string HelpText { get; set; }

        public bool IsPrivileged { get; set; }

        private Func<string[], string> method;

        public Command(string name, bool privileged, string help, Func<string[], string> commandMethod)
        {
            Name = name;
            IsPrivileged = privileged;
            HelpText = help;
            method = commandMethod;
        }

        public string Execute(string[] args)
        {
            return method.Invoke(args);
        }
    }
}
