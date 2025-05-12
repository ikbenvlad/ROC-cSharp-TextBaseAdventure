using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    public class Command
    {
        public string CommandInfo { get; set; }
        public string CommandName { get; set; }
        public int Accessor { get; set; }
        public Action executeCommand { get; set; }
        public Command(string commandInfo, string commandName)
        {
            CommandInfo = commandInfo;
            CommandName = commandName;
            Accessor = 0;
            executeCommand = () => { };
        }
    }
}
