using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2_вариант_С_
{
    public class Management
    {
        ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void PressButton(ref int _deposit)
        {
            _command.Execute(ref _deposit);
        }
        public void UndoCommand()
        {
            _command.Undo();
        }
    }
}
