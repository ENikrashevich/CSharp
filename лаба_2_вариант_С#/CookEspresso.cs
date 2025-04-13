﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2_вариант_С_
{
    public class CookEspresso : ICommand
    {
        CoffeMachine _machine;
        public CookEspresso(CoffeMachine machine)
        {
            _machine = machine;
        }
        public void Execute(ref int _deposit)
        {
            _machine.CookEspresso(ref _deposit);
        }
        public void Undo()
        {
            _machine = null;
        }
    }
}
