using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2_вариант_С_
{
    public interface ICommand
    {
        public void Execute(ref int _deposit);
        public void Undo();
    }
}
