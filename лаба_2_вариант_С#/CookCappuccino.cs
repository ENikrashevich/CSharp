using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2_вариант_С_
{
    public class CookCappuccino : ICommand
    {
        CoffeMachine _machine;
        public CookCappuccino(CoffeMachine machine)
        {
            _machine = machine;
        }
        public void Execute(ref int _deposit)
        {
            _machine.CookCappuccino(ref _deposit);
        }
        public void Undo()
        {
            _machine = null;
        }
    }
}
