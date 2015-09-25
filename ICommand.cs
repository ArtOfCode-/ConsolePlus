using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus
{
    public interface ICommand
    {
        string Name { get; set; }

        string HelpText { get; set; }

        bool IsPrivileged { get; set; }

        string Execute(string[] args);
    }
}
