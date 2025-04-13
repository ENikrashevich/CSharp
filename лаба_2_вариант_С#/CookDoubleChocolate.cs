using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2_вариант_С_
{
    public class CookDoubleChocolate : ICommand
    {
        CoffeMachine _machine;
        public CookDoubleChocolate(CoffeMachine machine)
        {
            _machine = machine;
        }
        public void Execute(ref int _deposit)
        {
            _machine.CookDoubleChocolate(ref _deposit);
        }
        public void Undo()
        {
            _machine = null;
        }
    }
}
