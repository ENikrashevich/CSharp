﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2_вариант_С_
{
    public class CookClassicChocolate : ICommand
    {
        CoffeMachine _machine;
        public CookClassicChocolate(CoffeMachine machine)
        {
            _machine = machine;
        }
        public void Execute(ref int _deposit)
        {
            _machine.CookClassicChocolate(ref _deposit);
        }
        public void Undo()
        {
            _machine = null;
        }
    }
}
