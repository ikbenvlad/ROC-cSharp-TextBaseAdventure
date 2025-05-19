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
        public CommandType Accessor { get; set; }
        public Action ExecuteCommand { get; set; }

        public Command(string commandInfo, string commandName, int accessor, Action executeCommand)
        {
            CommandInfo = commandInfo;
            CommandName = commandName;
            Accessor = (CommandType)accessor;
            ExecuteCommand = executeCommand;
        }

        public enum CommandType
        {
            Move,
            Attack,
            UseItem,
            Talk,
            Examine,
            Inventory,
            Quit
        }
    }
}
