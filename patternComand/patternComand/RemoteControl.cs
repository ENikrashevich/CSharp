using patternComand.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternComand
{
    public class RemoteControl
    {
        private Dictionary<int, ICommand> _commands;
        public RemoteControl() 
        {
            _commands = new Dictionary<int, ICommand>();
        }
        public void SetCommandToButton(int buttonId, ICommand command) 
        {
            _commands[buttonId] = command;
        }
        public void PushButton(int buttonId)
        {
            if (_commands.ContainsKey(buttonId))
            {
                _commands[buttonId].Execute();
            }
        }
        public override string? ToString()
        {
            var sb = new StringBuilder();
            foreach (var id in _commands.Keys)
            {
                sb.AppendFormat("{0}\t-\t{1}\n", id, _commands[id]);
            }
            sb.Append("Проч.\t-\tВыход");
            return sb.ToString();
        }
    }
}
